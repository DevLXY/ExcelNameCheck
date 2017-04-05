namespace ExcelNameCheck
{
    partial class UserControl_NameCheck
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_SelectionRng = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_SelectionRng = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_SelectFolderPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_SelectFolderPath = new System.Windows.Forms.Button();
            this.btn_BeginCompare = new System.Windows.Forms.Button();
            this.cb_AddHyperlink = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_SelectionRng
            // 
            this.tb_SelectionRng.Location = new System.Drawing.Point(12, 95);
            this.tb_SelectionRng.Name = "tb_SelectionRng";
            this.tb_SelectionRng.Size = new System.Drawing.Size(174, 21);
            this.tb_SelectionRng.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_SelectionRng
            // 
            this.btn_SelectionRng.Location = new System.Drawing.Point(12, 133);
            this.btn_SelectionRng.Name = "btn_SelectionRng";
            this.btn_SelectionRng.Size = new System.Drawing.Size(174, 23);
            this.btn_SelectionRng.TabIndex = 1;
            this.btn_SelectionRng.Text = "选择姓名区域";
            this.btn_SelectionRng.UseVisualStyleBackColor = true;
            this.btn_SelectionRng.Click += new System.EventHandler(this.btn_SelectionRng_Click);
            // 
            // tb_SelectFolderPath
            // 
            this.tb_SelectFolderPath.Location = new System.Drawing.Point(12, 199);
            this.tb_SelectFolderPath.Name = "tb_SelectFolderPath";
            this.tb_SelectFolderPath.Size = new System.Drawing.Size(174, 21);
            this.tb_SelectFolderPath.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_SelectFolderPath
            // 
            this.btn_SelectFolderPath.Location = new System.Drawing.Point(12, 239);
            this.btn_SelectFolderPath.Name = "btn_SelectFolderPath";
            this.btn_SelectFolderPath.Size = new System.Drawing.Size(174, 23);
            this.btn_SelectFolderPath.TabIndex = 6;
            this.btn_SelectFolderPath.Text = "选择文件路径";
            this.btn_SelectFolderPath.UseVisualStyleBackColor = true;
            this.btn_SelectFolderPath.Click += new System.EventHandler(this.btn_SelectFolderPath_Click);
            // 
            // btn_BeginCompare
            // 
            this.btn_BeginCompare.Location = new System.Drawing.Point(12, 332);
            this.btn_BeginCompare.Name = "btn_BeginCompare";
            this.btn_BeginCompare.Size = new System.Drawing.Size(174, 23);
            this.btn_BeginCompare.TabIndex = 7;
            this.btn_BeginCompare.Text = "开始比较";
            this.btn_BeginCompare.UseVisualStyleBackColor = true;
            this.btn_BeginCompare.Click += new System.EventHandler(this.btn_BeginCompare_Click);
            // 
            // cb_AddHyperlink
            // 
            this.cb_AddHyperlink.AutoSize = true;
            this.cb_AddHyperlink.Location = new System.Drawing.Point(54, 288);
            this.cb_AddHyperlink.Name = "cb_AddHyperlink";
            this.cb_AddHyperlink.Size = new System.Drawing.Size(132, 16);
            this.cb_AddHyperlink.TabIndex = 8;
            this.cb_AddHyperlink.Text = "是否添加文件超链接";
            this.cb_AddHyperlink.UseVisualStyleBackColor = true;
            // 
            // UserControl_NameCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.cb_AddHyperlink);
            this.Controls.Add(this.btn_BeginCompare);
            this.Controls.Add(this.btn_SelectFolderPath);
            this.Controls.Add(this.tb_SelectFolderPath);
            this.Controls.Add(this.btn_SelectionRng);
            this.Controls.Add(this.tb_SelectionRng);
            this.Name = "UserControl_NameCheck";
            this.Size = new System.Drawing.Size(245, 547);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SelectionRng;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_SelectionRng;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tb_SelectFolderPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btn_SelectFolderPath;
        private System.Windows.Forms.Button btn_BeginCompare;
        private System.Windows.Forms.CheckBox cb_AddHyperlink;
    }
}
