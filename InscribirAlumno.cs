using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2___Guía4_MM200149
{
    public partial class InscribirAlumno : frmdiseñobasico
    {
        public InscribirAlumno()
        {
            InitializeComponent();
        }

        private void InscribirAlumno_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private List<Ingenieria> Ingenierias = new List<Ingenieria>();
        private int edit_indice = -1;

        private void actualizargrid()
        {
            dtgvalumno.DataSource = null;
        }

    }
}
