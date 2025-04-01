namespace Kuka_Client_2 {
    public static class Tips {

        public static event EventHandler? Control_MouseEnter;
        public static void AddMouseEnterTips(IEnumerable<Control> controls, bool isContainerTips = false) {
            foreach (Control item in controls)
                AddMouseEnterTips(item, isContainerTips);
        }
        public static void AddMouseEnterTips(Control.ControlCollection controls, bool isContainerTips = false) => AddMouseEnterTips(controls.Cast<Control>(), isContainerTips);

        public static void AddMouseEnterTips(Control item, bool isContainerTips = false) {
            if (item.Controls.Count > 0)
                AddMouseEnterTips(item.Controls, isContainerTips);
            if (item.Controls.Count > 0 && !isContainerTips)
                return;
            item.MouseEnter += Control_MouseEnter;
        }
    }
}