namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            menuVentas = new FontAwesome.Sharp.IconMenuItem();
            menuCompra = new FontAwesome.Sharp.IconMenuItem();
            menuCliente = new FontAwesome.Sharp.IconMenuItem();
            menuProveedor = new FontAwesome.Sharp.IconMenuItem();
            menuReporte = new FontAwesome.Sharp.IconMenuItem();
            menuAcerdaDe = new FontAwesome.Sharp.IconMenuItem();
            menuTitulo = new MenuStrip();
            contenedor = new Panel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.Items.AddRange(new ToolStripItem[] { menuUsuario, menuMantenedor, menuVentas, menuCompra, menuCliente, menuProveedor, menuReporte, menuAcerdaDe });
            menu.Location = new Point(0, 59);
            menu.Name = "menu";
            menu.Size = new Size(800, 78);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            menuUsuario.AutoSize = false;
            menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            menuUsuario.IconColor = Color.Black;
            menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuario.IconSize = 55;
            menuUsuario.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuario.Name = "menuUsuario";
            menuUsuario.Size = new Size(80, 74);
            menuUsuario.Text = "Usuario";
            menuUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuMantenedor
            // 
            menuMantenedor.AutoSize = false;
            menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            menuMantenedor.IconColor = Color.Black;
            menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuMantenedor.IconSize = 55;
            menuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menuMantenedor.Name = "menuMantenedor";
            menuMantenedor.Size = new Size(80, 74);
            menuMantenedor.Text = "Mantenedor";
            menuMantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuVentas
            // 
            menuVentas.AutoSize = false;
            menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuVentas.IconColor = Color.Black;
            menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuVentas.IconSize = 55;
            menuVentas.ImageScaling = ToolStripItemImageScaling.None;
            menuVentas.Name = "menuVentas";
            menuVentas.Size = new Size(80, 74);
            menuVentas.Text = "Ventas";
            menuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuCompra
            // 
            menuCompra.AutoSize = false;
            menuCompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            menuCompra.IconColor = Color.Black;
            menuCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCompra.IconSize = 55;
            menuCompra.ImageScaling = ToolStripItemImageScaling.None;
            menuCompra.Name = "menuCompra";
            menuCompra.Size = new Size(80, 74);
            menuCompra.Text = "Compras";
            menuCompra.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuCliente
            // 
            menuCliente.AutoSize = false;
            menuCliente.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            menuCliente.IconColor = Color.Black;
            menuCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuCliente.IconSize = 55;
            menuCliente.ImageScaling = ToolStripItemImageScaling.None;
            menuCliente.Name = "menuCliente";
            menuCliente.Size = new Size(80, 74);
            menuCliente.Text = "Clientes";
            menuCliente.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuProveedor
            // 
            menuProveedor.AutoSize = false;
            menuProveedor.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            menuProveedor.IconColor = Color.Black;
            menuProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProveedor.IconSize = 55;
            menuProveedor.ImageScaling = ToolStripItemImageScaling.None;
            menuProveedor.Name = "menuProveedor";
            menuProveedor.Size = new Size(80, 74);
            menuProveedor.Text = "Proveedor";
            menuProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuReporte
            // 
            menuReporte.AutoSize = false;
            menuReporte.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menuReporte.IconColor = Color.Black;
            menuReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuReporte.IconSize = 55;
            menuReporte.ImageScaling = ToolStripItemImageScaling.None;
            menuReporte.Name = "menuReporte";
            menuReporte.Size = new Size(80, 74);
            menuReporte.Text = "Reportes";
            menuReporte.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuAcerdaDe
            // 
            menuAcerdaDe.AutoSize = false;
            menuAcerdaDe.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            menuAcerdaDe.IconColor = Color.Black;
            menuAcerdaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuAcerdaDe.IconSize = 55;
            menuAcerdaDe.ImageScaling = ToolStripItemImageScaling.None;
            menuAcerdaDe.Name = "menuAcerdaDe";
            menuAcerdaDe.Size = new Size(80, 74);
            menuAcerdaDe.Text = "Acerca de";
            menuAcerdaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.RosyBrown;
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.RightToLeft = RightToLeft.Yes;
            menuTitulo.Size = new Size(800, 59);
            menuTitulo.TabIndex = 1;
            menuTitulo.Text = "menuStrip2";
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 137);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(800, 313);
            contenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contenedor);
            Controls.Add(menu);
            Controls.Add(menuTitulo);
            MainMenuStrip = menu;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompra;
        private FontAwesome.Sharp.IconMenuItem menuCliente;
        private FontAwesome.Sharp.IconMenuItem menuProveedor;
        private FontAwesome.Sharp.IconMenuItem menuReporte;
        private FontAwesome.Sharp.IconMenuItem menuAcerdaDe;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private Panel contenedor;
    }
}
