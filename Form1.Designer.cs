namespace Kuka_Client_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            dataGridViewGet = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            panelConnect = new Panel();
            comboBoxSV = new ComboBox();
            buttonDebug = new Button();
            textBoxParseInterval = new TextBox();
            checkBoxHistory = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            buttonSettings = new Button();
            label2 = new Label();
            buttonRunClient = new Button();
            textBoxIP = new TextBox();
            textBoxPort = new TextBox();
            label1 = new Label();
            splitter1 = new Splitter();
            toolStrip1 = new ToolStrip();
            toolStripLabelPing = new ToolStripLabel();
            toolStripButtonStop = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabelConnected = new ToolStripLabel();
            toolStripButtonDebug = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panelDebug = new Panel();
            buttonDebug4 = new Button();
            buttonDebug3 = new Button();
            buttonDebug2 = new Button();
            buttonDebug1 = new Button();
            panelPreSend = new Panel();
            buttonPreSend = new Button();
            panelSend = new Panel();
            dataGridViewSend = new DataGridView();
            textBoxSend = new TextBox();
            panelSendProperties = new Panel();
            buttonImportGetTable = new Button();
            label5 = new Label();
            buttonClearFB = new Button();
            buttonExportInSVT = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            импортToolStripMenuItem = new ToolStripMenuItem();
            экспортToolStripMenuItem = new ToolStripMenuItem();
            checkBoxSendHide = new CheckBox();
            checkBoxSendFeedBack = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            buttonSend = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelHint = new ToolStripStatusLabel();
            toolTip1 = new ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitter2 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGet).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panelConnect.SuspendLayout();
            toolStrip1.SuspendLayout();
            panelDebug.SuspendLayout();
            panelPreSend.SuspendLayout();
            panelSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSend).BeginInit();
            panelSendProperties.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewGet
            // 
            dataGridViewGet.AllowUserToAddRows = false;
            dataGridViewGet.AllowUserToDeleteRows = false;
            dataGridViewGet.BackgroundColor = Color.White;
            dataGridViewGet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGet.ContextMenuStrip = contextMenuStrip1;
            dataGridViewGet.Dock = DockStyle.Fill;
            dataGridViewGet.Location = new Point(257, 258);
            dataGridViewGet.Name = "dataGridViewGet";
            dataGridViewGet.RowHeadersVisible = false;
            dataGridViewGet.Size = new Size(262, 241);
            dataGridViewGet.TabIndex = 1;
            dataGridViewGet.CellBeginEdit += DataGridView1_CellBeginEdit;
            dataGridViewGet.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridViewGet.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridViewGet.RowsAdded += dataGridView1_RowsAdded;
            dataGridViewGet.KeyDown += dataGridView_KeyDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 92);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            вырезатьToolStripMenuItem.Size = new Size(181, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            копироватьToolStripMenuItem.Size = new Size(181, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            вставитьToolStripMenuItem.Size = new Size(181, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            удалитьToolStripMenuItem.Size = new Size(181, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // panelConnect
            // 
            panelConnect.Controls.Add(comboBoxSV);
            panelConnect.Controls.Add(buttonDebug);
            panelConnect.Controls.Add(textBoxParseInterval);
            panelConnect.Controls.Add(checkBoxHistory);
            panelConnect.Controls.Add(label4);
            panelConnect.Controls.Add(label3);
            panelConnect.Controls.Add(buttonSettings);
            panelConnect.Controls.Add(label2);
            panelConnect.Controls.Add(buttonRunClient);
            panelConnect.Controls.Add(textBoxIP);
            panelConnect.Controls.Add(textBoxPort);
            panelConnect.Controls.Add(label1);
            panelConnect.Dock = DockStyle.Top;
            panelConnect.Location = new Point(0, 25);
            panelConnect.Name = "panelConnect";
            panelConnect.Padding = new Padding(6);
            panelConnect.Size = new Size(655, 230);
            panelConnect.TabIndex = 0;
            // 
            // comboBoxSV
            // 
            comboBoxSV.Anchor = AnchorStyles.Top;
            comboBoxSV.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSV.FormattingEnabled = true;
            comboBoxSV.Location = new Point(237, 166);
            comboBoxSV.Name = "comboBoxSV";
            comboBoxSV.Size = new Size(172, 23);
            comboBoxSV.TabIndex = 7;
            // 
            // buttonDebug
            // 
            buttonDebug.Anchor = AnchorStyles.Top;
            buttonDebug.Location = new Point(237, 53);
            buttonDebug.Name = "buttonDebug";
            buttonDebug.Size = new Size(75, 23);
            buttonDebug.TabIndex = 6;
            buttonDebug.Text = "Отладка";
            buttonDebug.UseVisualStyleBackColor = true;
            buttonDebug.Click += button3_Click_1;
            // 
            // textBoxParseInterval
            // 
            textBoxParseInterval.Anchor = AnchorStyles.Top;
            textBoxParseInterval.Location = new Point(237, 97);
            textBoxParseInterval.Name = "textBoxParseInterval";
            textBoxParseInterval.Size = new Size(123, 23);
            textBoxParseInterval.TabIndex = 3;
            textBoxParseInterval.Text = "100";
            // 
            // checkBoxHistory
            // 
            checkBoxHistory.Anchor = AnchorStyles.Top;
            checkBoxHistory.AutoSize = true;
            checkBoxHistory.Location = new Point(237, 126);
            checkBoxHistory.Name = "checkBoxHistory";
            checkBoxHistory.Size = new Size(73, 19);
            checkBoxHistory.TabIndex = 4;
            checkBoxHistory.Text = "История";
            checkBoxHistory.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Location = new Point(237, 148);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 3;
            label4.Text = "Режим смещения значений:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Location = new Point(237, 79);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 3;
            label3.Text = "Интервал вывода данных:";
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Top;
            buttonSettings.Location = new Point(313, 53);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(96, 23);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "Расширенные настройки";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Location = new Point(237, 6);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 3;
            label2.Text = "IP и порт для приема пакетов:";
            // 
            // buttonRunClient
            // 
            buttonRunClient.Dock = DockStyle.Bottom;
            buttonRunClient.Location = new Point(6, 199);
            buttonRunClient.Name = "buttonRunClient";
            buttonRunClient.Size = new Size(643, 25);
            buttonRunClient.TabIndex = 5;
            buttonRunClient.Text = "Запустить клиент";
            buttonRunClient.UseVisualStyleBackColor = true;
            buttonRunClient.Click += button1_Click;
            // 
            // textBoxIP
            // 
            textBoxIP.Anchor = AnchorStyles.Top;
            textBoxIP.Location = new Point(237, 24);
            textBoxIP.MaxLength = 15;
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(123, 23);
            textBoxIP.TabIndex = 0;
            textBoxIP.Text = "0.0.0.0";
            textBoxIP.TextAlign = HorizontalAlignment.Right;
            textBoxIP.KeyPress += textBox1_KeyPress;
            // 
            // textBoxPort
            // 
            textBoxPort.Anchor = AnchorStyles.Top;
            textBoxPort.Location = new Point(366, 24);
            textBoxPort.MaxLength = 5;
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(43, 23);
            textBoxPort.TabIndex = 1;
            textBoxPort.Text = "49150";
            textBoxPort.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Location = new Point(359, 27);
            label1.Name = "label1";
            label1.Size = new Size(10, 23);
            label1.TabIndex = 2;
            label1.Text = ":";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 255);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(655, 3);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelPing, toolStripButtonStop, toolStripLabel1, toolStripLabelConnected, toolStripButtonDebug });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(655, 25);
            toolStrip1.TabIndex = 3;
            // 
            // toolStripLabelPing
            // 
            toolStripLabelPing.Alignment = ToolStripItemAlignment.Right;
            toolStripLabelPing.Name = "toolStripLabelPing";
            toolStripLabelPing.Size = new Size(13, 22);
            toolStripLabelPing.Text = "0";
            // 
            // toolStripButtonStop
            // 
            toolStripButtonStop.Image = Properties.Resources.network_close;
            toolStripButtonStop.ImageTransparentColor = Color.Magenta;
            toolStripButtonStop.Name = "toolStripButtonStop";
            toolStripButtonStop.Size = new Size(132, 22);
            toolStripButtonStop.Text = "Остановить клиент";
            toolStripButtonStop.Click += toolStripButton1_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(58, 22);
            toolStripLabel1.Text = "задержка";
            toolStripLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripLabelConnected
            // 
            toolStripLabelConnected.Alignment = ToolStripItemAlignment.Right;
            toolStripLabelConnected.ForeColor = Color.Gray;
            toolStripLabelConnected.Name = "toolStripLabelConnected";
            toolStripLabelConnected.Size = new Size(19, 22);
            toolStripLabelConnected.Text = "⚫";
            // 
            // toolStripButtonDebug
            // 
            toolStripButtonDebug.Image = Properties.Resources.tool;
            toolStripButtonDebug.ImageTransparentColor = Color.Magenta;
            toolStripButtonDebug.Name = "toolStripButtonDebug";
            toolStripButtonDebug.Size = new Size(72, 22);
            toolStripButtonDebug.Text = "Отладка";
            toolStripButtonDebug.Click += button3_Click_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // panelDebug
            // 
            panelDebug.Controls.Add(buttonDebug4);
            panelDebug.Controls.Add(buttonDebug3);
            panelDebug.Controls.Add(buttonDebug2);
            panelDebug.Controls.Add(buttonDebug1);
            panelDebug.Dock = DockStyle.Right;
            panelDebug.Location = new Point(519, 258);
            panelDebug.Name = "panelDebug";
            panelDebug.Size = new Size(136, 266);
            panelDebug.TabIndex = 4;
            panelDebug.Visible = false;
            // 
            // buttonDebug4
            // 
            buttonDebug4.Dock = DockStyle.Top;
            buttonDebug4.Location = new Point(0, 69);
            buttonDebug4.Name = "buttonDebug4";
            buttonDebug4.Size = new Size(136, 23);
            buttonDebug4.TabIndex = 3;
            buttonDebug4.Text = "Вывести очередь отправки";
            buttonDebug4.UseVisualStyleBackColor = true;
            buttonDebug4.Click += buttonDebug4_Click;
            // 
            // buttonDebug3
            // 
            buttonDebug3.Dock = DockStyle.Top;
            buttonDebug3.Location = new Point(0, 46);
            buttonDebug3.Name = "buttonDebug3";
            buttonDebug3.Size = new Size(136, 23);
            buttonDebug3.TabIndex = 2;
            buttonDebug3.Text = "Вывести статус сенсора";
            buttonDebug3.UseVisualStyleBackColor = true;
            buttonDebug3.Click += button9_Click;
            // 
            // buttonDebug2
            // 
            buttonDebug2.Dock = DockStyle.Top;
            buttonDebug2.Location = new Point(0, 23);
            buttonDebug2.Name = "buttonDebug2";
            buttonDebug2.Size = new Size(136, 23);
            buttonDebug2.TabIndex = 1;
            buttonDebug2.Text = "Прочитать извне";
            buttonDebug2.UseVisualStyleBackColor = true;
            buttonDebug2.Click += button4_Click;
            // 
            // buttonDebug1
            // 
            buttonDebug1.AccessibleDescription = "Добавить в таблицу извне";
            buttonDebug1.Dock = DockStyle.Top;
            buttonDebug1.Location = new Point(0, 0);
            buttonDebug1.Name = "buttonDebug1";
            buttonDebug1.Size = new Size(136, 23);
            buttonDebug1.TabIndex = 0;
            buttonDebug1.Text = "Добавить в таблицу извне";
            buttonDebug1.UseVisualStyleBackColor = true;
            buttonDebug1.Click += button3_Click;
            // 
            // panelPreSend
            // 
            panelPreSend.Controls.Add(buttonPreSend);
            panelPreSend.Dock = DockStyle.Bottom;
            panelPreSend.Location = new Point(257, 499);
            panelPreSend.Name = "panelPreSend";
            panelPreSend.Size = new Size(262, 25);
            panelPreSend.TabIndex = 5;
            // 
            // buttonPreSend
            // 
            buttonPreSend.Dock = DockStyle.Right;
            buttonPreSend.Location = new Point(109, 0);
            buttonPreSend.Name = "buttonPreSend";
            buttonPreSend.Size = new Size(153, 25);
            buttonPreSend.TabIndex = 0;
            buttonPreSend.Text = "Отправить другие Теги";
            buttonPreSend.UseVisualStyleBackColor = true;
            buttonPreSend.Click += button6_Click;
            // 
            // panelSend
            // 
            panelSend.Controls.Add(dataGridViewSend);
            panelSend.Controls.Add(textBoxSend);
            panelSend.Controls.Add(panelSendProperties);
            panelSend.Controls.Add(buttonSend);
            panelSend.Dock = DockStyle.Left;
            panelSend.Location = new Point(0, 258);
            panelSend.MinimumSize = new Size(254, 0);
            panelSend.Name = "panelSend";
            panelSend.Padding = new Padding(0, 6, 0, 0);
            panelSend.Size = new Size(254, 266);
            panelSend.TabIndex = 6;
            panelSend.Visible = false;
            // 
            // dataGridViewSend
            // 
            dataGridViewSend.AllowUserToOrderColumns = true;
            dataGridViewSend.BackgroundColor = Color.White;
            dataGridViewSend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSend.ContextMenuStrip = contextMenuStrip1;
            dataGridViewSend.Dock = DockStyle.Fill;
            dataGridViewSend.Location = new Point(0, 97);
            dataGridViewSend.Name = "dataGridViewSend";
            dataGridViewSend.Size = new Size(254, 139);
            dataGridViewSend.TabIndex = 3;
            dataGridViewSend.KeyDown += dataGridView_KeyDown;
            // 
            // textBoxSend
            // 
            textBoxSend.AcceptsReturn = true;
            textBoxSend.Dock = DockStyle.Fill;
            textBoxSend.Location = new Point(0, 97);
            textBoxSend.Multiline = true;
            textBoxSend.Name = "textBoxSend";
            textBoxSend.Size = new Size(254, 139);
            textBoxSend.TabIndex = 2;
            textBoxSend.Visible = false;
            // 
            // panelSendProperties
            // 
            panelSendProperties.Controls.Add(buttonImportGetTable);
            panelSendProperties.Controls.Add(label5);
            panelSendProperties.Controls.Add(buttonClearFB);
            panelSendProperties.Controls.Add(buttonExportInSVT);
            panelSendProperties.Controls.Add(checkBoxSendHide);
            panelSendProperties.Controls.Add(checkBoxSendFeedBack);
            panelSendProperties.Controls.Add(radioButton1);
            panelSendProperties.Controls.Add(radioButton2);
            panelSendProperties.Dock = DockStyle.Top;
            panelSendProperties.Location = new Point(0, 6);
            panelSendProperties.Name = "panelSendProperties";
            panelSendProperties.Size = new Size(254, 91);
            panelSendProperties.TabIndex = 1;
            // 
            // buttonImportGetTable
            // 
            buttonImportGetTable.AccessibleDescription = "Импортировать полученную таблицу";
            buttonImportGetTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonImportGetTable.Location = new Point(171, 4);
            buttonImportGetTable.Name = "buttonImportGetTable";
            buttonImportGetTable.Size = new Size(75, 23);
            buttonImportGetTable.TabIndex = 5;
            buttonImportGetTable.Text = "Импорт";
            buttonImportGetTable.UseVisualStyleBackColor = true;
            buttonImportGetTable.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 57);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 4;
            label5.Text = "0";
            // 
            // buttonClearFB
            // 
            buttonClearFB.AccessibleDescription = "Очистить очередь тегов с обратной связью";
            buttonClearFB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClearFB.Location = new Point(125, 53);
            buttonClearFB.Name = "buttonClearFB";
            buttonClearFB.Size = new Size(121, 23);
            buttonClearFB.TabIndex = 3;
            buttonClearFB.Text = "Очистить очередь";
            buttonClearFB.UseVisualStyleBackColor = true;
            buttonClearFB.Click += button11_Click;
            // 
            // buttonExportInSVT
            // 
            buttonExportInSVT.AccessibleDescription = "Импортировать полученную таблицу";
            buttonExportInSVT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportInSVT.ContextMenuStrip = contextMenuStrip2;
            buttonExportInSVT.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExportInSVT.Location = new Point(125, 28);
            buttonExportInSVT.Name = "buttonExportInSVT";
            buttonExportInSVT.Size = new Size(121, 23);
            buttonExportInSVT.TabIndex = 1;
            buttonExportInSVT.Text = "Таблица смещений";
            buttonExportInSVT.UseVisualStyleBackColor = true;
            buttonExportInSVT.Click += buttonExportInSVT_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { импортToolStripMenuItem, экспортToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(182, 48);
            // 
            // импортToolStripMenuItem
            // 
            импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            импортToolStripMenuItem.Size = new Size(181, 22);
            импортToolStripMenuItem.Text = "Импорт из сенсора";
            импортToolStripMenuItem.Click += импортToolStripMenuItem_Click;
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size = new Size(181, 22);
            экспортToolStripMenuItem.Text = "Экспорт в сенсор";
            экспортToolStripMenuItem.Click += button10_Click;
            // 
            // checkBoxSendHide
            // 
            checkBoxSendHide.AutoSize = true;
            checkBoxSendHide.Checked = true;
            checkBoxSendHide.CheckState = CheckState.Checked;
            checkBoxSendHide.Location = new Point(12, 31);
            checkBoxSendHide.Name = "checkBoxSendHide";
            checkBoxSendHide.Size = new Size(51, 19);
            checkBoxSendHide.TabIndex = 2;
            checkBoxSendHide.Text = "Hide";
            checkBoxSendHide.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendFeedBack
            // 
            checkBoxSendFeedBack.AutoSize = true;
            checkBoxSendFeedBack.Location = new Point(12, 56);
            checkBoxSendFeedBack.Name = "checkBoxSendFeedBack";
            checkBoxSendFeedBack.Size = new Size(76, 19);
            checkBoxSendFeedBack.TabIndex = 2;
            checkBoxSendFeedBack.Text = "FeedBack";
            checkBoxSendFeedBack.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 6);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "XML Doc";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(82, 6);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Value Table";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // buttonSend
            // 
            buttonSend.Dock = DockStyle.Bottom;
            buttonSend.Location = new Point(0, 236);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(254, 30);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "Отправить на робот";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += button8_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelHint });
            statusStrip1.Location = new Point(0, 524);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(655, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHint
            // 
            toolStripStatusLabelHint.Name = "toolStripStatusLabelHint";
            toolStripStatusLabelHint.Size = new Size(16, 17);
            toolStripStatusLabelHint.Text = "...";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(254, 258);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 266);
            splitter2.TabIndex = 9;
            splitter2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 546);
            Controls.Add(dataGridViewGet);
            Controls.Add(panelPreSend);
            Controls.Add(panelDebug);
            Controls.Add(splitter2);
            Controls.Add(panelSend);
            Controls.Add(statusStrip1);
            Controls.Add(splitter1);
            Controls.Add(panelConnect);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "RSI Client";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGet).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panelConnect.ResumeLayout(false);
            panelConnect.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelDebug.ResumeLayout(false);
            panelPreSend.ResumeLayout(false);
            panelSend.ResumeLayout(false);
            panelSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSend).EndInit();
            panelSendProperties.ResumeLayout(false);
            panelSendProperties.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewGet;
        private Panel panelConnect;
        private TextBox textBoxIP;
        private Button buttonRunClient;
        private Splitter splitter1;
        private Label label2;
        private TextBox textBoxPort;
        private Label label1;
        private Button buttonSettings;
        private CheckBox checkBoxHistory;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabelPing;
        private ToolStripButton toolStripButtonStop;
        private TextBox textBoxParseInterval;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button buttonDebug;
        private Panel panelDebug;
        private Button buttonDebug2;
        private Button buttonDebug1;
        private ToolStripLabel toolStripLabelConnected;
        private ToolStripLabel toolStripLabel1;
        private Panel panelPreSend;
        private Button buttonPreSend;
        private Panel panelSend;
        private Panel panelSendProperties;
        private CheckBox checkBoxSendFeedBack;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelHint;
        private ToolTip toolTip1;
        private DataGridView dataGridViewSend;
        private TextBox textBoxSend;
        private CheckBox checkBoxSendHide;
        private Button buttonDebug3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonExportInSVT;
        private Button buttonSend;
        private ToolStripButton toolStripButtonDebug;
        private Splitter splitter2;
        private ComboBox comboBoxSV;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Button buttonImportGetTable;
        private Label label5;
        private Button buttonClearFB;
        private Button buttonDebug4;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem импортToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
    }
}
