using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Core;

namespace ExcelNameCheck
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        internal Microsoft.Office.Tools.CustomTaskPane TaskPane_NameCheck;

        private void btn_NameCheck_Click(object sender, RibbonControlEventArgs e)
        {
            if (btn_NameCheck.Checked)
            {
                if (TaskPane_NameCheck==null)
                {
                    TaskPane_NameCheck = Globals.ThisAddIn.CustomTaskPanes.Add(new UserControl_NameCheck(), "签到");
                    TaskPane_NameCheck.DockPosition = MsoCTPDockPosition.msoCTPDockPositionLeft;
                    TaskPane_NameCheck.Visible = true;
                }
                else
                {
                    TaskPane_NameCheck.Visible = true;
                }

            }
            else
            {
                TaskPane_NameCheck.Visible = false;
            }
        }

    }
}
