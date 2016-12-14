using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Paste_Click(object sender, EventArgs e)
        {
            string @var = VarCol.Text;
            switch (@var)
            {
                case "2":
                    if (Map.Rows[0].Cells[0].Value.ToString() == "1")
                    {
                        Random ran = new Random();
                        int r, g, b;
                        r = ran.Next(256);
                        g = ran.Next(256);
                        b = ran.Next(256);
                        Map.Rows[0].Cells[0].Style.BackColor = Color.FromArgb(r, g, b);
                    }
                    if (Map.Rows[0].Cells[1].Value.ToString() == "1")
                    {
                        Random ran = new Random();
                        int r, g, b;
                        r = ran.Next(256);
                        g = ran.Next(256);
                        b = ran.Next(256);
                        Map.Rows[0].Cells[1].Style.BackColor = Color.FromArgb(r, g, b);
                    }
                    if (Map.Rows[1].Cells[0].Value.ToString() == "1")
                    {
                        Random ran = new Random();
                        int r, g, b;
                        r = ran.Next(256);
                        g = ran.Next(256);
                        b = ran.Next(256);
                        Map.Rows[1].Cells[0].Style.BackColor = Color.FromArgb(r, g, b);
                    }
                    if (Map.Rows[1].Cells[1].Value.ToString() == "1")
                    {
                        Random ran = new Random();
                        int r, g, b;
                        r = ran.Next(256);
                        g = ran.Next(256);
                        b = ran.Next(256);
                        Map.Rows[1].Cells[1].Style.BackColor = Color.FromArgb(r, g, b);
                    }
                    ; break;
            }
        }

        private void Build_Click(object sender, EventArgs e)
        {
            string @var = VarCol.Text;
            switch (@var)
            {
                case "2":
                    Map.Rows.Clear();
                    VarF.Text = "X1";
                    VarS.Text = "X2";
                    while (Map.Columns.Count != 0)
                    {
                        Map.Columns.RemoveAt(0);
                    }
                    Map.Columns.Add("Col1", "0");
                    Map.Columns.Add("Col2", "1");
                    Map.Columns[0].Width = 50;
                    Map.Columns[1].Width = 50;
                    Map.Rows.Add(2);
                    Map.Rows[0].HeaderCell.Value = "0";
                    Map.Rows[1].HeaderCell.Value = "1";
                        break;
                case "3":
                    Map.Rows.Clear();
                    VarF.Text = "X1 X2";
                    VarS.Text = "X3";
                    while (Map.Columns.Count != 0)
                    {
                        Map.Columns.RemoveAt(0);
                    }
                    Map.Columns.Add("Col1", "00");
                    Map.Columns.Add("Col2", "01");
                    Map.Columns.Add("Col3", "11");
                    Map.Columns.Add("Col4", "10");
                    Map.Columns[0].Width = 50;
                    Map.Columns[1].Width = 50;
                    Map.Columns[2].Width = 50;
                    Map.Columns[3].Width = 50;
                    Map.Rows.Add(2);
                    Map.Rows[0].HeaderCell.Value = "0";
                    Map.Rows[1].HeaderCell.Value = "1";
                    break;
                case "4":
                    Map.Rows.Clear();
                    VarF.Text = "X1 X2";
                    VarS.Text = "X3\n\n X4";
                    while (Map.Columns.Count != 0)
                    {
                        Map.Columns.RemoveAt(0);
                    }
                    Map.Columns.Add("Col1", "00");
                    Map.Columns.Add("Col2", "01");
                    Map.Columns.Add("Col3", "11");
                    Map.Columns.Add("Col4", "10");
                    Map.Columns[0].Width = 50;
                    Map.Columns[1].Width = 50;
                    Map.Columns[2].Width = 50;
                    Map.Columns[3].Width = 50;
                    Map.Rows.Add(4);
                    Map.Rows[0].HeaderCell.Value = "00";
                    Map.Rows[1].HeaderCell.Value = "01";
                    Map.Rows[2].HeaderCell.Value = "11";
                    Map.Rows[3].HeaderCell.Value = "10";
                    break;
                case "5":
                    Map.Rows.Clear();
                    VarF.Text = "X1 X2 X3";
                    VarS.Text = "X4\n\n X5";
                    while (Map.Columns.Count != 0)
                    {
                        Map.Columns.RemoveAt(0);
                    }
                    Map.Columns.Add("Col1", "000");
                    Map.Columns.Add("Col2", "001");
                    Map.Columns.Add("Col3", "011");
                    Map.Columns.Add("Col4", "010");
                    Map.Columns.Add("Col5", "110");
                    Map.Columns.Add("Col6", "111");
                    Map.Columns.Add("Col7", "101");
                    Map.Columns.Add("Col8", "100");
                    Map.Columns[0].Width = 50;
                    Map.Columns[1].Width = 50;
                    Map.Columns[2].Width = 50;
                    Map.Columns[3].Width = 50;
                    Map.Columns[4].Width = 50;
                    Map.Columns[5].Width = 50;
                    Map.Columns[6].Width = 50;
                    Map.Columns[7].Width = 50;
                    Map.Rows.Add(4);
                    Map.Rows[0].HeaderCell.Value = "00";
                    Map.Rows[1].HeaderCell.Value = "01";
                    Map.Rows[2].HeaderCell.Value = "11";
                    Map.Rows[3].HeaderCell.Value = "10";
                    break;
                case "6":
                    Map.Rows.Clear();
                    VarF.Text = "X1 X2 X3";
                    VarS.Text = "X4\n\n X5\n\n X6";
                    while (Map.Columns.Count != 0)
                    {
                        Map.Columns.RemoveAt(0);
                    }
                    Map.Columns.Add("Col1", "000");
                    Map.Columns.Add("Col2", "001");
                    Map.Columns.Add("Col3", "011");
                    Map.Columns.Add("Col4", "010");
                    Map.Columns.Add("Col5", "110");
                    Map.Columns.Add("Col6", "111");
                    Map.Columns.Add("Col7", "101");
                    Map.Columns.Add("Col8", "100");
                    Map.Columns[0].Width = 50;
                    Map.Columns[1].Width = 50;
                    Map.Columns[2].Width = 50;
                    Map.Columns[3].Width = 50;
                    Map.Columns[4].Width = 50;
                    Map.Columns[5].Width = 50;
                    Map.Columns[6].Width = 50;
                    Map.Columns[7].Width = 50;
                    Map.Rows.Add(8);
                    Map.Rows[0].HeaderCell.Value = "000";
                    Map.Rows[1].HeaderCell.Value = "001";
                    Map.Rows[2].HeaderCell.Value = "011";
                    Map.Rows[3].HeaderCell.Value = "010";
                    Map.Rows[4].HeaderCell.Value = "110";
                    Map.Rows[5].HeaderCell.Value = "111";
                    Map.Rows[6].HeaderCell.Value = "101";
                    Map.Rows[7].HeaderCell.Value = "100";
                    break;
                case "7":
                    Map.Rows.Clear();
                    VarF.Text = "X1 X2 X3 X4";
                    VarS.Text = "X5\n\n X6\n\n X7";
                    while (Map.Columns.Count != 0)
                    {
                        Map.Columns.RemoveAt(0);
                    }
                    Map.Columns.Add("Col1", "0000");
                    Map.Columns.Add("Col2", "0001");
                    Map.Columns.Add("Col3", "0011");
                    Map.Columns.Add("Col4", "0010");
                    Map.Columns.Add("Col5", "0110");
                    Map.Columns.Add("Col6", "0111");
                    Map.Columns.Add("Col7", "0101");
                    Map.Columns.Add("Col8", "0100");
                    Map.Columns.Add("Col1", "1100");
                    Map.Columns.Add("Col2", "1101");
                    Map.Columns.Add("Col3", "1111");
                    Map.Columns.Add("Col4", "1110");
                    Map.Columns.Add("Col5", "1010");
                    Map.Columns.Add("Col6", "1011");
                    Map.Columns.Add("Col7", "1001");
                    Map.Columns.Add("Col8", "1000");
                    Map.Columns[0].Width = 50;
                    Map.Columns[1].Width = 50;
                    Map.Columns[2].Width = 50;
                    Map.Columns[3].Width = 50;
                    Map.Columns[4].Width = 50;
                    Map.Columns[5].Width = 50;
                    Map.Columns[6].Width = 50;
                    Map.Columns[7].Width = 50;
                    Map.Columns[8].Width = 50;
                    Map.Columns[9].Width = 50;
                    Map.Columns[10].Width = 50;
                    Map.Columns[11].Width = 50;
                    Map.Columns[12].Width = 50;
                    Map.Columns[13].Width = 50;
                    Map.Columns[14].Width = 50;
                    Map.Columns[15].Width = 50;
                    Map.Rows.Add(8);
                    Map.Rows[0].HeaderCell.Value = "000";
                    Map.Rows[1].HeaderCell.Value = "001";
                    Map.Rows[2].HeaderCell.Value = "011";
                    Map.Rows[3].HeaderCell.Value = "010";
                    Map.Rows[4].HeaderCell.Value = "110";
                    Map.Rows[5].HeaderCell.Value = "111";
                    Map.Rows[6].HeaderCell.Value = "101";
                    Map.Rows[7].HeaderCell.Value = "100";
                    break;
                default: MessageBox.Show("Ti cho pituh progu palamal"); break;
            }
        }
    }
}
