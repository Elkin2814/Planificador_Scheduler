namespace Simulación_Scheduler.GUI
{
    partial class Planificador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            panelPrincipal = new FlowLayoutPanel();
            panel3 = new Panel();
            btnStart = new Button();
            tbNucleoId = new TextBox();
            label2 = new Label();
            tbNucleos = new TextBox();
            label1 = new Label();
            btnFijarNucleo = new Button();
            btnAddProceso = new Button();
            label4 = new Label();
            timerBarras = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 6, 6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 853);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 57, 77);
            panel2.Controls.Add(panelPrincipal);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1382, 786);
            panel2.TabIndex = 8;
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoScroll = true;
            panelPrincipal.BackColor = Color.FromArgb(31, 29, 40);
            panelPrincipal.Dock = DockStyle.Right;
            panelPrincipal.Location = new Point(346, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1036, 786);
            panelPrincipal.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 29, 40);
            panel3.Controls.Add(btnStart);
            panel3.Controls.Add(tbNucleoId);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(tbNucleos);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnFijarNucleo);
            panel3.Controls.Add(btnAddProceso);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 786);
            panel3.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(48, 90, 88);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(18, 520);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(206, 46);
            btnStart.TabIndex = 6;
            btnStart.Text = "Iniciar Simulación";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // tbNucleoId
            // 
            tbNucleoId.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbNucleoId.Location = new Point(18, 312);
            tbNucleoId.Name = "tbNucleoId";
            tbNucleoId.Size = new Size(61, 38);
            tbNucleoId.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 258);
            label2.Name = "label2";
            label2.Size = new Size(295, 31);
            label2.TabIndex = 4;
            label2.Text = "Agregar Proceso A Nucleo:";
            // 
            // tbNucleos
            // 
            tbNucleos.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbNucleos.Location = new Point(180, 50);
            tbNucleos.Name = "tbNucleos";
            tbNucleos.Size = new Size(44, 38);
            tbNucleos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 2;
            label1.Text = "N° Nucleos:";
            // 
            // btnFijarNucleo
            // 
            btnFijarNucleo.BackColor = Color.FromArgb(48, 90, 88);
            btnFijarNucleo.FlatAppearance.BorderSize = 0;
            btnFijarNucleo.FlatStyle = FlatStyle.Flat;
            btnFijarNucleo.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFijarNucleo.ForeColor = SystemColors.Control;
            btnFijarNucleo.Location = new Point(18, 112);
            btnFijarNucleo.Name = "btnFijarNucleo";
            btnFijarNucleo.Size = new Size(206, 46);
            btnFijarNucleo.TabIndex = 1;
            btnFijarNucleo.Text = "Fijar Nucleos";
            btnFijarNucleo.UseVisualStyleBackColor = false;
            btnFijarNucleo.Click += button2_Click;
            // 
            // btnAddProceso
            // 
            btnAddProceso.BackColor = Color.FromArgb(48, 90, 88);
            btnAddProceso.FlatAppearance.BorderSize = 0;
            btnAddProceso.FlatStyle = FlatStyle.Flat;
            btnAddProceso.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProceso.ForeColor = SystemColors.Control;
            btnAddProceso.Location = new Point(18, 371);
            btnAddProceso.Name = "btnAddProceso";
            btnAddProceso.Size = new Size(206, 46);
            btnAddProceso.TabIndex = 0;
            btnAddProceso.Text = "Agregar Proceso";
            btnAddProceso.UseVisualStyleBackColor = false;
            btnAddProceso.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(475, 20);
            label4.Name = "label4";
            label4.Size = new Size(395, 29);
            label4.TabIndex = 7;
            label4.Text = "SIMULACION DE SCHEDULER - FIFO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerBarras
            // 
            timerBarras.Tick += timerBarras_Tick;
            // 
            // Planificador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(panel1);
            MaximumSize = new Size(1400, 900);
            MinimumSize = new Size(1400, 900);
            Name = "Planificador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planificador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private System.Windows.Forms.Timer timerBarras;
        private Panel panel2;
        private FlowLayoutPanel panelPrincipal;
        private Panel panel3;
        private Button btnStart;
        private TextBox tbNucleoId;
        private Label label2;
        private TextBox tbNucleos;
        private Label label1;
        private Button btnFijarNucleo;
        private Button btnAddProceso;
    }
}