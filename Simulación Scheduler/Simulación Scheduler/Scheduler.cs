using System.Windows.Forms;

namespace Simulación_Scheduler
{
    public partial class Scheduler : Form
    {
        private ProgressBar progressBar;
        private Label lblEstado;
        private Label lblProcentaje;

        List<ProgressBar> barrasDeProgreso = new List<ProgressBar>();


        public ProgressBar getProgressBar() { return progressBar; }
        public void setProgressBar(ProgressBar progressBar) { this.progressBar = progressBar; }

        public Label getLabelEstado() { return lblEstado; }
        public void setLabelEstado(Label lblEstado) { this.lblEstado = lblEstado; }

        public Label getLabelPorcentaje() { return lblProcentaje; }
        public void setLabelPorcentaje(Label lblProcentaje) { this.lblProcentaje = lblProcentaje; }

        public Scheduler()
        {
            InitializeComponent();
        }

        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {
            Panel procesoPanel = new Panel();
            procesoPanel.Width = panelProcesos.Width;
            procesoPanel.Height = 70;
            procesoPanel.BackColor = Color.FromArgb(0x23, 0x2b, 0x41);

            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Maximum = 100;
            progressBar = progressBar1;

            barrasDeProgreso.Add(progressBar1);

            timerBarra.Start();

            Label lblEstado1 = new Label();
            lblEstado1.Text = "Finalizado";
            lblEstado1.Visible = false;
            lblEstado1.Dock = DockStyle.Right;
            lblEstado1.ForeColor = Color.White;
            lblEstado = lblEstado1;

            Label lblNombreProceso = new Label();
            lblNombreProceso.Text = "Proceso Prototipo";
            lblNombreProceso.Dock = DockStyle.Top;
            lblNombreProceso.ForeColor = Color.White;

            Label lblprocentaje1 = new Label();
            lblprocentaje1.Text = "0 %";
            lblprocentaje1.Dock = DockStyle.Top;
            lblprocentaje1.ForeColor = Color.White;
            lblProcentaje = lblprocentaje1;


            procesoPanel.Controls.Add(lblNombreProceso);
            procesoPanel.Controls.Add(lblProcentaje);
            procesoPanel.Controls.Add(progressBar);
            procesoPanel.Controls.Add(lblEstado);

            panelProcesos.Controls.Add(procesoPanel);
        }

        private void timerBarra_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);

            if (progressBar.Value == 100)
            {
                lblEstado.Visible = true;
            }
            lblProcentaje.Text = progressBar.Value + " %";
        }
    }
}