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
    public partial class StoelenScherm : Form
    {
        List<Button> chairs = new List<Button>();

        const int ButtonWidth = 45;
        const int ButtonHeight = 45;
        int counter = 1;
        Button reserved;
        public StoelenScherm()


        
        {
            InitializeComponent();
            for (int countVertical = 1, buttonY=100; countVertical < 11; countVertical++,buttonY+=50)
            {
                for ( int countHorizontal = 1, buttonX = 502; countHorizontal < 11; buttonX += 50,counter++, countHorizontal++)
                {
                    Button chair = new Button();
                    chair.Location = new Point(buttonX, buttonY);
                    chair.Size = new Size(ButtonWidth, ButtonHeight);
                    chair.Name = "chair " + counter;
                    chair.Text = "" + counter;
                    chair.TabStop = false;
                    chair.FlatStyle = FlatStyle.Flat;
                    chair.FlatAppearance.BorderSize = 0;
                    chair.BackColor = Color.PeachPuff;
                    chair.Anchor = (AnchorStyles.None);
                    panel1.Controls.Add(chair);
                    chairs.Add(chair);
                    chair.Click += new EventHandler(this.SelectChair);
                    

                }


            }
             reserved=chairs[0];

        }

         void SelectChair(object sender, EventArgs e)
        {
            reserved.BackColor= Color.PeachPuff;
            Button Chair = (Button)sender;
            Chair.BackColor = Color.Blue;
            reserved = Chair;
            
        }












    }
    }


