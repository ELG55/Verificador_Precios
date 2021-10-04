
namespace Verificador_Precios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lb_codigo_ingresado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_Por_favor_pase = new System.Windows.Forms.Label();
            this.lb_no_se_encontro = new System.Windows.Forms.Label();
            this.lb_buscando = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_datosProducto = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tmr_loading = new System.Windows.Forms.Timer(this.components);
            this.tmr_return = new System.Windows.Forms.Timer(this.components);
            this.pb_warning = new System.Windows.Forms.PictureBox();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.pb_scan = new System.Windows.Forms.PictureBox();
            this.pb_logo_center = new System.Windows.Forms.PictureBox();
            this.pb_producto = new System.Windows.Forms.PictureBox();
            this.pb_productoBackground = new System.Windows.Forms.PictureBox();
            this.pb_logo_producto = new System.Windows.Forms.PictureBox();
            this.lb_no_se_logro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_productoBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lb_codigo_ingresado
            // 
            this.lb_codigo_ingresado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_codigo_ingresado.AutoSize = true;
            this.lb_codigo_ingresado.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo_ingresado.Location = new System.Drawing.Point(396, 386);
            this.lb_codigo_ingresado.Name = "lb_codigo_ingresado";
            this.lb_codigo_ingresado.Size = new System.Drawing.Size(219, 31);
            this.lb_codigo_ingresado.TabIndex = 1;
            this.lb_codigo_ingresado.Text = "Código ingresado";
            this.lb_codigo_ingresado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 577);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.tabPage1.Controls.Add(this.lb_no_se_logro);
            this.tabPage1.Controls.Add(this.lb_Por_favor_pase);
            this.tabPage1.Controls.Add(this.lb_no_se_encontro);
            this.tabPage1.Controls.Add(this.pb_warning);
            this.tabPage1.Controls.Add(this.lb_buscando);
            this.tabPage1.Controls.Add(this.pb_loading);
            this.tabPage1.Controls.Add(this.tb_codigo);
            this.tabPage1.Controls.Add(this.pb_scan);
            this.tabPage1.Controls.Add(this.pb_logo_center);
            this.tabPage1.Controls.Add(this.lb_codigo_ingresado);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lectura";
            // 
            // lb_Por_favor_pase
            // 
            this.lb_Por_favor_pase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Por_favor_pase.AutoSize = true;
            this.lb_Por_favor_pase.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Por_favor_pase.Location = new System.Drawing.Point(208, 386);
            this.lb_Por_favor_pase.Name = "lb_Por_favor_pase";
            this.lb_Por_favor_pase.Size = new System.Drawing.Size(608, 31);
            this.lb_Por_favor_pase.TabIndex = 10;
            this.lb_Por_favor_pase.Text = "Por favor pase a servicio al cliente para obtener ayuda.";
            this.lb_Por_favor_pase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Por_favor_pase.Visible = false;
            // 
            // lb_no_se_encontro
            // 
            this.lb_no_se_encontro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_no_se_encontro.AutoSize = true;
            this.lb_no_se_encontro.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no_se_encontro.Location = new System.Drawing.Point(346, 342);
            this.lb_no_se_encontro.Name = "lb_no_se_encontro";
            this.lb_no_se_encontro.Size = new System.Drawing.Size(328, 31);
            this.lb_no_se_encontro.TabIndex = 9;
            this.lb_no_se_encontro.Text = "No se encontró el producto";
            this.lb_no_se_encontro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_no_se_encontro.Visible = false;
            // 
            // lb_buscando
            // 
            this.lb_buscando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_buscando.AutoSize = true;
            this.lb_buscando.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buscando.Location = new System.Drawing.Point(433, 386);
            this.lb_buscando.Name = "lb_buscando";
            this.lb_buscando.Size = new System.Drawing.Size(143, 31);
            this.lb_buscando.TabIndex = 7;
            this.lb_buscando.Text = "Buscando...";
            this.lb_buscando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_buscando.Visible = false;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(393, 429);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.ReadOnly = true;
            this.tb_codigo.Size = new System.Drawing.Size(222, 32);
            this.tb_codigo.TabIndex = 5;
            this.tb_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            this.tabPage2.Controls.Add(this.pb_producto);
            this.tabPage2.Controls.Add(this.pb_productoBackground);
            this.tabPage2.Controls.Add(this.pb_logo_producto);
            this.tabPage2.Controls.Add(this.lb_datosProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Producto";
            // 
            // lb_datosProducto
            // 
            this.lb_datosProducto.AutoSize = true;
            this.lb_datosProducto.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datosProducto.Location = new System.Drawing.Point(456, 152);
            this.lb_datosProducto.Name = "lb_datosProducto";
            this.lb_datosProducto.Size = new System.Drawing.Size(24, 33);
            this.lb_datosProducto.TabIndex = 5;
            this.lb_datosProducto.Text = "-";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tmr_loading
            // 
            this.tmr_loading.Interval = 1000;
            this.tmr_loading.Tick += new System.EventHandler(this.tmr_loading_Tick);
            // 
            // tmr_return
            // 
            this.tmr_return.Interval = 1000;
            this.tmr_return.Tick += new System.EventHandler(this.tmr_return_Tick);
            // 
            // pb_warning
            // 
            this.pb_warning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_warning.Image = ((System.Drawing.Image)(resources.GetObject("pb_warning.Image")));
            this.pb_warning.Location = new System.Drawing.Point(393, 164);
            this.pb_warning.Name = "pb_warning";
            this.pb_warning.Size = new System.Drawing.Size(222, 167);
            this.pb_warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_warning.TabIndex = 8;
            this.pb_warning.TabStop = false;
            this.pb_warning.Visible = false;
            // 
            // pb_loading
            // 
            this.pb_loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_loading.Image = ((System.Drawing.Image)(resources.GetObject("pb_loading.Image")));
            this.pb_loading.Location = new System.Drawing.Point(374, 174);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(259, 199);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_loading.TabIndex = 6;
            this.pb_loading.TabStop = false;
            this.pb_loading.Visible = false;
            // 
            // pb_scan
            // 
            this.pb_scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_scan.Image = ((System.Drawing.Image)(resources.GetObject("pb_scan.Image")));
            this.pb_scan.Location = new System.Drawing.Point(393, 216);
            this.pb_scan.Name = "pb_scan";
            this.pb_scan.Size = new System.Drawing.Size(222, 167);
            this.pb_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_scan.TabIndex = 2;
            this.pb_scan.TabStop = false;
            // 
            // pb_logo_center
            // 
            this.pb_logo_center.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_logo_center.BackgroundImage")));
            this.pb_logo_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo_center.Location = new System.Drawing.Point(343, 24);
            this.pb_logo_center.Name = "pb_logo_center";
            this.pb_logo_center.Size = new System.Drawing.Size(331, 186);
            this.pb_logo_center.TabIndex = 0;
            this.pb_logo_center.TabStop = false;
            // 
            // pb_producto
            // 
            this.pb_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.pb_producto.Location = new System.Drawing.Point(155, 115);
            this.pb_producto.Margin = new System.Windows.Forms.Padding(2);
            this.pb_producto.Name = "pb_producto";
            this.pb_producto.Size = new System.Drawing.Size(255, 309);
            this.pb_producto.TabIndex = 6;
            this.pb_producto.TabStop = false;
            // 
            // pb_productoBackground
            // 
            this.pb_productoBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_productoBackground.BackgroundImage")));
            this.pb_productoBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_productoBackground.Location = new System.Drawing.Point(135, 86);
            this.pb_productoBackground.Name = "pb_productoBackground";
            this.pb_productoBackground.Size = new System.Drawing.Size(297, 371);
            this.pb_productoBackground.TabIndex = 8;
            this.pb_productoBackground.TabStop = false;
            // 
            // pb_logo_producto
            // 
            this.pb_logo_producto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_logo_producto.BackgroundImage")));
            this.pb_logo_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logo_producto.Location = new System.Drawing.Point(755, 9);
            this.pb_logo_producto.Name = "pb_logo_producto";
            this.pb_logo_producto.Size = new System.Drawing.Size(252, 117);
            this.pb_logo_producto.TabIndex = 7;
            this.pb_logo_producto.TabStop = false;
            // 
            // lb_no_se_logro
            // 
            this.lb_no_se_logro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_no_se_logro.AutoSize = true;
            this.lb_no_se_logro.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no_se_logro.Location = new System.Drawing.Point(285, 342);
            this.lb_no_se_logro.Name = "lb_no_se_logro";
            this.lb_no_se_logro.Size = new System.Drawing.Size(433, 31);
            this.lb_no_se_logro.TabIndex = 11;
            this.lb_no_se_logro.Text = "No se logró conectar con el servidor";
            this.lb_no_se_logro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_no_se_logro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificador de precios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_scan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_productoBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pb_logo_center;
        private System.Windows.Forms.Label lb_codigo_ingresado;
        private System.Windows.Forms.PictureBox pb_scan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label lb_datosProducto;
        private System.Windows.Forms.PictureBox pb_producto;
        private System.Windows.Forms.PictureBox pb_productoBackground;
        private System.Windows.Forms.PictureBox pb_logo_producto;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pb_loading;
        private System.Windows.Forms.Label lb_buscando;
        private System.Windows.Forms.Timer tmr_loading;
        private System.Windows.Forms.PictureBox pb_warning;
        private System.Windows.Forms.Label lb_Por_favor_pase;
        private System.Windows.Forms.Label lb_no_se_encontro;
        private System.Windows.Forms.Timer tmr_return;
        private System.Windows.Forms.Label lb_no_se_logro;
    }
}

