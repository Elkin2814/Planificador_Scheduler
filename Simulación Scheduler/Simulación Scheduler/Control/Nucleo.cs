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
        private FlowLayoutPanel flowLayoutPanel;

        public Nucleo() { }
        public Nucleo(int idNucleo, List<Proceso> lista, FlowLayoutPanel flowLayoutPanel) {
            this.idNucleo = idNucleo;
            this.lista = lista;
            this.flowLayoutPanel = flowLayoutPanel;
        }
        
        public int getIdNucleo()
        {
            return idNucleo;
        }

        public void setIdNucleo(int idNucleo)
        {
            this.idNucleo=idNucleo;
        }

        public List<Proceso> getListaProcesos() { return lista; }

        public void setListaProcesos(List<Proceso> lista) { this.lista = lista; }

        public FlowLayoutPanel getFlowLayoutPanel() {  return flowLayoutPanel; }

        public void setFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel) { this.flowLayoutPanel = flowLayoutPanel;}

        public void addProceso(Proceso proceso)
        {
            lista.Add(proceso);
        }

        public void addProceso_Nucleo(Proceso proceso, int idNucleo)
        {

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
