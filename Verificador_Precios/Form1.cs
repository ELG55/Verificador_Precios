using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {
        private String codigo = "";
        private int tmr_loading_segundos = 0;
        private int tmr_return_segundos = 0;
        private int tmr_return_segundos_limit = 8;
        private bool loading = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_datosProducto.Text =
                        "Código: -" + Environment.NewLine +
                        "Nombre: -" + Environment.NewLine +
                        "Stock: -" + Environment.NewLine +
                        "Precio regular: -" + Environment.NewLine +
                        "Descuento: -" + Environment.NewLine +
                        "Precio final: -";
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (!loading))
            {
                tabControl1.SelectedIndex = 0;
                pb_scan.Visible = false;
                pb_logo_center.Visible = false;
                lb_codigo_ingresado.Visible = false;
                tb_codigo.Visible = false;
                pb_loading.Visible = true;
                lb_buscando.Visible = true;
                pb_warning.Visible = false;
                lb_no_se_encontro.Visible = false;
                lb_Por_favor_pase.Visible = false;
                pb_warning.Visible = false;
                lb_no_se_logro.Visible = false;

                loading = true;
                tmr_loading_segundos = 0;
                tmr_loading.Enabled = true;

                tmr_return.Enabled = false;
                tmr_return_segundos = 0;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                if (codigo.Length > 0)
                {
                    codigo = codigo.Remove(codigo.Length - 1);
                    tb_codigo.Text = codigo;
                }
            }
            else if (codigo.Length < 5)
            {
                codigo += e.KeyChar;
                tb_codigo.Text = codigo;
            }
        }

        private void ShowSearchResults()
        {
            if (!int.TryParse(codigo, out int temp))
            {
                codigo = "-1";
                tb_codigo.Text = "";
            }
            //MessageBox.Show("vamos a buscar el producto "+codigo);
            try
            {
                MySqlConnection servidor;
                servidor = new MySqlConnection("server = 127.0.0.1; user = root; database = verificador_de_precios; SSL Mode = None; ");
                servidor.Open();
                string query = "SELECT producto_codigo, producto_nombre, producto_cantidad, producto_precio, producto_imagen FROM productos WHERE producto_codigo = " + codigo + ";";
                MySqlCommand consulta;
                consulta = new MySqlCommand(query, servidor);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.HasRows)
                {
                    tabControl1.SelectedIndex = 1;
                    pb_scan.Visible = true;
                    pb_logo_center.Visible = true;
                    lb_codigo_ingresado.Visible = true;
                    tb_codigo.Visible = true;
                    pb_loading.Visible = false;
                    lb_buscando.Visible = false;
                    codigo = "";
                    tb_codigo.Text = codigo;
                    resultado.Read();
                    lb_datosProducto.Text =
                        "Código: " + resultado.GetString(0) + Environment.NewLine +
                        "Nombre: " + resultado.GetString(1) + Environment.NewLine +
                        "Stock: " + resultado.GetString(2) + Environment.NewLine +
                        "Precio regular: $" + resultado.GetString(3) + Environment.NewLine +
                        "Descuento: 0%" + Environment.NewLine +
                        "Precio final: $" + resultado.GetString(3);
                    pb_producto.ImageLocation = resultado.GetString(4);
                    pb_producto.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_producto.Refresh();

                    tmr_return_segundos = 0;
                    tmr_return_segundos_limit = 12;
                    tmr_return.Enabled = true;
                }
                else
                {
                    codigo = "";
                    tb_codigo.Text = codigo;
                    pb_producto.ImageLocation = null;
                    pb_producto.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_producto.Refresh();
                    lb_datosProducto.Text =
                        "Código: -" + Environment.NewLine +
                        "Nombre: -" + Environment.NewLine +
                        "Stock: -" + Environment.NewLine +
                        "Precio regular: -" + Environment.NewLine +
                        "Descuento: -" + Environment.NewLine +
                        "Precio final: -";

                    pb_loading.Visible = false;
                    lb_buscando.Visible = false;
                    pb_warning.Visible = true;
                    lb_no_se_encontro.Visible = true;
                    lb_Por_favor_pase.Visible = true;

                    tmr_return_segundos = 0;
                    tmr_return_segundos_limit = 8;
                    tmr_return.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                codigo = "";
                tb_codigo.Text = codigo;
                pb_producto.ImageLocation = null;
                pb_producto.SizeMode = PictureBoxSizeMode.Zoom;
                pb_producto.Refresh();
                lb_datosProducto.Text =
                    "Código: -" + Environment.NewLine +
                    "Nombre: -" + Environment.NewLine +
                    "Stock: -" + Environment.NewLine +
                    "Precio regular: -" + Environment.NewLine +
                    "Descuento: -" + Environment.NewLine +
                    "Precio final: -";

                pb_loading.Visible = false;
                lb_buscando.Visible = false;
                pb_warning.Visible = true;
                lb_no_se_logro.Visible = true;
                lb_no_se_encontro.Visible = false;
                lb_Por_favor_pase.Visible = false;

                tmr_return_segundos = 0;
                tmr_return_segundos_limit = 8;
                tmr_return.Enabled = true;
            }
        }

        private void tmr_loading_Tick(object sender, EventArgs e)
        {
            tmr_loading_segundos++;

            if (tmr_loading_segundos == 2)
            {
                tmr_loading.Enabled = false;
                loading = false;
                ShowSearchResults();
            }
        }

        private void tmr_return_Tick(object sender, EventArgs e)
        {
            tmr_return_segundos++;

            if (tmr_return_segundos == tmr_return_segundos_limit)
            {
                tmr_return.Enabled = false;
                pb_loading.Visible = false;
                lb_buscando.Visible = false;
                pb_warning.Visible = false;
                lb_no_se_logro.Visible = false;
                lb_no_se_encontro.Visible = false;
                lb_Por_favor_pase.Visible = false;
                pb_logo_center.Visible = true;
                pb_scan.Visible = true;
                lb_codigo_ingresado.Visible = true;
                tb_codigo.Visible = true;
                tabControl1.SelectedIndex = 0;
            }
        }
    }
}
