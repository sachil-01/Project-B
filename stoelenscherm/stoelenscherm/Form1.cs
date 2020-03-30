using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoelenscherm
{
    public partial class Form1 : Form
    {
        List<Button> chairs = new List<Button>();

        const int ButtonWidth = 45;
        const int ButtonHeight = 45;
        int n = 1;
        public Form1()


        
        {
            InitializeComponent();
            for (int j = 1, ButtonY=100; j <11; j++,ButtonY+=50)
            {
                for ( int i = 1, ButtonX = 502; i < 11; ButtonX += 50,n++,i++)
                {
                    Button chair = new Button();
                    chair.Location = new Point(ButtonX, ButtonY);
                    chair.Size = new Size(ButtonWidth, ButtonHeight);
                    chair.Name = "chair " + n;
                    chair.Text = "" + n;
                    chair.TabStop = false;
                    chair.FlatStyle = FlatStyle.Flat;
                    chair.FlatAppearance.BorderSize = 0;
                    chair.BackColor = Color.PeachPuff;
                    panel1.Controls.Add(chair);
                    chairs.Add(chair);
                  

                }



            }








        }
    }
}

