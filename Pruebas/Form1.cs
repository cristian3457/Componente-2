using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componente_Datos;

namespace Pruebas
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.setNombre("JUAN PEREZ NUÑEZ");
            userControl11.setReseña("ES UN TEMA MUY INTERESANTE");
            userControl11.SetPonencias("ES UN ALUMNO MUY ATENTO Y AMABLE");
            userControl11.SetEscolaridad("MAESTRIA");
            userControl11.SetInvestigacion("ORIGEN DEL UNIVERSO");
            userControl12.setNombre("AMPARO MORALEZ MARTINEZ");
            userControl12.setReseña("ES UN TEMA MUY COMPLEJO");
            userControl12.SetPonencias("ES UN TEMA NUEVO");
            userControl12.SetEscolaridad("DOCTORADO");
            userControl12.SetInvestigacion("ORIGEN DE LA VIDA");
            userControl13.setNombre("JESUS ALCANTAR RAMIREZ");
            userControl13.setReseña("ES UN TEMA MUY INTERESANTE Y COMPLEJO");
            userControl13.SetPonencias("ES MUY JOVEN E INTELIGENTE");
            userControl13.SetEscolaridad("MAESTRIA");
            userControl13.SetInvestigacion("FISICA CUANTICA");
            userControl14.setNombre("OMAR ALVAREZ PEREZ");
            userControl14.setReseña("ES UN TEMA MUY NUEVO E INTERESANTE");
            userControl14.SetPonencias("ES UN ESTUDIANTE MUY DESTACADO ");
            userControl14.SetEscolaridad("DOCTORADO");
            userControl14.SetInvestigacion("TRANSFORMADAS DE LAPLACE");
            userControl15.setNombre("SERGIO HUERAMO HUERAMO");
            userControl15.setReseña("ES UN TEMA MUY EXCITANTE");
            userControl15.SetPonencias("ES MUY ENTUSIASTA");
            userControl15.SetEscolaridad("MAESTRIA- DOCTORADO");
            userControl15.SetInvestigacion("ELECTRONICA DIGITAL");
            userControl16.setNombre("LUIS ALVAREZ MURILLO");
            userControl16.setReseña("ES UN TEMA MUY NUEVO ");
            userControl16.SetPonencias("ES UN ESTUDIANTE MUY APLICADO");
            userControl16.SetEscolaridad("DOCTORADO");
            userControl16.SetInvestigacion("ARDUINO Y LAVIEW");

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
