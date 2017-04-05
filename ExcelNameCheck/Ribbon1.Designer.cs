namespace ExcelNameCheck
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab_NameCheck = this.Factory.CreateRibbonTab();
            this.Group_NameCheck = this.Factory.CreateRibbonGroup();
            this.btn_NameCheck = this.Factory.CreateRibbonToggleButton();
            this.tab_NameCheck.SuspendLayout();
            this.Group_NameCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_NameCheck
            // 
            this.tab_NameCheck.Groups.Add(this.Group_NameCheck);
            this.tab_NameCheck.Label = "签到检查";
            this.tab_NameCheck.Name = "tab_NameCheck";
            // 
            // Group_NameCheck
            // 
            this.Group_NameCheck.Items.Add(this.btn_NameCheck);
            this.Group_NameCheck.Label = "Magic";
            this.Group_NameCheck.Name = "Group_NameCheck";
            // 
            // btn_NameCheck
            // 
            this.btn_NameCheck.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_NameCheck.Image = global::ExcelNameCheck.Properties.Resources.ok_xxl;
            this.btn_NameCheck.Label = "签到";
            this.btn_NameCheck.Name = "btn_NameCheck";
            this.btn_NameCheck.ShowImage = true;
            this.btn_NameCheck.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_NameCheck_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab_NameCheck);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab_NameCheck.ResumeLayout(false);
            this.tab_NameCheck.PerformLayout();
            this.Group_NameCheck.ResumeLayout(false);
            this.Group_NameCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab_NameCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Group_NameCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton btn_NameCheck;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
