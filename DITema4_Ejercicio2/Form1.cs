using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITema4_Ejercicio2
{
    public partial class Form1 : Form
    {
        /*Icono: https://www.flaticon.es/packs/halloween-party-9 */
        byte r;
        byte g;
        byte b;
        string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void SObreBoton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.FromArgb(178, 165, 195);
        }

        private void SalgoDelBoton(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor=Color.Transparent;
        }

        private void BotonDeEnter(object sender, EventArgs e)
        {
            TextBox seleccionado = (TextBox)sender;
            if(seleccionado.Name == "textBox4")
            {
                this.AcceptButton = button2;
            }
            else
            {
                this.AcceptButton = button1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                r = Convert.ToByte(textBox1.Text);
                g = Convert.ToByte(textBox2.Text);
                b = Convert.ToByte(textBox3.Text);
                this.BackColor = Color.FromArgb(r,g,b);
            }
            catch (FormatException)
            {
                MessageBox.Show("Números entre 0 y 255");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Números entre 0 y 255");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            path = textBox4.Text;
            if(path.Contains(".jpg") || path.Contains(".png") || path.Contains(".jpeg") || path.Contains(".gif"))
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(path);
            }
            else
            {
                MessageBox.Show("La ruta no contiene una imagen");
            }
           
        }

        private void Salir(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres salir?", "salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
