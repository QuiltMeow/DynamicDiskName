namespace DynamicDiskName
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.labelAnimation = new System.Windows.Forms.Label();
            this.txtAnimation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.labelDisk = new System.Windows.Forms.Label();
            this.txtDisk = new System.Windows.Forms.TextBox();
            this.niIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelSecond = new System.Windows.Forms.Label();
            this.cmsMin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.cmsMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(105, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "動態磁碟標籤";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.Enabled = false;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(85, 75);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(181, 20);
            this.cbName.TabIndex = 3;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "名稱";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(14, 131);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(29, 12);
            this.labelInterval.TabIndex = 6;
            this.labelInterval.Text = "間隔";
            // 
            // numInterval
            // 
            this.numInterval.Enabled = false;
            this.numInterval.Location = new System.Drawing.Point(85, 129);
            this.numInterval.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(158, 22);
            this.numInterval.TabIndex = 7;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAnimation
            // 
            this.labelAnimation.AutoSize = true;
            this.labelAnimation.Location = new System.Drawing.Point(14, 175);
            this.labelAnimation.Name = "labelAnimation";
            this.labelAnimation.Size = new System.Drawing.Size(112, 12);
            this.labelAnimation.TabIndex = 9;
            this.labelAnimation.Text = "動態文字 (一行一個)";
            // 
            // txtAnimation
            // 
            this.txtAnimation.Enabled = false;
            this.txtAnimation.Location = new System.Drawing.Point(16, 195);
            this.txtAnimation.Multiline = true;
            this.txtAnimation.Name = "txtAnimation";
            this.txtAnimation.Size = new System.Drawing.Size(250, 192);
            this.txtAnimation.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(16, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "儲存本設定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(16, 463);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(250, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(16, 405);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(250, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "刪除本設定";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labelDisk
            // 
            this.labelDisk.AutoSize = true;
            this.labelDisk.Location = new System.Drawing.Point(14, 104);
            this.labelDisk.Name = "labelDisk";
            this.labelDisk.Size = new System.Drawing.Size(65, 12);
            this.labelDisk.TabIndex = 4;
            this.labelDisk.Text = "磁碟機代號";
            // 
            // txtDisk
            // 
            this.txtDisk.Location = new System.Drawing.Point(85, 101);
            this.txtDisk.Name = "txtDisk";
            this.txtDisk.ReadOnly = true;
            this.txtDisk.Size = new System.Drawing.Size(181, 22);
            this.txtDisk.TabIndex = 5;
            // 
            // niIcon
            // 
            this.niIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niIcon.BalloonTipText = "程式仍在執行中";
            this.niIcon.BalloonTipTitle = "動態磁碟標籤";
            this.niIcon.ContextMenuStrip = this.cmsMin;
            this.niIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcon.Icon")));
            this.niIcon.Tag = "";
            this.niIcon.Text = "動態磁碟標籤";
            this.niIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niIcon_MouseDoubleClick);
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(249, 131);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(17, 12);
            this.labelSecond.TabIndex = 8;
            this.labelSecond.Text = "秒";
            // 
            // cmsMin
            // 
            this.cmsMin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiExit});
            this.cmsMin.Name = "cmsMin";
            this.cmsMin.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(180, 22);
            this.tsmiShow.Text = "顯示";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "離開";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 501);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.txtDisk);
            this.Controls.Add(this.labelDisk);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAnimation);
            this.Controls.Add(this.labelAnimation);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "動態磁碟標籤";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.cmsMin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label labelAnimation;
        private System.Windows.Forms.TextBox txtAnimation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label labelDisk;
        private System.Windows.Forms.TextBox txtDisk;
        private System.Windows.Forms.NotifyIcon niIcon;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.ContextMenuStrip cmsMin;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

