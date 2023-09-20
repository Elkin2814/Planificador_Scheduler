using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_Scheduler.Control
{
    internal class Proceso
    {
        private int idProceso;
        private string estado;
        private string tiempoLlegada;
        private string tiempoEjecucion;
        private string prioridad;
        private ProgressBar progressBar;
        private Label lblPorcentaje;
        private Label lblEstado;

        public Proceso(int idProceso, ProgressBar progressBar, Label lblPorcentaje, Label lblEstado)
        {
            this.idProceso = idProceso;
            /*this.tiempoLlegada = tiempoLlegada;
            this.tiempoEjecucion = tiempoEjecucion;
            this.prioridad = prioridad;*/
            this.estado = "Preparado";
            this.progressBar = progressBar;
            this.lblPorcentaje = lblPorcentaje;
            this.lblEstado = lblEstado;
        }

        public Proceso() { }

        public int getId() { return idProceso; }
        public void setId(int idProceso) { this.idProceso = idProceso; }

        public string getEstado() {  return estado; }
        public void setEstado(string estado) { this.estado = estado; }

        public string getTiempoLlegada() {  return tiempoLlegada; }
        public void setTiempoLlegada(string tiempoLlegada) { this.tiempoLlegada = tiempoLlegada; }

        public string getTiempoEjecucion() { return tiempoEjecucion; }
        public void setTiempoEjecucion(string tiempoEjecucion) { this.tiempoEjecucion = tiempoEjecucion; }

        public string getPrioridad() { return prioridad; }
        public void setPrioridad(string prioridad) { this.prioridad = prioridad; }

        public ProgressBar getProgressBar() { return progressBar; }
        public void setProgressBar(ProgressBar progressBar) { this.progressBar = progressBar; }

        public Label getLabelPorcentaje() { return lblPorcentaje; }
        public void setLabelPorcentaje(Label lblProcentaje) { this.lblPorcentaje = lblProcentaje; }

        public Label getLabelEstado() { return lblEstado; }
        public void setLabelEstado(Label lblEstado) { this.lblEstado = lblEstado; }
    }



}
