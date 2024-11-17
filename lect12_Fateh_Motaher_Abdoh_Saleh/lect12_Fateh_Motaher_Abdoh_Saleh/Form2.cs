using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect12_Fateh_Motaher_Abdoh_Saleh
{
    public class circlebutton : Button
    {
        public circlebutton() { this.Text = "circle"; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, Width - 1, Height - 1);
            //GraphicsPath g = new GraphicsPath();
            //g.AdEllipsis(0, 0, Width - 1, Height - 1);
            //Region = new Region(g);
        }

    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().DrawLine(Pens.Red, 125, 100, 150, 150);
            panel1.CreateGraphics().DrawLine(Pens.Green, 150, 150, 100, 150);
            panel1.CreateGraphics().DrawLine(Pens.Yellow, 100, 150, 125, 100);
            panel1.CreateGraphics().DrawLine(Pens.Blue, 125, 100, 125, 150);
        }
    }
}
