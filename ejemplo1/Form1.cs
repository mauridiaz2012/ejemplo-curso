using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
            txtNombre.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Magenta");
            cboColorFavorito.Items.Add("Violeta");
            cboColorFavorito.Items.Add("Amarillo");

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //Operador ternario si es verdadero devuelve la primera cadena, sino la segunda
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el Chocolate" : "Odia el Chocolate";
            
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha de Nac: " + fecha + ", " + mensaje);

        }
    }
}
