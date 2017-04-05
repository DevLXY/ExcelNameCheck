using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraEditors;
using System.IO;
using System.Text.RegularExpressions;


namespace ExcelNameCheck
{
    public partial class UserControl_NameCheck : UserControl
    {
        private Worksheet xlSh { get { return Globals.ThisAddIn.Application.ActiveSheet; } }
        private string[] fileNames;
        public UserControl_NameCheck()
        {
            InitializeComponent();
        }


        private void btn_SelectionRng_Click(object sender, EventArgs e)
        {
            tb_SelectionRng.Text = SelectConituousCoodinate();
        }

        private string SelectConituousCoodinate()
        {
            string str = "";
            Range xlRng = Globals.ThisAddIn.Application.Application.Selection;
            if (xlRng.Rows.Count == 1)
            {
                str = xlSh.Name + "!" + xlRng.Address;
            }
            else if (xlRng.Columns.Count == 1)
            {
                str = xlSh.Name + "!" + xlRng.Address;
            }
            else
            {
                XtraMessageBox.Show("选择区域必须为列或行", "提示");
            }
            return str;
        }

        private void btn_SelectFolderPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_SelectFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }


        private void CompareName()
        {
            Range rng_Names = Globals.ThisAddIn.Application.Range[tb_SelectionRng.Text];
            int colNum = rng_Names.Columns.Count;
            int rowNum = rng_Names.Rows.Count;
            if (rowNum == 1)
            {
                for (int i = 1; i <= colNum; i++)
                {
                    //Regex regex = new Regex(rng_Names.Cells[1, i].value.ToString().ToLower().Trim());//////////////Trim()
                    string s = String2Regex(HandleString(rng_Names.Cells[1, i].value.ToString()));
                    Regex regex = new Regex(String2Regex( HandleString(rng_Names.Cells[1, i].value.ToString())));
                    bool b = false;
                    for (int j = 0; j < fileNames.GetLength(0); j++)
                    {
                        if (regex.IsMatch(HandleString(fileNames[j])))
                        {
                            b = true;
                            if (cb_AddHyperlink.Checked)
                            {
                                xlSh.Hyperlinks.Add(rng_Names.Cells[1, i], fileNames[j]);
                            }
                            break;
                        }
                    }
                    if (!b)
                    {
                        rng_Names.Cells[1, i].Interior.Color = Color.FromArgb(204, 65, 37);

                    }
                }
            }
            else if (colNum == 1)
            {

                for (int i = 1; i <= rowNum; i++)
                {
                    //string test = String2Regex(HandleString(rng_Names.Cells[i, 1].value.ToString()));
                    Regex regex = new Regex(String2Regex( HandleString(rng_Names.Cells[i, 1].value.ToString())));
                    //Regex regex = new Regex(rng_Names.Cells[i, 1].value.ToString().ToLower().Trim());//////////////////////////////trim
                    bool b = false;
                    for (int j = 0; j < fileNames.GetLength(0); j++)
                    {
                        if (regex.IsMatch(HandleString(fileNames[j])))
                        {
                            b = true;
                            if (cb_AddHyperlink.Checked)
                            {
                                xlSh.Hyperlinks.Add(rng_Names.Cells[i, 1], fileNames[j]);
                            }

                        }
                    }
                    if (!b)
                    {
                        rng_Names.Cells[i, 1].Interior.Color = Color.FromArgb(204, 65, 37);
                    }
                }
            }
        }

        private void ReadFileNames()
        {
            fileNames = Directory.GetFiles(tb_SelectFolderPath.Text);
        }

        private string HandleString(string input)
        {
            string s = input;
            s = s.ToLower().Trim();
            Regex right = new Regex("）");
            Regex left = new Regex("（");
            s = left.Replace(s, "(");
            s = right.Replace(s, ")");
            return s;
        }
        private string String2Regex(string input)
        {
            string s = input;
            Regex right = new Regex(@"\)");
            Regex left = new Regex(@"\(");
            s = right.Replace(s, "\\)");
            s = left.Replace(s, "\\(");
            return s;
        }

        private void btn_BeginCompare_Click(object sender, EventArgs e)
        {
            ReadFileNames();
            CompareName();
            MessageBox.Show("操作完成。");
        }
    }
}
