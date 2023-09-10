namespace Simulación_Scheduler
{
    partial class Scheduler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelPrincipal = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnAgregarProceso = new Button();
            panelTabla = new Panel();
            panelProcesos = new FlowLayoutPanel();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            timerBarra = new System.Windows.Forms.Timer(components);
            panelPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelTabla.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(4, 6, 20);
            panelPrincipal.Controls.Add(panel2);
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.ForeColor = Color.Coral;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1257, 706);
            panelPrincipal.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 40, 53);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panelTabla);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(1257, 609);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAgregarProceso);
            panel3.Location = new Point(542, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(715, 79);
            panel3.TabIndex = 0;
            // 
            // btnAgregarProceso
            // 
            btnAgregarProceso.BackColor = Color.FromArgb(180, 195, 189);
            btnAgregarProceso.FlatStyle = FlatStyle.Flat;
            btnAgregarProceso.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProceso.ForeColor = Color.FromArgb(5, 2, 28);
            btnAgregarProceso.Location = new Point(21, 16);
            btnAgregarProceso.Name = "btnAgregarProceso";
            btnAgregarProceso.Size = new Size(227, 44);
            btnAgregarProceso.TabIndex = 3;
            btnAgregarProceso.Text = "Agregar Proceso";
            btnAgregarProceso.UseVisualStyleBackColor = false;
            btnAgregarProceso.Click += btnAgregarProceso_Click;
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(73, 77, 99);
            panelTabla.Controls.Add(panelProcesos);
            panelTabla.Dock = DockStyle.Left;
            panelTabla.Location = new Point(0, 0);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(542, 609);
            panelTabla.TabIndex = 0;
            // 
            // panelProcesos
            // 
            panelProcesos.Dock = DockStyle.Fill;
            panelProcesos.Location = new Point(0, 0);
            panelProcesos.Name = "panelProcesos";
            panelProcesos.Size = new Size(542, 609);
            panelProcesos.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 40, 53);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 78);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(328, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(194, 21);
            label2.Name = "label2";
            label2.Size = new Size(116, 29);
            label2.TabIndex = 1;
            label2.Text = "Algoritmo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 0;
            label1.Text = "Opciones:";
            // 
            // timerBarra
            // 
            timerBarra.Tick += timerBarra_Tick;
            // 
            // Scheduler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 706);
            Controls.Add(panelPrincipal);
            Name = "Scheduler";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelTabla.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnAgregarProceso;
        private Panel panelTabla;
        private FlowLayoutPanel panelProcesos;
        private System.Windows.Forms.Timer timerBarra;
    }
}