using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DynamicDiskName
{
    public partial class MainForm : Form
    {
        private readonly Config config;

        public MainForm()
        {
            InitializeComponent();
            config = Program.config;
            try
            {
                config.loadSetting(Program.CONFIG_PATH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("設定檔案損毀 請檢查設定檔案格式是否正確 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reload();
        }

        private void enableControl(bool enable)
        {
            cbName.Enabled = numInterval.Enabled = txtAnimation.Enabled = btnRemove.Enabled = btnSave.Enabled = btnStart.Enabled = enable;
        }

        private void startControl(bool start)
        {
            btnAdd.Enabled = cbName.Enabled = numInterval.Enabled = txtAnimation.Enabled = btnRemove.Enabled = btnSave.Enabled = !start;
        }

        public void reload()
        {
            cbName.Items.Clear();
            txtDisk.Text = txtAnimation.Text = "";
            numInterval.Value = 1;
            if (config.setting.Count <= 0)
            {
                enableControl(false);
                return;
            }

            foreach (KeyValuePair<string, LabelData> data in config.setting)
            {
                cbName.Items.Add(data.Key);
            }
            cbName.SelectedIndex = 0;
            update(cbName.SelectedItem.ToString());
            enableControl(true);
        }

        private void update(string name)
        {
            LabelData current = config.setting[name];
            txtDisk.Text = current.name;
            numInterval.Value = current.interval;

            StringBuilder sb = new StringBuilder();
            foreach (string line in current.animation)
            {
                sb.AppendLine(line);
            }
            sb.Length -= Program.NEW_LINE.Length;
            txtAnimation.Text = sb.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            config.shutdown();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            config.setting.Remove(cbName.SelectedItem.ToString());
            Program.config.saveSetting(Program.CONFIG_PATH);
            reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddForm().Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = cbName.SelectedItem.ToString();
            string rawAnimation = txtAnimation.Text;

            IList<string> animation = new List<string>();
            string[] raw = rawAnimation.Split(new[] {
                Program.NEW_LINE
            }, StringSplitOptions.None);
            foreach (string line in raw)
            {
                animation.Add(line);
            }

            LabelData data = config.setting[name];
            data.interval = Convert.ToInt32(numInterval.Value);
            data.animation = animation;
            Program.config.saveSetting(Program.CONFIG_PATH);
            MessageBox.Show("設定檔案儲存完畢", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "開始")
            {
                update(cbName.SelectedItem.ToString());
                btnStart.Text = "停止";
                startControl(true);
                Program.config.startAnimation();
            }
            else
            {
                btnStart.Text = "開始";
                startControl(false);
                Program.config.shutdown();
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                niIcon.Visible = true;
                niIcon.ShowBalloonTip(3000);
            }
        }

        private void niIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showForm();
        }

        private void showForm()
        {
            Show();
            WindowState = FormWindowState.Normal;
            niIcon.Visible = false;
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            update(cbName.SelectedItem.ToString());
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            showForm();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}