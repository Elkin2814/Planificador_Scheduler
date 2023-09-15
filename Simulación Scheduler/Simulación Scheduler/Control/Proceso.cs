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

        public Proceso(int idProceso)
        {
            this.idProceso = idProceso;
            /*this.tiempoLlegada = tiempoLlegada;
            this.tiempoEjecucion = tiempoEjecucion;
            this.prioridad = prioridad;*/
            this.estado = "Preparado";
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

    }

   

}
