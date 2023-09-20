namespace Simulación_Scheduler.GUI
{
    partial class VistaProcesador
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblN_Nucleo = new Label();
            flpProcesos = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 66, 99);
            panel1.Controls.Add(lblN_Nucleo);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 176);
            panel1.TabIndex = 0;
            // 
            // lblN_Nucleo
            // 
            lblN_Nucleo.AutoSize = true;
            lblN_Nucleo.Font = new Font("GOST Common", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblN_Nucleo.ForeColor = SystemColors.Control;
            lblN_Nucleo.Location = new Point(35, 73);
            lblN_Nucleo.Name = "lblN_Nucleo";
            lblN_Nucleo.Size = new Size(84, 28);
            lblN_Nucleo.TabIndex = 0;
            lblN_Nucleo.Text = "Nucleo";
            // 
            // flpProcesos
            // 
            flpProcesos.BackColor = Color.FromArgb(66, 134, 132);
            flpProcesos.Location = new Point(206, 12);
            flpProcesos.Name = "flpProcesos";
            flpProcesos.Size = new Size(619, 176);
            flpProcesos.TabIndex = 1;
            // 
            // VistaProcesador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 57, 77);
            Controls.Add(flpProcesos);
            Controls.Add(panel1);
            Name = "VistaProcesador";
            Size = new Size(842, 204);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblN_Nucleo;
        private FlowLayoutPanel flpProcesos;
    }
}
