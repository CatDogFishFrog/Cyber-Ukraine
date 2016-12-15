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
            for (int i = 0; i < Map.Rows.Count; i++)
            {
                for (int j = 0; j < Map.Columns.Count; j++)
                {
                    Map.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < Map.Rows.Count; i++)
            {
                for (int j = 0; j < Map.Columns.Count; j++)
                {
                    if (Map.Rows[i].Cells[j].Value == null)
                        Map.Rows[i].Cells[j].Value = "0";
                }
            }
            Outp.Clear();
            string @var = VarCol.Text;
            switch (@var)
            {
                case "2":
                    if (Map.Rows[0].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.AliceBlue;
                        Outp.Text += "!X1!X2\n";
                    }
                    if (Map.Rows[0].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Azure;
                        Outp.Text += "X1!X2\n";
                    }
                    if (Map.Rows[1].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Beige;
                        Outp.Text += "!X1X2\n";
                    }
                    if (Map.Rows[1].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Bisque;
                        Outp.Text += "X1X2\n";
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.BlanchedAlmond;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.BlanchedAlmond;
                        Outp.Text += "!X1!X2+X1!X2\n";
                    }
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.CadetBlue;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.CadetBlue;
                        Outp.Text += "!X1X2+X1X2\n";
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Chocolate;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Chocolate;
                        Outp.Text += "!X1!X2+!X1X2\n";
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Coral;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Coral;
                        Outp.Text += "X1!X2+X1X2\n";
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Plum;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Plum;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Plum;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Plum;
                    }
                        ; break;
                case "3":
                    if (Map.Rows[0].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Gray;
                    }
                    if (Map.Rows[0].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.MediumPurple;
                    }
                    if (Map.Rows[0].Cells[2].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.BlueViolet;
                    }
                    if (Map.Rows[0].Cells[3].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Brown;
                    }
                    if (Map.Rows[1].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Maroon;
                    }
                    if (Map.Rows[1].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Cyan;
                    }
                    if (Map.Rows[1].Cells[2].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DarkBlue;
                    }
                    if (Map.Rows[1].Cells[3].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[3].Style.BackColor = Color.DarkCyan;
                    }
                    //
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Violet;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Violet;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[0].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Khaki;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Khaki;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.SaddleBrown;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.SaddleBrown;
                    }
                    if ((Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[0].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Red;
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Red;
                    }
                    //
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Yellow;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Yellow;
                    }
                    if ((Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Orchid;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Orchid;
                    }
                    if ((Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Purple;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Purple;
                    }
                    if ((Map.Rows[1].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Gainsboro;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Gainsboro;
                    }
                    //
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Olive;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Olive;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Ivory;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Ivory;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.PaleGreen;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.PaleGreen;
                    }
                    if ((Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Orange;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Orange;
                    }
                    //
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Tomato;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Tomato;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Tomato;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Tomato;
                    }
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Moccasin;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Moccasin;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Moccasin;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Moccasin;
                    }
                    //
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Blue;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Blue;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Blue;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Blue;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Gold;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Gold;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Green;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Green;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Green;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Green;
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.DarkRed;
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.DarkRed;
                    }
                    ; break;
                case "4":
                    if (Map.Rows[0].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Gray;
                    }
                    if (Map.Rows[0].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.MediumPurple;
                    }
                    if (Map.Rows[0].Cells[2].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.BlueViolet;
                    }
                    if (Map.Rows[0].Cells[3].Value.ToString() == "1")
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Brown;
                    }
                    if (Map.Rows[1].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Maroon;
                    }
                    if (Map.Rows[1].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Cyan;
                    }
                    if (Map.Rows[1].Cells[2].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DarkBlue;
                    }
                    if (Map.Rows[1].Cells[3].Value.ToString() == "1")
                    {
                        Map.Rows[1].Cells[3].Style.BackColor = Color.DarkCyan;
                    }
                    if (Map.Rows[2].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[2].Cells[0].Style.BackColor = Color.Tan;
                    }
                    if (Map.Rows[2].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[2].Cells[1].Style.BackColor = Color.Olive;
                    }
                    if (Map.Rows[2].Cells[2].Value.ToString() == "1")
                    {
                        Map.Rows[2].Cells[2].Style.BackColor = Color.Plum;
                    }
                    if (Map.Rows[2].Cells[3].Value.ToString() == "1")
                    {
                        Map.Rows[2].Cells[3].Style.BackColor = Color.SpringGreen;
                    }
                    if (Map.Rows[3].Cells[0].Value.ToString() == "1")
                    {
                        Map.Rows[3].Cells[0].Style.BackColor = Color.Fuchsia;
                    }
                    if (Map.Rows[3].Cells[1].Value.ToString() == "1")
                    {
                        Map.Rows[3].Cells[1].Style.BackColor = Color.BlanchedAlmond;
                    }
                    if (Map.Rows[3].Cells[2].Value.ToString() == "1")
                    {
                        Map.Rows[3].Cells[2].Style.BackColor = Color.SteelBlue;
                    }
                    if (Map.Rows[3].Cells[3].Value.ToString() == "1")
                    {
                        Map.Rows[3].Cells[3].Style.BackColor = Color.HotPink;
                    }
                    //
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Violet;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Violet;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[0].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Khaki;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Khaki;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.SaddleBrown;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.SaddleBrown;
                    }
                    if ((Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[0].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Red;
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Red;
                    }
                    //s 2
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Yellow;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Yellow;
                    }
                    if ((Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Orchid;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Orchid;
                    }
                    if ((Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Purple;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Purple;
                    }
                    if ((Map.Rows[1].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Gainsboro;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Gainsboro;
                    }
                    //s 3
                    if ((Map.Rows[2].Cells[0].Value.ToString() == "1") && (Map.Rows[2].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[0].Style.BackColor = Color.Indigo;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.Indigo;
                    }
                    if ((Map.Rows[2].Cells[1].Value.ToString() == "1") && (Map.Rows[2].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[1].Style.BackColor = Color.Crimson;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.Crimson;
                    }
                    if ((Map.Rows[2].Cells[2].Value.ToString() == "1") && (Map.Rows[2].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[2].Style.BackColor = Color.SandyBrown;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.SandyBrown;
                    }
                    if ((Map.Rows[1].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[3].Style.BackColor = Color.Firebrick;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.Firebrick;
                    }
                    //s 4
                    if ((Map.Rows[3].Cells[0].Value.ToString() == "1") && (Map.Rows[3].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[3].Cells[0].Style.BackColor = Color.LawnGreen;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.LawnGreen;
                    }
                    if ((Map.Rows[3].Cells[1].Value.ToString() == "1") && (Map.Rows[3].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[3].Cells[1].Style.BackColor = Color.DarkOrange;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.DarkOrange;
                    }
                    if ((Map.Rows[3].Cells[2].Value.ToString() == "1") && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[3].Cells[2].Style.BackColor = Color.GreenYellow;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.GreenYellow;
                    }
                    if ((Map.Rows[3].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[3].Cells[3].Style.BackColor = Color.MediumAquamarine;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.MediumAquamarine;
                    }
                    //ver 1
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Olive;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Olive;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Ivory;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Ivory;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.PaleGreen;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.PaleGreen;
                    }
                    if ((Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Orange;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Orange;
                    }
                    //ver2
                    if ((Map.Rows[2].Cells[0].Value.ToString() == "1") && (Map.Rows[3].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[0].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.MediumTurquoise;
                    }
                    if ((Map.Rows[2].Cells[1].Value.ToString() == "1") && (Map.Rows[3].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[1].Style.BackColor = Color.LawnGreen;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.LawnGreen;
                    }
                    if ((Map.Rows[2].Cells[2].Value.ToString() == "1") && (Map.Rows[3].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[2].Style.BackColor = Color.MistyRose;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.MistyRose;
                    }
                    if ((Map.Rows[2].Cells[3].Value.ToString() == "1") && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[3].Style.BackColor = Color.Navy;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.Navy;
                    }
                    //ver 3
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[2].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.LightGreen;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.LightGreen;
                    }
                    if ((Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[2].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[1].Style.BackColor = Color.PowderBlue;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.PowderBlue;
                    }
                    if ((Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[2].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DarkSalmon;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.DarkSalmon;
                    }
                    if ((Map.Rows[1].Cells[3].Value.ToString() == "1") && (Map.Rows[2].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[3].Style.BackColor = Color.SeaGreen;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.SeaGreen;
                    }
                    //ver 4
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[3].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.SaddleBrown;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.SaddleBrown;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[3].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.LightSteelBlue;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.LightSteelBlue;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[3].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Teal;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.Teal;
                    }
                    if ((Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.MistyRose;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.MistyRose;
                    }
                    // hor 4
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Tomato;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Tomato;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Tomato;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Tomato;
                    }
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Moccasin;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Moccasin;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Moccasin;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Moccasin;
                    }
                    if ((Map.Rows[2].Cells[0].Value.ToString() == "1") && (Map.Rows[2].Cells[1].Value.ToString() == "1") && (Map.Rows[2].Cells[2].Value.ToString() == "1") && (Map.Rows[2].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[0].Style.BackColor = Color.ForestGreen;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.ForestGreen;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.ForestGreen;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.ForestGreen;
                    }
                    if ((Map.Rows[3].Cells[0].Value.ToString() == "1") && (Map.Rows[3].Cells[1].Value.ToString() == "1") && (Map.Rows[3].Cells[2].Value.ToString() == "1") && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[3].Cells[0].Style.BackColor = Color.Peru;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.Peru;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.Peru;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.Peru;
                    }
                    //ver 4
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[2].Cells[0].Value.ToString() == "1") && (Map.Rows[3].Cells[0].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Lime;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Lime;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.Lime;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.Lime;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[2].Cells[1].Value.ToString() == "1") && (Map.Rows[3].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.LimeGreen;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.LimeGreen;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.LimeGreen;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.LimeGreen;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[2].Cells[2].Value.ToString() == "1") && (Map.Rows[3].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.OliveDrab;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.OliveDrab;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.OliveDrab;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.OliveDrab;
                    }
                    if ((Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1") && (Map.Rows[2].Cells[3].Value.ToString() == "1") && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Violet;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Violet;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.Violet;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.Violet;
                    }
                    //4 box
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1") && (Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[0].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Blue;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Blue;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Blue;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Blue;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1") && (Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[1].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Gold;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Gold;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1") && (Map.Rows[0].Cells[3].Value.ToString() == "1") && (Map.Rows[1].Cells[2].Value.ToString() == "1") && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Green;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Green;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Green;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Green;
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[3].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.DarkRed;
                    }
                    if ((Map.Rows[2].Cells[0].Value.ToString() == "1")
                       && (Map.Rows[2].Cells[1].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[0].Style.BackColor = Color.MidnightBlue;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.MidnightBlue;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.MidnightBlue;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.MidnightBlue;
                    }
                    if ((Map.Rows[2].Cells[1].Value.ToString() == "1")
                      && (Map.Rows[2].Cells[2].Value.ToString() == "1")
                      && (Map.Rows[3].Cells[1].Value.ToString() == "1")
                      && (Map.Rows[3].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[1].Style.BackColor = Color.DarkGoldenrod;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.DarkGoldenrod;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.DarkGoldenrod;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.DarkGoldenrod;
                    }
                    if ((Map.Rows[2].Cells[2].Value.ToString() == "1")
                     && (Map.Rows[2].Cells[3].Value.ToString() == "1")
                     && (Map.Rows[3].Cells[2].Value.ToString() == "1")
                     && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[2].Style.BackColor = Color.DarkKhaki;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.DarkKhaki;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.DarkKhaki;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.DarkKhaki;
                    }
                    if ((Map.Rows[2].Cells[0].Value.ToString() == "1")
                     && (Map.Rows[2].Cells[3].Value.ToString() == "1")
                     && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                     && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[0].Style.BackColor = Color.Gold;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.Gold;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.Gold;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.Gold;
                    }
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1")
                     && (Map.Rows[1].Cells[1].Value.ToString() == "1")
                     && (Map.Rows[2].Cells[0].Value.ToString() == "1")
                     && (Map.Rows[2].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.DarkOliveGreen;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.DarkOliveGreen;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.DarkOliveGreen;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.DarkOliveGreen;
                    }
                    if ((Map.Rows[1].Cells[1].Value.ToString() == "1")
                  && (Map.Rows[1].Cells[2].Value.ToString() == "1")
                  && (Map.Rows[2].Cells[1].Value.ToString() == "1")
                  && (Map.Rows[2].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[1].Style.BackColor = Color.DarkSlateGray;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DarkSlateGray;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.DarkSlateGray;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.DarkSlateGray;
                    }
                    if ((Map.Rows[1].Cells[2].Value.ToString() == "1")
                  && (Map.Rows[1].Cells[3].Value.ToString() == "1")
                  && (Map.Rows[2].Cells[2].Value.ToString() == "1")
                  && (Map.Rows[2].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[2].Style.BackColor = Color.IndianRed;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.IndianRed;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.IndianRed;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.IndianRed;
                    }
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1")
                  && (Map.Rows[1].Cells[3].Value.ToString() == "1")
                  && (Map.Rows[2].Cells[0].Value.ToString() == "1")
                  && (Map.Rows[2].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Cyan;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Cyan;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.Cyan;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.Cyan;
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1")
                  && (Map.Rows[0].Cells[1].Value.ToString() == "1")
                  && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                  && (Map.Rows[3].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.Chocolate;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Chocolate;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.Chocolate;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.Chocolate;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1")
              && (Map.Rows[0].Cells[2].Value.ToString() == "1")
              && (Map.Rows[3].Cells[1].Value.ToString() == "1")
              && (Map.Rows[3].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.Gold;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.Gold;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1")
              && (Map.Rows[0].Cells[3].Value.ToString() == "1")
              && (Map.Rows[3].Cells[2].Value.ToString() == "1")
              && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Gray;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Gray;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.Gray;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.Gray;
                    }
                    //8box
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[3].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.DarkRed;
                    }
                    if ((Map.Rows[2].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[3].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[2].Cells[0].Style.BackColor = Color.DodgerBlue;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.DodgerBlue;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.DodgerBlue;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.DodgerBlue;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.DodgerBlue;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.DodgerBlue;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.DodgerBlue;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.DodgerBlue;
                    }
                    if ((Map.Rows[1].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[3].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[1].Cells[0].Style.BackColor = Color.Magenta;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.Magenta;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Magenta;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Magenta;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.Magenta;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.Magenta;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.Magenta;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.Magenta;
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[3].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.MediumOrchid;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.MediumOrchid;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.MediumOrchid;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.MediumOrchid;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.MediumOrchid;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.MediumOrchid;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.MediumOrchid;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.MediumOrchid;
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[1].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[1].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.MediumTurquoise;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.MediumTurquoise;
                    }
                    if ((Map.Rows[0].Cells[1].Value.ToString() == "1")
                       && (Map.Rows[1].Cells[1].Value.ToString() == "1")
                       && (Map.Rows[2].Cells[1].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[1].Value.ToString() == "1")
                       && (Map.Rows[0].Cells[2].Value.ToString() == "1")
                       && (Map.Rows[1].Cells[2].Value.ToString() == "1")
                       && (Map.Rows[2].Cells[2].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[2].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[1].Style.BackColor = Color.DimGray;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.DimGray;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.DimGray;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.DimGray;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.DimGray;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DimGray;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.DimGray;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.DimGray;
                    }
                    if ((Map.Rows[0].Cells[2].Value.ToString() == "1")
                       && (Map.Rows[1].Cells[2].Value.ToString() == "1")
                       && (Map.Rows[2].Cells[2].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[2].Value.ToString() == "1")
                       && (Map.Rows[0].Cells[3].Value.ToString() == "1")
                       && (Map.Rows[1].Cells[3].Value.ToString() == "1")
                       && (Map.Rows[2].Cells[3].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[2].Style.BackColor = Color.Thistle;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.Thistle;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.Thistle;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.Thistle;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.Thistle;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.Thistle;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.Thistle;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.Thistle;
                    }
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1")
                       && (Map.Rows[1].Cells[0].Value.ToString() == "1")
                       && (Map.Rows[2].Cells[0].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                       && (Map.Rows[0].Cells[3].Value.ToString() == "1")
                       && (Map.Rows[1].Cells[3].Value.ToString() == "1")
                       && (Map.Rows[2].Cells[3].Value.ToString() == "1")
                       && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.OrangeRed;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.OrangeRed;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.OrangeRed;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.OrangeRed;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.OrangeRed;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.OrangeRed;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.OrangeRed;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.OrangeRed;
                    }
                    //16box
                    if ((Map.Rows[0].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[0].Cells[1].Value.ToString() == "1") 
                        && (Map.Rows[0].Cells[2].Value.ToString() == "1") 
                        && (Map.Rows[0].Cells[3].Value.ToString() == "1") 
                        && (Map.Rows[1].Cells[0].Value.ToString() == "1") 
                        && (Map.Rows[1].Cells[1].Value.ToString() == "1") 
                        && (Map.Rows[1].Cells[2].Value.ToString() == "1") 
                        && (Map.Rows[1].Cells[3].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[2].Cells[3].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[0].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[1].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[2].Value.ToString() == "1")
                        && (Map.Rows[3].Cells[3].Value.ToString() == "1"))
                    {
                        Map.Rows[0].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[0].Cells[3].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[1].Cells[3].Style.BackColor = Color.DarkRed;
                        Map.Rows[2].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[2].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[2].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[2].Cells[3].Style.BackColor = Color.DarkRed;
                        Map.Rows[3].Cells[0].Style.BackColor = Color.DarkRed;
                        Map.Rows[3].Cells[1].Style.BackColor = Color.DarkRed;
                        Map.Rows[3].Cells[2].Style.BackColor = Color.DarkRed;
                        Map.Rows[3].Cells[3].Style.BackColor = Color.DarkRed;
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
                default: MessageBox.Show("Недопустимое значение!\nКоличество допустимых переменных от 2-7."); break;
            }
        }
    }
}
