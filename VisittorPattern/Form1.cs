using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisittorPattern
{
    public partial class Form1 : Form
    {
        int contador = 0;
        decimal multi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                if (chkBox.GetItemChecked(i))
                {
                    contador++;
                }
            multi = numericUpDown1.Value;
            string resultado=contador.ToString();

            decimal res = contador * 100;
            res = res * multi;

           MessageBox.Show("El costo por envío normal sería de " +res.ToString());

            contador =0;
            res = 0;
            multi = 0;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
                if (chkBox.GetItemChecked(i))
                {
                    contador++;
                }
            multi = numericUpDown1.Value;
            string resultado = contador.ToString();

            decimal res = contador * 181;
            res = res * multi;

            MessageBox.Show("El costo por envío especial sería de " + res.ToString());

            contador = 0;
            res = 0;
            multi = 0;

        }
    }
}
