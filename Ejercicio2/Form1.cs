using Evaluacion.agregar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        //Se almacena los estudiantes agregados
        private List<Student> estudiantes;

        public Form1()
        {
            InitializeComponent();
            // Se Inicializa la lista de estudiantes
            estudiantes = new List<Student>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarNombresLargos()
        {
            // Limpiamos la lista visual antes de actualizarla.
            lstStudent.Items.Clear();

            // Recorremos la lista de estudiantes y mostramos solo los nombres largos.
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Student estudiante = estudiantes[i];
                if (estudiante.TieneNombreLargo())
                {
                    lstStudent.Items.Add(estudiante.NombreCompleto); // Agregamos el nombre al ListBox.
                }

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string nombreCompleto = txtName.Text.Trim();

            // Se crea un nuevo estudiante.
            Student estudiante = new Student(nombreCompleto);
            estudiantes.Add(estudiante);

            txtName.Clear();
            MostrarNombresLargos();
        }
    }
}