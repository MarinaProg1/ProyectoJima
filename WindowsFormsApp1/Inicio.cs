using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        private static Usuario _usuarioActual;
        public Inicio(Usuario objUsuario)
        {
            _usuarioActual = objUsuario;    
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = _usuarioActual.NombreCompleto;
        }
    }
}
