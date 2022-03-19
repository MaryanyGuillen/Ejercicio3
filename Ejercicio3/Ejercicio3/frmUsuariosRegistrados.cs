using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class frmUsuariosRegistrados : Form
    {
        public frmUsuariosRegistrados()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();
        private void frmUsuariosRegistrados_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            UsuariosRegistradosDataGridView.DataSource = usuarioDA.ListarUsuarios();     
        }
    }
}
