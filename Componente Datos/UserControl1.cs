using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componente_Datos;

namespace Componente_Datos

{

   
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            txtInvestigacion.ReadOnly = true;
            txtEscolaridad.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtPonencias.ReadOnly = true;
            txtReseña.ReadOnly = true;
        }
        
      
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
       public void setNombre(String cad)
        {
            txtNombre.Text=cad;
        }
        public void setReseña(String reseña)
        {
            txtReseña.Text = reseña;
        }
        public void SetEscolaridad(String escolaridad)
        {
            txtEscolaridad.Text = escolaridad;
        }
        public void SetPonencias( String ponencias)
        {
            txtPonencias.Text = ponencias;
        }
        public void SetInvestigacion(String investigacion)
        {
            txtInvestigacion.Text = investigacion;
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
