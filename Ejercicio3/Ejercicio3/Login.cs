using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA= new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuarioTextBox.Text, ClaveTextBox.Text);
            if (usuario == null)
            {

                MessageBox.Show("Datos erróneos");
            }
            else if (!usuario.EstaActivo)
            {

                MessageBox.Show("Usuario inactivo");
            }
            frmUsuariosRegistrados FrmUsuariosRegistrados = new frmUsuariosRegistrados();
            FrmUsuariosRegistrados.Show();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
