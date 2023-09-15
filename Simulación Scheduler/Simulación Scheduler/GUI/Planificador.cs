using Simulación_Scheduler.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace Simulación_Scheduler.GUI
{
    public partial class Planificador : Form
    {
        public Planificador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proceso proceso = new Proceso(1);
            Proceso proceso2 = new Proceso(2);
            Proceso proceso3 = new Proceso(3);

            List<Proceso> lista = new List<Proceso>();
            lista.Add(proceso);
            lista.Add(proceso2);
            lista.Add(proceso3);

            Nucleo nucleo1 = new Nucleo(1, lista);

            FlowLayoutPanel panelNucleo = new FlowLayoutPanel();
            panelNucleo.Width = panelPrincipal.Width;
            panelNucleo.Height = 70;
            panelNucleo.BackColor = Color.FromArgb(0x23, 0x2b, 0x41);

            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.Width = panelPrincipal.Width;
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Maximum = 100;

            Label lblEstado1 = new Label();
            lblEstado1.Text = "Preparado";
            lblEstado1.Visible = false;
            lblEstado1.Dock = DockStyle.Right;
            lblEstado1.ForeColor = Color.White;

            Label lblNombreProceso = new Label();
            lblNombreProceso.Text = "ID Proceso: ";
            lblNombreProceso.Dock = DockStyle.Top;
            lblNombreProceso.ForeColor = Color.White;

            Label lblID = new Label();
            lblID.Text = proceso.getId().ToString();
            lblID.Dock = DockStyle.Top;
            lblID.ForeColor = Color.White;

            Label lblprocentaje1 = new Label();
            lblprocentaje1.Text = "0 %";
            lblprocentaje1.Dock = DockStyle.Top;
            lblprocentaje1.ForeColor = Color.White;

            panelNucleo.Controls.Add(progressBar1);
            panelNucleo.Controls.Add(lblNombreProceso);
            panelNucleo.Controls.Add(lblID);
            panelNucleo.Controls.Add(lblprocentaje1);
            panelNucleo.Controls.Add(lblEstado1);
            panelPrincipal.Controls.Add(panelNucleo);


        }
    }
}
