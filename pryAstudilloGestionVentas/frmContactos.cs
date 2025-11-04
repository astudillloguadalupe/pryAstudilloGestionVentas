using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryAstudilloGestionVentas.frmAgendaContactos;

namespace pryAstudilloGestionVentas
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        int indice = 0;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmContactos_Load(object sender, EventArgs e)
        {
            lstContactos.Items.Clear();

            if (DatosCompartidos.Cantidad > 0)
            {
                for (int i = 0; i < DatosCompartidos.Cantidad; i++)
                {
                    lstContactos.Items.Add($"{DatosCompartidos.Nombres[i]} - {DatosCompartidos.Numeros[i]}");
                }

                lstContactos.SelectedIndex = 0; // Muestra el primero por defecto
                btnAtras.Enabled = false;
                btnSiguiente.Enabled = DatosCompartidos.Cantidad > 1;
            }
            else
            {
                lstContactos.Items.Add("No hay contactos registrados.");
                btnAtras.Enabled = false;
                btnSiguiente.Enabled = false;
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < DatosCompartidos.Cantidad - 1)
            {
                indice++;
                lstContactos.Text = $"{DatosCompartidos.Nombres[indice]} - {DatosCompartidos.Numeros[indice]}";
                btnAtras.Enabled = true;
            }
            if (indice == DatosCompartidos.Cantidad - 1)
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                lstContactos.Text = $"{DatosCompartidos.Nombres[indice]} - {DatosCompartidos.Numeros[indice]}";
                btnSiguiente.Enabled = true;
            }

            if (indice == 0)
            {
                btnAtras.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
