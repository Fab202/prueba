using System;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Ingrese un numero");
                textBox1.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Ingrese un numero");
                textBox2.Focus();
                return;
            }
            errorProvider1.Clear();

            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            MessageBox.Show("La multi es: " + (num1 * num2), "Respuesta",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
