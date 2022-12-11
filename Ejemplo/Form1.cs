using DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
      
        private void button1_Click(object sender, EventArgs e)
        {

            Suma sum = new Suma();

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int r = sum.Sumar(a, b);
           
            label1.Text=Convert.ToString(r);

            
        }
    }
}
