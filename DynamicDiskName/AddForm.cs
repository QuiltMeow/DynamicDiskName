using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DynamicDiskName
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            loadDiskList();
        }

        public void loadDiskList()
        {
            IList<string> disk = LabelChangeUtil.queryDiskList();
            foreach (KeyValuePair<string, LabelData> current in Program.config.setting)
            {
                disk.Remove(current.Value.name);
            }
            foreach (string data in disk)
            {
                cbDisk.Items.Add(data);
            }
            cbDisk.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("請輸入設定檔名稱", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string disk = cbDisk.SelectedItem.ToString();
            string label = LabelChangeUtil.queryDiskLabel(disk);
            if (label == null)
            {
                MessageBox.Show("目標磁碟機標籤查詢失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LabelData data = new LabelData(disk, 1, new List<string>() {
                label
            });
            Program.config.setting.Add(name, data);
            Program.config.saveSetting(Program.CONFIG_PATH);
            Program.form.reload();
            Close();
        }
    }
}