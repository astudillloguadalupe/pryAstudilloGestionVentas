using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAstudilloGestionVentas
{
    public partial class frmAgendaContactos : Form
    {
        public frmAgendaContactos()
        {
            InitializeComponent();
        }
        public static class DatosCompartidos
        {
            public static string[] Nombres = new string[20];
            public static string[] Numeros = new string[20];
            public static int Cantidad = 0;
        }
        string vContacto = "";
        string vNumero = "";
        int vCantContactos = 0;
        DateTime vFecha = DateTime.Now;

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
            {
                mktNumero.Enabled = true;
            }
            else
            {
                mktNumero.Enabled = false;
            }
        }



        private void mktNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mktNumero.Text != "")
            {
                btnAgendar.Enabled = true;

            }
            else
            {
                btnAgendar.Enabled = false;
            }

        }
        int indice = 0;
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mktNumero.Text;

            if (DatosCompartidos.Cantidad < DatosCompartidos.Nombres.Length)
            {
                DatosCompartidos.Nombres[DatosCompartidos.Cantidad] = vContacto;
                DatosCompartidos.Numeros[DatosCompartidos.Cantidad] = vNumero;
                DatosCompartidos.Cantidad++;
                LimpiarControles();
            }
            lstResultado.Items.Add($"Contacto: {vContacto} - Número: {vNumero}");


            vCantContactos++;
            lblCantidad.Text = $"Cantidad de Contactos: {vCantContactos}";
            lblFechaHora.Text = $"Fecha y Hora: {vFecha}";

            LimpiarControles();
        }
        private void frmAgendaContactos_Load(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            txtContacto.Clear();
            mktNumero.Clear();
            txtContacto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();

            }
        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmContactos frmContactos = new frmContactos();
            frmContactos.ShowDialog();
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
