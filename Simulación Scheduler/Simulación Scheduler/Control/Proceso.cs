using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_Scheduler.Control
{
    internal class Proceso
    {
        private int ID;
        private string estado;
        private string nombre;
        private int tiempoLlegada;
        private int tiempoEjecucion;
        private int prioridad;

        public Proceso(int id, string nombre, int tiempoLlegada, int tiempoEjecucion, int prioridad)
        {
            this.ID = id;
            this.nombre = nombre;
            this.tiempoLlegada = tiempoLlegada;
            this.tiempoEjecucion = tiempoEjecucion;
            this.prioridad = prioridad;
            this.estado = "Listo";
        }

        public int getId() { return ID; }
        public void setId(int id) { ID = id;}

        public string getEstado() {  return estado; }
        public void setEstado(string estado) { this.estado = estado; }

        public string getNombre() { return nombre; }
        public void setNombre(string nombre) { this.nombre = nombre; }

        public int getTiempoLlegada() {  return tiempoLlegada; }
        public void setTiempoLlegada(int tiempoLlegada) { this.tiempoLlegada = tiempoLlegada; }

        public int getTiempoEjecucion() { return tiempoEjecucion; }
        public void setTiempoEjecucion(int tiempoEjecucion) { this.tiempoEjecucion = tiempoEjecucion; }

        public int getPrioridad() { return prioridad; }
        public void setPrioridad(int prioridad) { this.prioridad = prioridad; }

    }

   

}
