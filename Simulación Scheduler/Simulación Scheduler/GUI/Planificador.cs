using Simulación_Scheduler.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;
using Timer = System.Windows.Forms.Timer;

namespace Simulación_Scheduler.GUI
{
    public partial class Planificador : Form
    {
        public Planificador()
        {
            InitializeComponent();
        }
        VistaProcesador[] vistaProcesador;
        int idProceso = 0;
        List<Nucleo> listaNucleos = new List<Nucleo>();
        List<FlowLayoutPanel> listaPanel = new List<FlowLayoutPanel>();
        FlowLayoutPanel panelNucleos = new FlowLayoutPanel();
        FlowLayoutPanel panelProcesos = new FlowLayoutPanel();
        private Timer timer = new Timer();
        private Dictionary<int, ProgressBar> progressBarDictionary = new Dictionary<int, ProgressBar>();
        private Dictionary<int, Label> porcentajeLabelDictionary = new Dictionary<int, Label>();
        private List<Thread> nucleoThreads = new List<Thread>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNucleoId.Text) <= listaNucleos.Count)
            {
                idProceso++;
                FlowLayoutPanel panelSubProcesos = new FlowLayoutPanel();
                panelSubProcesos.Width = panelPrincipal.Width;
                panelSubProcesos.Height = 70;
                panelSubProcesos.BackColor = ColorTranslator.FromHtml("#2596be");

                ProgressBar progressBar = new ProgressBar();
                progressBar.Width = panelPrincipal.Width;
                progressBar.Dock = DockStyle.Top;
                progressBar.Maximum = 100;
                progressBarDictionary[idProceso] = progressBar;

                Label lblEstado = new Label();
                lblEstado.Text = "Preparado";
                lblEstado.Dock = DockStyle.Right;
                lblEstado.ForeColor = Color.White;

                Label lblNombreProceso = new Label();
                lblNombreProceso.Text = "ID Proceso: ";
                lblNombreProceso.Dock = DockStyle.Top;
                lblNombreProceso.ForeColor = Color.White;

                Label lblID = new Label();
                lblID.Text = idProceso.ToString();
                lblID.Dock = DockStyle.Top;
                lblID.ForeColor = Color.White;

                Label lblPorcentaje = new Label();
                lblPorcentaje.Text = "0 %";
                lblPorcentaje.Dock = DockStyle.Top;
                lblPorcentaje.ForeColor = Color.White;
                porcentajeLabelDictionary[idProceso] = lblPorcentaje;

                Proceso proceso = new Proceso(idProceso, progressBar, lblPorcentaje, lblEstado);

                Timer tiempo = new Timer();
                tiempo.Interval = 500;


                panelSubProcesos.Controls.Add(progressBar);
                panelSubProcesos.Controls.Add(lblNombreProceso);
                panelSubProcesos.Controls.Add(lblID);
                panelSubProcesos.Controls.Add(lblPorcentaje);
                panelSubProcesos.Controls.Add(lblEstado);

                int idNucleo = int.Parse(tbNucleoId.Text);

                foreach (Nucleo nucleo in listaNucleos)
                {
                    if (nucleo.getIdNucleo() == idNucleo)
                    {
                        //vistaProcesador[nucleo.getIdNucleo()].Panel.Controls.Add(panelSubProcesos);
                        nucleo.getFlowLayoutPanel().Controls.Add(panelSubProcesos);
                        nucleo.addProceso(proceso);
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idProceso = 0;
            panelPrincipal.Controls.Clear();
            int nucleos = int.Parse(tbNucleos.Text);
            vistaProcesador = new VistaProcesador[nucleos];

            for (int i = 0; i < vistaProcesador.Length; i++)
            {
                // Diseño
                FlowLayoutPanel panelNucleo = new FlowLayoutPanel();
                panelNucleo.Name = "flowLayoutPanel" + i + 1;
                panelNucleo.Width = panelPrincipal.Width;
                panelNucleo.Height = 350;
                panelNucleo.BackColor = ColorTranslator.FromHtml("#03102f");
                panelNucleo.AutoScroll = true;

                Label lblEstado1 = new Label();
                lblEstado1.Text = "null";
                lblEstado1.Visible = false;
                lblEstado1.Dock = DockStyle.Right;
                lblEstado1.ForeColor = Color.White;

                Label lblNombreProceso = new Label();
                lblNombreProceso.Text = "Núcleo ";
                lblNombreProceso.Dock = DockStyle.Top;
                lblNombreProceso.ForeColor = Color.White;

                Label lblID = new Label();
                lblID.Text = (i + 1).ToString();
                lblID.Dock = DockStyle.Top;
                lblID.ForeColor = Color.White;

                panelNucleo.Controls.Add(lblNombreProceso);
                panelNucleo.Controls.Add(lblID);
                //listaPanel.Add(panelNucleo);

                // Logica de creacion de nucleos
                List<Proceso> lista = new List<Proceso>();

                Nucleo nucleo = new Nucleo(i + 1, lista, panelNucleo);
                listaNucleos.Add(nucleo);
                nucleo.setFlowLayoutPanel(panelNucleo);
                panelPrincipal.Controls.Add(nucleo.getFlowLayoutPanel());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (listaNucleos.Count > 0)
            {
                Nucleo currentNucleo = listaNucleos[currentNucleoIndex];

                foreach (Proceso proceso in currentNucleo.getListaProcesos())
                {
                    ProgressBar progressBar = proceso.getProgressBar();
                    Label porcentajeLabel = proceso.getLabelPorcentaje();

                    Random random = new Random();
                    int incremento = random.Next(1, 10); 
                    int nuevoProgreso = progressBar.Value + incremento;

                    if (nuevoProgreso <= 100)
                    {
                        progressBar.Value = nuevoProgreso;
                        porcentajeLabel.Text = nuevoProgreso + " %";
                    }
                    else
                    {
                        progressBar.Value = 100;
                        porcentajeLabel.Text = "100 %";
                        proceso.setEstado("Completado");
                    }
                }

                currentNucleoIndex++;

                if (currentNucleoIndex >= listaNucleos.Count)
                {
                    currentNucleoIndex = 0;
                }
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (Nucleo nucleo in listaNucleos)
            {
                Thread nucleoThread = new Thread(() => EjecutarNucleo(nucleo));
                nucleoThreads.Add(nucleoThread);
                nucleoThread.Start();
            }
           
        }
        private int currentNucleoIndex = 0;
        private int currentProcessIndex = 0;
        private void ActualizarBarrasPrimerProceso()
        {
            if (listaNucleos.Count > 0)
            {
                Nucleo currentNucleo = listaNucleos[currentNucleoIndex];

                if (currentNucleo.getListaProcesos().Count > 0)
                {
                    Proceso primerProceso = currentNucleo.getListaProcesos()[0]; // Obtén el primer proceso

                    ProgressBar progressBar = primerProceso.getProgressBar();
                    Label porcentajeLabel = primerProceso.getLabelPorcentaje();

                    // Simula un progreso aleatorio (reemplaza esta lógica por la tuya)
                    Random random = new Random();
                    int incremento = random.Next(1, 10); // Incremento aleatorio entre 1 y 10
                    int nuevoProgreso = progressBar.Value + incremento;

                    if (nuevoProgreso <= 100)
                    {
                        progressBar.Value = nuevoProgreso;
                        porcentajeLabel.Text = nuevoProgreso + " %";
                    }
                    else
                    {
                        progressBar.Value = 100;
                        porcentajeLabel.Text = "100 %";
                    }
                }
            }
        }


        private void timerBarras_Tick(object sender, EventArgs e)
        {
        }

        private void EjecutarNucleo(Nucleo nucleo)
        {
            if (nucleo.getListaProcesos().Count > 0)
            {
                int totalProcesos = nucleo.getListaProcesos().Count;
                int procesoActualIndex = 0;

                while (true) 
                {
                    Proceso procesoActual = nucleo.getListaProcesos()[procesoActualIndex];
                    ProgressBar progressBar = procesoActual.getProgressBar();

                    Random random = new Random();
                    int incremento = random.Next(1, 10);
                    int nuevoProgreso = progressBar.Value + incremento;

                    int probabilidad = random.Next(1, 101); 

                    if (procesoActual.getLabelEstado().Text != "Finalizado")
                    {
                        if (probabilidad >= 1 && probabilidad < 90) 
                        {
                            procesoActual.getLabelEstado().Invoke((MethodInvoker)delegate
                            {
                                procesoActual.getLabelEstado().Text = "Preparado";
                            });
                        }
                        else if (probabilidad > 90 && probabilidad <= 97) 
                        {
                            procesoActual.getLabelEstado().Invoke((MethodInvoker)delegate
                            {
                                procesoActual.getLabelEstado().Text = "Bloqueado";
                            });
                        }
                        else 
                        {
                            procesoActual.getLabelEstado().Invoke((MethodInvoker)delegate
                            {
                                //procesoActual.getLabelEstado().Text = "Finalizado";
                            });
                        }

                        if (procesoActual.getLabelEstado().Text != "Bloqueado")
                        {
                            progressBar.Invoke((MethodInvoker)delegate
                            {
                                if (nuevoProgreso <= 100)
                                {
                                    progressBar.Value = nuevoProgreso;
                                    procesoActual.getLabelPorcentaje().Text = nuevoProgreso + " %";

                                }
                                else
                                {
                                    progressBar.Value = 100;
                                    procesoActual.getLabelPorcentaje().Text = "100 %";
                                    procesoActual.setEstado("Completado");
                                    procesoActual.getLabelEstado().Text = "Finalizado";
                                }
                            });
                            Thread.Sleep(500); 
                        }

                    }
                    procesoActualIndex++; 

                    if (procesoActualIndex >= totalProcesos)
                    {
                        procesoActualIndex = 0;
                    }
                }
            }
        }

    }
}

