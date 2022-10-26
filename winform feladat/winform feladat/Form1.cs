using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(numericUpDown1.Text))
            {
                MessageBox.Show("Nem adta meg az összes adatot!");
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Nem adta meg az összes adatot!");
            }
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Nem adta meg az összes adatot!");
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("Nem adta meg az összes adatot!");
            }
            if (String.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Nem adta meg az összes adatot!");
            }


        }
    }
}
