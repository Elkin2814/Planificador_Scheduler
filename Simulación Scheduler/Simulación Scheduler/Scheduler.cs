using Simulación_Scheduler.Control;
using System.Windows.Forms;

namespace Simulación_Scheduler
{
    public partial class Scheduler : Form
    {
        private ProgressBar progressBar;
        private Label ID;
        private Label lblEstado;
        private Label lblPorcentaje;
        private int idProceso = 0;

        public Scheduler(ProgressBar progressBar, Label ID, Label lblEstado, Label lblPorcentaje)
        {
            this.progressBar = progressBar;
            this.ID = ID;
            this.lblEstado = lblEstado;
            this.lblPorcentaje = lblPorcentaje;
        }

        private int indiceProceso = 0;
        List<Scheduler> procesos = new List<Scheduler>();


        public ProgressBar getProgressBar() { return progressBar; }
        public void setProgressBar(ProgressBar progressBar) { this.progressBar = progressBar; }

        public Label getLabelEstado() { return lblEstado; }
        public void setLabelEstado(Label lblEstado) { this.lblEstado = lblEstado; }

        public Label getLabelPorcentaje() { return lblPorcentaje; }
        public void setLabelPorcentaje(Label lblProcentaje) { this.lblPorcentaje = lblProcentaje; }


        
        public Scheduler()
        {
            InitializeComponent();
            cargarProcesos();
            //ejecutarProceso();
        }

        private void cargarProcesos()
        {
            for (int i = 0; i < 5; i++)
            {
                idProceso++;
                FlowLayoutPanel procesoPanel = new FlowLayoutPanel();
                procesoPanel.Width = panelProcesos.Width;
                procesoPanel.Height = 70;
                procesoPanel.BackColor = Color.FromArgb(0x23, 0x2b, 0x41);

                ProgressBar progressBar1 = new ProgressBar();
                progressBar1.Width = panelProcesos.Width;
                progressBar1.Dock = DockStyle.Top;
                progressBar1.Maximum = 100;
                progressBar = progressBar1;

                Label lblEstado1 = new Label();
                lblEstado1.Text = "";
                lblEstado1.Visible = false;
                lblEstado1.Dock = DockStyle.Right;
                lblEstado1.ForeColor = Color.White;
                lblEstado = lblEstado1;

                Label lblNombreProceso = new Label();
                lblNombreProceso.Text = "ID Proceso: ";
                lblNombreProceso.Dock = DockStyle.Top;
                lblNombreProceso.ForeColor = Color.White;

                Label lblID = new Label();
                lblID.Text = idProceso.ToString();
                lblID.Dock = DockStyle.Top;
                lblID.ForeColor = Color.White;

                Label lblprocentaje1 = new Label();
                lblprocentaje1.Text = "0 %";
                lblprocentaje1.Dock = DockStyle.Top;
                lblprocentaje1.ForeColor = Color.White;
                lblPorcentaje = lblprocentaje1;

                Scheduler scheduler = new Scheduler(progressBar1, lblID, lblEstado1, lblprocentaje1);
                procesos.Add(scheduler);


                procesoPanel.Controls.Add(progressBar);
                procesoPanel.Controls.Add(lblNombreProceso);
                procesoPanel.Controls.Add(lblID);
                procesoPanel.Controls.Add(lblPorcentaje);
                procesoPanel.Controls.Add(lblEstado);
                panelProcesos.Controls.Add(procesoPanel);
            }
            timerBarra.Start();

        }

        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {
            idProceso++;
            FlowLayoutPanel procesoPanel = new FlowLayoutPanel();
            procesoPanel.Width = panelProcesos.Width;
            procesoPanel.Height = 70;
            procesoPanel.BackColor = Color.FromArgb(0x23, 0x2b, 0x41);

            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.Width = panelProcesos.Width;
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Maximum = 100;
            progressBar = progressBar1;

            Label lblEstado1 = new Label();
            lblEstado1.Text = "";
            lblEstado1.Visible = false;
            lblEstado1.Dock = DockStyle.Right;
            lblEstado1.ForeColor = Color.White;
            lblEstado = lblEstado1;

            Label lblNombreProceso = new Label();
            lblNombreProceso.Text = "ID Proceso: ";
            lblNombreProceso.Dock = DockStyle.Top;
            lblNombreProceso.ForeColor = Color.White;

            Label lblID = new Label();
            lblID.Text = idProceso.ToString();
            lblID.Dock = DockStyle.Top;
            lblID.ForeColor = Color.White;

            Label lblprocentaje1 = new Label();
            lblprocentaje1.Text = "0 %";
            lblprocentaje1.Dock = DockStyle.Top;
            lblprocentaje1.ForeColor = Color.White;
            lblPorcentaje = lblprocentaje1;

            Scheduler scheduler = new Scheduler(progressBar1, lblID, lblEstado1, lblprocentaje1);
            procesos.Add(scheduler);

            procesoPanel.Controls.Add(progressBar);
            procesoPanel.Controls.Add(lblNombreProceso);
            procesoPanel.Controls.Add(lblID);
            procesoPanel.Controls.Add(lblPorcentaje);
            procesoPanel.Controls.Add(lblEstado);
            panelProcesos.Controls.Add(procesoPanel);
        }

        private void ejecutarProceso()
        {
            
                while (procesos[indiceProceso].progressBar.Value < 100)
                {
                    //procesos[indiceProceso].progressBar.Increment(1);
                }
            
        }

        public void probabilidadEstado()
        {

        }


        private void timerBarra_Tick(object sender, EventArgs e)
        {
            if (indiceProceso < procesos.Count)
            {
                Scheduler proceso = procesos[indiceProceso];
                ProgressBar progressBarActual = procesos[indiceProceso].progressBar;
                procesos[indiceProceso].progressBar.Increment(2);

                if (progressBarActual.Value == 100)
                {
                    proceso.lblEstado.Text = "Finalizado";
                    proceso.lblEstado.Visible = true;
                    indiceProceso++;
                }
                proceso.lblPorcentaje.Text = progressBarActual.Value + " %";
            }
            
            
            /*if (indiceProceso < procesos.Count)
            {
                //procesos[indiceProceso].progressBar.Increment(2);
                indiceProceso++;

                ProgressBar progressBarActual = procesos[indiceProceso].progressBar;

                if (progressBarActual.Value < progressBarActual.Maximum)
                {
                    // Si la barra de progreso actual no ha alcanzado el 100%, avanza
                    progressBarActual.Value++;
                }
                else
                {
                    // La barra de progreso actual ha alcanzado el 100%
                    // Incrementa el índice para pasar a la siguiente barra
                    indiceProceso++;

                    if (indiceProceso < procesos.Count)
                    {
                        // Reinicia la barra de progreso actual
                        procesos[indiceProceso].progressBar.Value = 0;
                    }
                    else
                    {
                        // Has llegado al final de la lista, detén el temporizador
                        timerBarra.Stop();
                    }
                }






            }

            //progressBar.Increment(2);
            
            
            */

        }
}
}