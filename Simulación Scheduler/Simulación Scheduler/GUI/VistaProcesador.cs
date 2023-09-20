using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulación_Scheduler.GUI
{
    public partial class VistaProcesador : UserControl
    {
        public VistaProcesador()
        {
            InitializeComponent();
        }

        #region Properties
        private string _nucleo;
        private int _idNucleo;
        private FlowLayoutPanel _panel;

        [Category("Custon Props")]
        public string Nucleo
        {
            get { return _nucleo; }
            set { _nucleo = value; lblN_Nucleo.Text = value; }
        }
        
        [Category("Custon Props")]
        public int IdNucleo
        {
            get { return _idNucleo; }
            set { _idNucleo = value; }
        }

        [Category("Custon Props")]
        public FlowLayoutPanel Panel
        {
            get { return _panel; }
            set { _panel = value; flpProcesos = value; }
        }
        #endregion
    }
}
