using Asistencia.UI.Consultas;
using Asistencia.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistencia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAsistenciasForm ra = new RAsistenciasForm();
            ra.MdiParent = this;
            ra.Show();
        }

        private void RegistroDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAsignaturasForm ras = new RAsignaturasForm();
            ras.MdiParent = this;
            ras.Show();
        }

        private void RegistroDeEstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            REstudiantesForm re = new REstudiantesForm();
            re.MdiParent = this;
            re.Show();
        }

        private void ConsultaDeAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAsistenciasForm ca = new CAsistenciasForm();
            ca.MdiParent = this;
            ca.Show();
        }
    }
}
