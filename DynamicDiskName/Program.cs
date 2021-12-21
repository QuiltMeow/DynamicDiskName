using SkinSharp;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DynamicDiskName
{
    public static class Program
    {
        public const string CONFIG_PATH = "./config.yml";
        public static readonly string NEW_LINE = Environment.NewLine;

        public static Config config
        {
            get;
            private set;
        }

        public static MainForm form
        {
            get;
            private set;
        }

        private static SkinH_Net skin;

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                skin = new SkinH_Net();
                skin.AttachEx("Skin.she", "");
            }
            catch
            {
            }

            string name = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcessesByName(name).Length > 1)
            {
                MessageBox.Show("已經有其他程式實例正在執行", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            config = new Config();
            form = new MainForm();
            Application.Run(form);
        }
    }
}