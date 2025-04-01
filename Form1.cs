using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Xml;
using KUKA.RSI;
using KUKA.RSI.Sensors;
using KUKA.RSI.Sensors.Exceptions;
using SettingsExtra;

namespace Kuka_Client_2 {

    public partial class Form1 : Form {
        private const string SaveFilePath = "AppSettings.xml";
        public string? SaveHistoryPath = null;
        public MyDictionary dict = new();
        private bool isEditing;
        private string? editingKey;
        bool propertychangednow = false;
        bool isEditingNew = false;
        Dictionary<string, int>? ShiftedTable;

        public RSIFBSensor? Sensor { get; set; }
        public Form1() {
            InitializeComponent();
            InitDataGridView(dataGridViewGet);
            InitDataGridView(dataGridViewSend);
            dict.PropertyChanged += MyDictionary_PropertyChanged;
            comboBoxSV.Items.AddRange(Enum.GetNames(typeof(ShiftedValueMode)));
            comboBoxSV.SelectedIndex = 0;

            var doc = XmlSettings.DocunentInit(SaveFilePath);
            LoadStateControls(doc);

            Tips.Control_MouseEnter += Control_MouseEnter;
            Tips.AddMouseEnterTips(this);

        }

        public static void InitDataGridView(DataGridView dataGridView) {
            var keyColumn = new DataGridViewTextBoxColumn {
                HeaderText = "»Ïˇ Ô‡‡ÏÂÚ‡",
                DataPropertyName = "Key",
                Width = 120
            };
            var valueColumn = new DataGridViewTextBoxColumn {
                HeaderText = "«Ì‡˜ÂÌËÂ",
                DataPropertyName = "Value"
            };
            dataGridView.Columns.Add(keyColumn);
            dataGridView.Columns.Add(valueColumn);
            dataGridView.AutoGenerateColumns = false;
        }

        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                isEditing = true;
                if (dataGridViewGet.Rows[e.RowIndex].Cells[0].Value != null) {
                    editingKey = dataGridViewGet.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            isEditing = false;
            isEditingNew = false;
            editingKey = string.Empty;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (!isEditing)
                return;
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) {
                string? key = dataGridViewGet.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string? value = dataGridViewGet.Rows[e.RowIndex].Cells[1].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value)) {
                    dict[key] = value;
                    ChangeValue(key, value);
                } else if (!string.IsNullOrWhiteSpace(key))
                    dataGridViewGet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dict[key];
                else {
                    ResetCellValue(dict.GetItems()[e.RowIndex].Key);
                }
            } else if (e.ColumnIndex == 0) {
                ResetCellValue(dict.GetItems()[e.RowIndex].Key);
            }
        }

        private void ChangeValue(string key, string value) {
            if (timer1.Enabled && Sensor != null) {
                Sensor.SendTag(key, value);
            }
        }

        private void ResetCellValue(string Key) {
            bool lastisEditing = isEditing;
            isEditing = false;
            MyDictionary_PropertyChanged(null, new PropertyChangedEventArgs(Key));
            isEditing = lastisEditing;
        }


        private void MyDictionary_PropertyChanged(object? sender, PropertyChangedEventArgs e) {
            if (propertychangednow)
                return;

            if (isEditing) {
                if (editingKey == e.PropertyName)
                    return;
            }
            propertychangednow = true;
            var a = dict.GetItems();
            int aindex = a.FindIndex(0, x => x.Key == e.PropertyName);
            if (dataGridViewGet.Rows.Count > aindex &&
                (dataGridViewGet.Rows[^1]?.Cells?[0]?.Value != null)) {
                if (dataGridViewGet.Rows[aindex].Cells[0].Value?.ToString() != e.PropertyName)
                    dataGridViewGet.Rows[aindex].Cells[0].Value = e.PropertyName;
                if (dataGridViewGet.Rows[aindex].Cells[1].Value?.ToString() != a[aindex].Value)
                    dataGridViewGet.Rows[aindex].Cells[1].Value = a[aindex].Value;
            } else {
                int trow = dataGridViewGet.Rows.Add(e.PropertyName, a[aindex].Value);
                dataGridViewGet.Rows[trow].Cells[0].ReadOnly = true;
            }
            propertychangednow = false;

        }

        private void button1_Click(object sender, EventArgs e) {
            var ipport = IPEndPoint.Parse(textBoxIP.Text + ":" + textBoxPort.Text);
            if (IPAddress.Any.Equals(ipport.Address))
                Sensor = new RSIFBSensor((uint)ipport.Port);
            else
                Sensor = new RSIFBSensor(ipport);
            Sensor.ShiftedProperties.Mode = (ShiftedValueMode)comboBoxSV.SelectedIndex;
            if (ShiftedTable != null)
                Sensor.ShiftedProperties.Table = ShiftedTable;
            timer1.Interval = int.Parse(textBoxParseInterval.Text);
            timer1.Enabled = true;
            if (checkBoxHistory.Checked) {
                SaveHistoryPath = $"History_{DateTime.Now:(dd.MM.yy_HH.mm.ss)}.txt";
            }
            //timer2.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
            panelConnect.Visible = false;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (ModifierKeys != Keys.None || e.KeyChar == (char)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (ModifierKeys != Keys.None || e.KeyChar == (char)Keys.Back) return;
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '.') || (e.KeyChar == '.' && textBoxIP.Text.Count(x => x == '.') > 2))
                e.Handled = true;

        }
        bool _timer2Ticked = false;
        private async void timer2_Tick(object sender, EventArgs e) {

            if (Sensor == null || _timer2Ticked)
                return;
            _timer2Ticked = true;
            try {
                await Sensor.ExchangeAsync();
            } catch (System.OperationCanceledException ex) {
                MessageBox.Show(ex.ToString());
            } catch (Exception) {
                throw;
            }
            _timer2Ticked = false;
        }
        private bool _file_save = false;
        private void timer1_Tick(object sender, EventArgs e) {

            if (Sensor?.LastData.Tags != null) {
                foreach (var tag in Sensor.LastData.Tags) {
                    dict[tag.Key] = tag.Value;
                }
                if (checkBoxHistory.Checked && SaveHistoryPath != null) {
                    Task.Run(() => {
                        if (_file_save) return;
                        _file_save = true;
                        File.AppendAllText(SaveHistoryPath, SerializeJson.Serialize(Sensor.LastData));
                        _file_save = false;
                    }
                    );
                }
            }
            toolStripLabelConnected.ForeColor = (Sensor?.Connected ?? false) ? Color.DarkGreen : Color.DarkRed;
            double? ping = Sensor?.GetDataElapsed.TotalMilliseconds;
            toolStripLabelPing.Text = Math.Round(ping ?? 0).ToString();
            if (panelSend.Visible)
                label5.Text = Sensor?.TagsSendingQueue.Length.ToString() ?? 0.ToString();

        }

        private void button3_Click(object sender, EventArgs e) {
            Random random = new Random();
            char Key = (char)('A' + random.Next(0, 26));
            char Value = (char)('a' + random.Next(0, 26));
            dict.Add(Key.ToString(), Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e) {
            MessageBox.Show("{" + string.Join(", ", dict.GetItems().Select(x => $"{x.Key}={x.Value}")) + "}");
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            //timer2.Enabled = false;

            Sensor?.CancelAsync();
            backgroundWorker1.CancelAsync();
            Sensor?.Dispose();
            Sensor = null;
            panelConnect.Visible = true;
            toolStripLabelConnected.ForeColor = Color.Gray;
        }

        private void button3_Click_1(object sender, EventArgs e) {
            panelDebug.Visible = !panelDebug.Visible;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            isEditingNew = true;
        }


        private void Control_MouseEnter(object? sender, EventArgs e) {
            if (sender is Control control) {
                toolStripStatusLabelHint.Text = string.IsNullOrWhiteSpace(control.AccessibleDescription) ? control.AccessibleDescription : control.Text ?? "";
                //toolTip1.SetToolTip(control, control.AccessibleDescription); // ”ÒÚ‡ÌÓ‚ËÚÂ ToolTip, ÂÒÎË ıÓÚËÚÂ
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            panelSend.Visible = true;
            panelPreSend.Visible = false;
            button7_Click(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            dataGridViewSend.Visible = radioButton2.Checked;
            textBoxSend.Visible = radioButton1.Checked;
        }

        private void button7_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                textBoxSend.Text = KUKA.RSI.DATA.StringXmlFormat(KUKA.RSI.DATA.ConvertDictToXmlDoc((Dictionary<string, string>)dict));
            } else {
                foreach (var item in dict.GetItems()) {
                    var finditem = dataGridViewSend.Rows.Cast<DataGridViewRow>().FirstOrDefault(x => x.Cells[0].Value?.ToString() == item.Key);
                    if (finditem != null)
                        finditem.Cells[1].Value = item.Value;
                    else
                        dataGridViewSend.Rows.Add(item.Key, item.Value);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            Dictionary<string, string> DataTable;

            if (radioButton1.Checked) {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(textBoxSend.Text);
                DataTable = KUKA.RSI.DATA.ConvertXmlToDict(doc);
            } else {
                DataTable = new Dictionary<string, string>();
                foreach (DataGridViewRow item in dataGridViewSend.Rows) {
                    string? key = item.Cells[0].Value?.ToString();
                    string? value = item.Cells[1].Value?.ToString();
                    if (key != null && value != null)
                        if (!DataTable.TryAdd(key, value))
                            DataTable[key] = value;
                }
            }
            Sensor?.SendTags(DataTable, checkBoxSendFeedBack.Checked);
            if (checkBoxSendHide.Checked) {
                panelPreSend.Visible = true;
                panelSend.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e) {

            var props = Sensor?.GetType().GetProperties();
            if (props == null) {
                MessageBox.Show("Sensor is NULL", "Info");
                return;
            }
            List<string> msgs = new List<string>();
            foreach (var prop in props) {
                if (!prop.CanRead)
                    continue;
                var value = prop.GetValue(Sensor);
                if (value is Array array) {
                    msgs.Add($"{prop.Name} : Array [ {string.Join(", ", array)} ]");
                } else if (value is IList list) {
                    msgs.Add($"{prop.Name} : List [ {string.Join(", ", list.Cast<object>())} ]");
                } else if (value is IDictionary dictionary) {
                    var dictItems = dictionary.Cast<DictionaryEntry>()
                                               .Select(entry => $"{entry.Key}={entry.Value}");
                    msgs.Add($"{prop.Name} : Dictionary [ {string.Join(", ", dictItems)} ]");
                } else {
                    msgs.Add($"{prop.Name} : {value}");
                }
            }
            MessageBox.Show("Copy to clipboard");
            Clipboard.SetText(string.Join(",\n", msgs));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

            var doc = XmlSettings.DocunentInit(SaveFilePath);
            ControlSettingsManager.SaveXML(this, doc, "Controls", "Control", SavingManagers.savemanager);
            ControlSettingsManager.SaveXML(this, doc, "Sizes", "Size", SavingManagers.savemanagersize);
            XmlSettings.Save(doc, "ShiftedTable", SerializeJson.Serialize(ShiftedTable));
            //size = null ÔÓÙËÍÒË
            doc.Save(SaveFilePath);


        }
        private void LoadStateControls(XmlDocument doc) {
            ControlSettingsManager.LoadXML(this, doc.OpenNode("//Controls"), SavingManagers.loadmanager);
            ControlSettingsManager.LoadXML(this, doc.OpenNode("//Sizes"), SavingManagers.loadmanagersize);
            Dictionary<string, int> d = SerializeJson.Deserialize<Dictionary<string, int>>(XmlSettings.Load(doc, "ShiftedTable"));
            if (d != null)
                ShiftedTable = d;
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            while (!(backgroundWorker1.CancellationPending || e.Cancel)) { // ÒÔÓÒË Ì‡ÔˇÏÛ˛
                try {
                    if (Sensor != null)
                        await Sensor.ExchangeAsync();
                    else
                        await Task.Delay(1);
                } catch (System.OperationCanceledException) {

                } catch (DifferenceSendAndGetDataException err) {
                    Debug.WriteLine(err.Message);
                } catch (Exception) {
                    throw;
                }
            }
            Debug.WriteLine("Cancel");
        }

        private void button10_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                var doc = KUKA.RSI.DATA.ParseXmlData(textBoxSend.Text);
                if (doc == null)
                    return;
                ShiftedTable = KUKA.RSI.DATA.ConvertXmlToDict(doc).ToDictionary(x => x.Key, y => int.TryParse(y.Value, out int z) ? z : 0);
            } else {
                ShiftedTable = new Dictionary<string, int>();
                foreach (DataGridViewRow row in dataGridViewSend.Rows) {
                    string? key = row.Cells?[0]?.Value?.ToString();
                    string? value = row.Cells?[1]?.Value?.ToString();
                    if (key != null && value != null && int.TryParse(value, out int res) && !ShiftedTable.TryAdd(key, res))
                        ShiftedTable[key] = res;
                }
            }
            if (Sensor != null)
                Sensor.ShiftedProperties.Table = ShiftedTable;
        }

        private void ÍÓÔËÓ‚‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e) {
            var tsmi = sender as ToolStripMenuItem;
            var cms = tsmi?.Owner as ContextMenuStrip;
            DataGridView? gv = cms?.SourceControl as DataGridView ?? sender as DataGridView;
            if (gv == null)
                return;
            var data = gv.SelectedCells.Cast<DataGridViewCell>().OrderBy(x => int.Parse(x.RowIndex.ToString("D4") + x.ColumnIndex.ToString("D4")))
                 .Select(x => (x.ColumnIndex == 0 ? "\r\n" : "") + (x.Value ?? "").ToString());
            Clipboard.SetText(string.Join("\t", data).Trim().Replace("\t\r\n", "\r\n"));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            var menu = sender as ContextMenuStrip;
            bool enablededit = menu?.SourceControl?.Name == dataGridViewSend.Name;

            ‚˚ÂÁ‡Ú¸ToolStripMenuItem.Enabled = enablededit;
            ‚ÒÚ‡‚ËÚ¸ToolStripMenuItem.Enabled = enablededit;
            Û‰‡ÎËÚ¸ToolStripMenuItem.Enabled = enablededit;

        }

        private void ‚˚ÂÁ‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e) {
            ÍÓÔËÓ‚‡Ú¸ToolStripMenuItem_Click(sender, e);
            Û‰‡ÎËÚ¸ToolStripMenuItem_Click(sender, e);

        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e) {
            var tsmi = sender as ToolStripMenuItem;
            var cms = tsmi?.Owner as ContextMenuStrip;
            DataGridView? gv = cms?.SourceControl as DataGridView ?? sender as DataGridView;
            if (gv == null)
                return;
            var data = gv.SelectedCells.Cast<DataGridViewCell>()
                .OrderBy(x => int.Parse(x.RowIndex.ToString("D4") + x.ColumnIndex.ToString("D4")));

            Dictionary<int, List<DataGridViewCell>> dict = new();
            foreach (var cell in data) {
                cell.Value = null;
                if (!dict.TryAdd(cell.RowIndex, new List<DataGridViewCell>() { cell })) {
                    dict[cell.RowIndex].Add(cell);
                }
            }

            List<int> deletedrows = dict.Where(x => x.Value.Count == gv.ColumnCount).Select(x => x.Key).OrderByDescending(x => x).ToList();
            for (int i = gv.AllowUserToAddRows ? 1 : 0; i < deletedrows.Count; i++) {
                    gv.Rows.RemoveAt(deletedrows[i]);
            }
        }

        private void ‚ÒÚ‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e) {
            var tsmi = sender as ToolStripMenuItem;
            var cms = tsmi?.Owner as ContextMenuStrip;
            DataGridView? gv = cms?.SourceControl as DataGridView ?? sender as DataGridView;
            if (gv == null)
                return;
            string str = Clipboard.GetText();
            string[] lines = str.Split(["\r\n"], StringSplitOptions.RemoveEmptyEntries);
            DataGridViewCell? item = gv.SelectedCells.Cast<DataGridViewCell>().MaxBy(x => x.RowIndex);
            int rowindex = item?.RowIndex + 1 ?? -1;
            foreach (string line in lines) {
                string[] sublines = line.Split('\t', StringSplitOptions.RemoveEmptyEntries);

                if (rowindex > -1 && rowindex < gv.Rows.Count - (gv.AllowUserToAddRows ? 1 : 0))
                    gv.Rows.Insert(++rowindex, sublines);
                else {
                    gv.Rows.Add(sublines);
                    rowindex = -1;
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e) {
            if (sender is not DataGridView gv)
                return;
            if (e.Control && e.KeyCode == Keys.V && gv.Name == "dataGridView2") {
                ‚ÒÚ‡‚ËÚ¸ToolStripMenuItem_Click(gv, e);
                e.Handled = true;
            }
            if (e.Control && e.KeyCode == Keys.X && gv.Name == "dataGridView2") {
                ‚˚ÂÁ‡Ú¸ToolStripMenuItem_Click(gv, e);
                e.Handled = true;
            }

            if(e.KeyCode == Keys.Delete && !isEditing && gv.SelectedRows.Count < 1 && gv.SelectedCells.Count > 0)
                foreach (DataGridViewCell item in gv.SelectedCells) 
                    item.Value = null;
            if (e.KeyCode == Keys.Back && !isEditing && gv.SelectedRows.Count < 1 && gv.SelectedCells.Count > 0) {
                DataGridViewCell firstitem = gv.SelectedCells[0];
                foreach (DataGridViewCell item in gv.SelectedCells) {
                    item.Value = null;
                    item.Selected = false;
                }
                firstitem.Selected = true;
                gv.BeginEdit(false);
                




            }



        }

        private void button11_Click(object sender, EventArgs e) {
            Sensor?.ClearSendingQueue();

        }

        private void buttonDebug4_Click(object sender, EventArgs e) {
            if (Sensor != null)
                MessageBox.Show(string.Join(";\n", Sensor.TagsSendingQueue.Select(x => x.Key + "=" + x.Value)));
        }

        private void ËÏÔÓÚToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Sensor != null)
                ShiftedTable = new Dictionary<string, int>(Sensor.ShiftedProperties.Table);
            if (ShiftedTable == null)
                return;
            if (radioButton1.Checked) {
                textBoxSend.Text = KUKA.RSI.DATA.StringXmlFormat(KUKA.RSI.DATA.ConvertDictToXmlDoc(ShiftedTable.ToDictionary(x => x.Key, y => y.Value.ToString())));
            } else {
                    dataGridViewSend.Rows.Clear();
                    foreach (var kvp in ShiftedTable) {
                        dataGridViewSend.Rows.Add(kvp.Key, kvp.Value);
                    
                }
            }

            
        }

        private void buttonExportInSVT_Click(object sender, EventArgs e) {
            contextMenuStrip2.Show(new Point(MousePosition.X + 0, MousePosition.Y + 0));
        }
    }
}