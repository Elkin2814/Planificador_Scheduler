using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_Scheduler.Control
{
    internal class Nucleo
    {
        private int idNucleo;
        private List<Proceso> lista;
        public Nucleo(int idNucleo, List<Proceso> lista) {
            this.idNucleo = idNucleo;
            this.lista = lista;
        }
        public List<Proceso> getListaProcesos() {return lista; }
        public int getIdNucleo()
        {
            return idNucleo;
        }

        public void setIdNucleo(int idNucleo)
        {
            this.idNucleo=idNucleo;
        }

        public void setListaProcesos(List<Proceso> lista) { this.lista = lista; }

        public void addProceso(Proceso proceso)
        {
            lista.Add(proceso);
        }

        public void moverProceso(int indice)
        {
            if (indice >= 0 && indice < lista.Count)
            {
                Proceso proceso = lista[indice];
                lista.RemoveAt(indice);
                lista.Add(proceso);
            }
            else
            {
                Console.WriteLine("Fuera de rango.");
            }
        }

    }
}
