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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox[] arr;
        private void button1_Click(object sender, EventArgs e)
        {
          
            if(arr==null)
            {arr = new TextBox[Convert.ToInt32(textBox1.Text)];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new TextBox();
                    arr[i].Size = new Size(60, 20);
                    if (horizntal.Checked)
                    {
                        arr[i].Left = i * arr[i].Width;
                        arr[i].Top = 10;
                    }
                    else if (verticle.Checked)
                    {
                        arr[i].Top = i * arr[i].Height;
                        arr[i].Left = 10;
                    }
                    else MessageBox.Show("يجب تحديد الطول");
                    Controls.Add(arr[i]);
                }
            }
          else  if (textBox1.Text.Trim() != "")
            {
                if (arr != null)
                {
                    for (int i = 0;i< arr.Length; i++)
                    { arr[i].Dispose(); }
                }
            }
        }
        private void isnumeric(Object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            else
                e.Handled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += isnumeric;
            this.AutoSize = true;
            this.AutoScroll = true;
        }
    }
}
