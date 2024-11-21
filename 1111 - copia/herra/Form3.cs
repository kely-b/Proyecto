using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herra
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string documento = txtDocumento.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(documento) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cliente registrado exitosamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();
                txtDocumento.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Registro_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }
    }
}

