using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Search sh = new Search();
        Product p = new Product();
        
        

        private void button3_Click(object sender, EventArgs e)
        {
            
            sh.Find(textBox1, textBox2, textBox3);
            sh.Show(textBox2, textBox3);
            var r = new Retailer(textBox2,textBox3);

        }
        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            p.Calculate(textBox5, textBox4, textBox7, textBox6,dateTimePicker1);
        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Retailer r = new Retailer(textBox2,textBox3);
            Record rd = new Record(p, r);
            rd.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retailer r = new Retailer(textBox2,textBox3);
            Record rd = new Record(p, r);
            rd.Show(dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
