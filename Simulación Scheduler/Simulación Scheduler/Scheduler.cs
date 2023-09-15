using Simulación_Scheduler.Control;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;

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
        List<Scheduler> listaProcesos = new List<Scheduler>();
        List<Scheduler> listaProceso2 = new List<Scheduler>();
        //Proceso(id, string tiempoLlegada, string tiempoEjecucion, string prioridad)

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
        }

        private void cargarProcesos()
        {
            for (int i = 0; i < 7; i++)
            {
                idProceso++;
                FlowLayoutPanel panelSubProcesos = new FlowLayoutPanel();
                panelSubProcesos.Width = panelProceso1.Width;
                panelSubProcesos.Height = 70;
                panelSubProcesos.BackColor = Color.FromArgb(0x23, 0x2b, 0x41);

                ProgressBar progressBar1 = new ProgressBar();
                progressBar1.Width = panelProceso1.Width;
                progressBar1.Dock = DockStyle.Top;
                progressBar1.Maximum = 100;
                progressBar = progressBar1;

                Label lblEstado1 = new Label();
                lblEstado1.Text = "Preparado";
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
                listaProcesos.Add(scheduler);
                listaProceso2.Add(scheduler);

                panelSubProcesos.Controls.Add(progressBar);
                panelSubProcesos.Controls.Add(lblNombreProceso);
                panelSubProcesos.Controls.Add(lblID);
                panelSubProcesos.Controls.Add(lblPorcentaje);
                panelSubProcesos.Controls.Add(lblEstado);
                panelProceso1.Controls.Add(panelSubProcesos);
            }
            timerBarra.Start();

        }

        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {
            idProceso++;
            FlowLayoutPanel panelSubProcesos = new FlowLayoutPanel();
            panelSubProcesos.Width = panelProceso1.Width;
            panelSubProcesos.Height = 70;
            panelSubProcesos.BackColor = Color.FromArgb(0x23, 0x2b, 0x41);

            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.Width = panelProceso1.Width;
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Maximum = 100;
            progressBar = progressBar1;

            Label lblEstado1 = new Label();
            lblEstado1.Text = "Preparado";
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
            listaProcesos.Add(scheduler);
            listaProceso2.Add(scheduler);

            panelSubProcesos.Controls.Add(progressBar);
            panelSubProcesos.Controls.Add(lblNombreProceso);
            panelSubProcesos.Controls.Add(lblID);
            panelSubProcesos.Controls.Add(lblPorcentaje);
            panelSubProcesos.Controls.Add(lblEstado);
            panelProceso1.Controls.Add(panelSubProcesos);

            timerBarra.Start();
        }


        private int procesoActivoIndex = -1;
        private Random random = new Random();

        private int indiceProgresoActual = 0;

        private void EjecutarProcesos(List<Scheduler> procesosAsignados)
        {
            foreach (Scheduler proceso in procesosAsignados)
            {
                for (int i = 0; i <= 100; i++)
                {
                    proceso.progressBar.Invoke((MethodInvoker)(() => proceso.progressBar.Value = i));
                    proceso.lblPorcentaje.Invoke((MethodInvoker)(() => proceso.lblPorcentaje.Text = i + "%"));

                    Thread.Sleep(50);
                }
            }
        }

        private Dictionary<Scheduler, int> tiempoBloqueo = new Dictionary<Scheduler, int>();

        private void timerBarra_Tick(object sender, EventArgs e)
        {
            
            foreach (Scheduler proceso in listaProceso2)
            {
              
                int probabilidad = random.Next(1, 101);
                proceso.lblEstado.Visible = true;
                ProgressBar progressBarActual = proceso.progressBar;
                if (proceso.lblEstado.Text != "Finalizado")
                {
                    if (procesoActivoIndex == -1)
                    {
                        proceso.lblEstado.Text = "Activo";
                        procesoActivoIndex = 0;
                    }
                    else if (procesoActivoIndex == listaProceso2.IndexOf(proceso))
                    {
                        proceso.lblEstado.Text = "Activo";

                        if (probabilidad < 90)
                        {
                            //proceso.lblEstado.Text = "Preparado";
                        }
                        else if (probabilidad >= 90 && probabilidad < 97)
                        {
                            proceso.lblEstado.Text = "Bloqueado";

                            // Incrementa el tiempo de bloqueo para este proceso
                            if (!tiempoBloqueo.ContainsKey(proceso))
                            {
                                tiempoBloqueo[proceso] = 1;
                            }
                            else
                            {
                                tiempoBloqueo[proceso]++;
                            }

                            if (tiempoBloqueo[proceso] >= 5)
                            {
                                proceso.lblEstado.Text = "Preparado";
                                tiempoBloqueo.Remove(proceso); // Elimina el registro de tiempo de bloqueo
                            }

                            procesoActivoIndex = (procesoActivoIndex + 1) % listaProceso2.Count;
                        }
                        else
                        {
                            procesoActivoIndex = (procesoActivoIndex + 1) % listaProceso2.Count;
                        }
                        progressBarActual.Increment(2);

                        if (progressBarActual.Value == 100)
                        {
                            proceso.lblEstado.Text = "Finalizado";
                            proceso.lblPorcentaje.Text = "100 %";

                            int siguienteProcesoIndex = (procesoActivoIndex + 1) % listaProceso2.Count;
                            while (listaProceso2[siguienteProcesoIndex].lblEstado.Text != "Preparado")
                            {
                                siguienteProcesoIndex = (siguienteProcesoIndex + 1) % listaProceso2.Count;
                            }

                            procesoActivoIndex = siguienteProcesoIndex;
                            listaProceso2[procesoActivoIndex].Text = "Activo";
                        }
                        else
                        {
                            proceso.lblPorcentaje.Text = progressBarActual.Value + " %";
                        }

                    }
                    else
                    {
                        proceso.lblEstado.Text = "Preparado";
                       
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelProcesos.Controls.Clear();
            int numeroPaneles = int.Parse(comboBox1.SelectedItem.ToString());

            int procesosPorPanel = listaProcesos.Count / numeroPaneles;
            int procesosExtras = listaProcesos.Count % numeroPaneles;

            int indiceInicio = 0;

            List<Thread> listaHilos = new List<Thread>();

            for (int i = 0; i < numeroPaneles; i++)
            {
                Label label = new Label();
                label.ForeColor = Color.Black;
                label.Text = "NUCLEO " + (i + 1);

                FlowLayoutPanel nuevoPanel = new FlowLayoutPanel();
                nuevoPanel.Name = "flowLayoutPanel" + i;
                nuevoPanel.BackColor = Color.Gray;
                nuevoPanel.Height = 250;
                nuevoPanel.Width = panelProcesos.Width;
                nuevoPanel.Controls.Add(label);
                panelProcesos.Controls.Add(nuevoPanel);

                int procesosAsignar = procesosPorPanel;
                if (i < procesosExtras)
                {
                    procesosAsignar++;
                }

                List<Scheduler> procesosAsignados = listaProcesos.GetRange(indiceInicio, procesosAsignar);
                MostrarProcesosEnPanel(nuevoPanel, procesosAsignados);

                Thread hilo = new Thread(() => EjecutarProcesos(procesosAsignados));
                listaHilos.Add(hilo);
                hilo.Start();

                indiceInicio += procesosAsignar;
            }

        }

        private void MostrarProcesosEnPanel(FlowLayoutPanel panel, List<Scheduler> procesosAsignados)
        {
            foreach (Scheduler proceso in procesosAsignados)
            {
                Label label = new Label();
                label.ForeColor = Color.Black;
                label.Text = "Estado: ";
                proceso.lblEstado.Visible = true;
                proceso.progressBar.Value = 0;
                panel.Controls.Add(proceso.progressBar);
                panel.Controls.Add(label);
                panel.Controls.Add(proceso.lblEstado);
                panel.Controls.Add(proceso.lblPorcentaje);
            }
        }
    }
}
