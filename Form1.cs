using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WF_CSharp_Arreglo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int cantidadpersonas = 0;
        private int registro = 0;
        private Contacto[] arreglo;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (registro < cantidadpersonas)
            {
                registro = registro+ 1;
                Contacto contactonew = new Contacto();
                contactonew.Nombre = txtNombre.Text;
                contactonew.FechaNacimiento = dtpFecha.Value;
                contactonew.Telefono = txtTelefono.Text;
                contactonew.Correo = txtCorreo.Text;
                arreglo[registro] = contactonew;
                
             string nuevalinea = contactonew.Nombre + ", " + contactonew.Edad.ToString() + ", " + contactonew.Telefono.ToString() + ", " + contactonew.Correo.ToString() + Environment.NewLine;
                lblContactosGuardados.Text = lblContactosGuardados.Text + nuevalinea; 
            }
            else
            {
                MessageBox.Show("Se mostraron todos los contactos");
            }
        }

        private void txtContactos_TextChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(txtContactos.Text);
            cantidadpersonas= valor;
            registro = 0;
            arreglo = new Contacto[cantidadpersonas + 1];
        }
    }
}
