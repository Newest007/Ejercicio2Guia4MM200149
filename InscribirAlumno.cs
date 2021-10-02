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

            Ingenieria ing = new Ingenieria();
            ing.Nombre = txtnombre.Text;
            ing.Apellido = txtapellido.Text;
            ing.NumCarnet = txtcarnet.Text;
            ing.NlvEstudios = txtestudios.Text;
            ing.NombreUniversidad = txtuniversidad.Text;
            ing.Carrera = txtcarrera.Text;
            ing.MateriasIncritas = txtmaterias.Text;
            ing.Nota1 = float.Parse(txtnota1.Text);
            ing.Nota2 = float.Parse(txtnota2.Text);
            ing.Nota3 = float.Parse(txtnota3.Text);
            ing.Cum = float.Parse(txtcum.Text);
            ing.NombreProyecto = txtproyecto.Text;
            ing.TotalHoras = txtcumplir.Text;
            ing.HorasCompletadas = txtcumplidas.Text;

            if(edit_indice >-1)
            {
                Ingenierias[edit_indice] = ing;
                edit_indice = -1;
            }

            else
            {
                Ingenierias.Add(ing);
            }

            actualizargrid();
            MessageBox.Show("Los datos se han añadido correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtnombre.Clear();
            txtapellido.Clear();
            txtcarnet.Clear();
            txtestudios.Clear();
            txtuniversidad.Clear();
            txtcarrera.Clear();
            txtmaterias.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtcum.Clear();
            txtproyecto.Clear();
            txtcumplir.Clear();
            txtcumplidas.Clear();


        }


        private List<Ingenieria> Ingenierias = new List<Ingenieria>();
        private int edit_indice = -1;

        private void actualizargrid()
        {
            dtgvalumno.DataSource = null;
            dtgvalumno.DataSource = Ingenierias;
        }

        private void dtgvalumno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvalumno_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dtgvalumno_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dtgvalumno.SelectedRows[0];
            int pos = dtgvalumno.Rows.IndexOf(seleccion);
            edit_indice = pos;

            Ingenieria ing = Ingenierias[pos];

            txtnombre.Text = ing.Nombre;
            txtapellido.Text = ing.Apellido;
            txtcarnet.Text = ing.NumCarnet;
            txtestudios.Text = ing.NlvEstudios;
            txtuniversidad.Text = ing.NombreUniversidad;
            txtcarrera.Text = ing.Carrera;
            txtmaterias.Text = ing.MateriasIncritas;
            txtnota1.Text = Convert.ToString(ing.Nota1);
            txtnota2.Text = Convert.ToString(ing.Nota2);
            txtnota3.Text = Convert.ToString(ing.Nota3);
            txtcum.Text = Convert.ToString(ing.Cum);
            txtproyecto.Text = ing.NombreProyecto;
            txtcumplir.Text = ing.TotalHoras;
            txtcumplidas.Text = ing.HorasCompletadas;

        }
    }
}
