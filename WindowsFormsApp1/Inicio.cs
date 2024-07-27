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
using FontAwesome.Sharp;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        private static Usuario _usuarioActual;
        private static IconMenuItem _menuActivo = null;
        private static Form _formularioActivo = null;
        public Inicio(Usuario objUsuario)
        {
            _usuarioActual = objUsuario;    
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listPermiso = new CN_Permiso().Listar(_usuarioActual.IdUsuario); 
            
           foreach(IconMenuItem iconMenu in menu.Items) 
            {
                bool encontrado = listPermiso.Any(m => m.NombreMenu == iconMenu.Name);
                
                if (encontrado) 
                {
                 iconMenu.Visible = false;  
                }
            }

            lblUsuario.Text = _usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario) 
        {
            if (_menuActivo != null) 
            { 
                _menuActivo.BackColor = Color.Aqua;
            }
            menu.BackColor = Color.Tomato;
            _menuActivo = menu;

            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
            }
            _formularioActivo = formulario; 
            formulario.TopLevel = false;    
            formulario.FormBorderStyle = FormBorderStyle.None;  
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Tomato;
            
            contenedor.Controls.Add(formulario); 
            formulario.Show();

        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FormUsuario());  
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new FormCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new FormProducto());
        }

        private void subMenuRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new FormVenta());
        }

        private void subMenuVerDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new FormDetalleVenta());
        }

        private void subMenuRegistarComp_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompra, new FormCompras());
        }

        private void subMenuVerDetComp_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompra, new FormDetalleCompra());
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormCliente());
        }

        private void menuProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormProveedores());
        }

        private void menuReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormReportes());
        }
    }
}
