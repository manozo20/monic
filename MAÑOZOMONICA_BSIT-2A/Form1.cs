using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAÑOZOMONICA_BSIT_2A
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (tb_username.Text.Trim().Equals(""))
            {
                tb_username.Focus();
                MessageBox.Show("PLEASE INPUT UNSER NAME");

            }

           else if (tb_pass.Text.Trim().Equals(""))
            {
                tb_pass.Focus();
                MessageBox.Show("PELEASE INPUT PASSWORD");
          }

           else
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();

            }
        }
    }
}
