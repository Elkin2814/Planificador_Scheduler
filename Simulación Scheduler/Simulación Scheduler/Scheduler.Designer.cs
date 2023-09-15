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
            panelProcesos2 = new Panel();
            panel4 = new Panel();
            panelProceso1 = new FlowLayoutPanel();
            panel3 = new Panel();
            btnAgregarProceso = new Button();
            panelTabla = new Panel();
            panelProcesos = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            timerBarra = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            panelPrincipal.SuspendLayout();
            panelProcesos2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelTabla.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(4, 6, 20);
            panelPrincipal.Controls.Add(panelProcesos2);
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.ForeColor = Color.Coral;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1257, 706);
            panelPrincipal.TabIndex = 0;
            // 
            // panelProcesos2
            // 
            panelProcesos2.BackColor = Color.FromArgb(38, 40, 53);
            panelProcesos2.Controls.Add(panel4);
            panelProcesos2.Controls.Add(panel3);
            panelProcesos2.Controls.Add(panelTabla);
            panelProcesos2.Dock = DockStyle.Fill;
            panelProcesos2.Location = new Point(0, 78);
            panelProcesos2.Name = "panelProcesos2";
            panelProcesos2.Size = new Size(1257, 628);
            panelProcesos2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(73, 77, 99);
            panel4.Controls.Add(panelProceso1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(811, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(446, 628);
            panel4.TabIndex = 1;
            // 
            // panelProceso1
            // 
            panelProceso1.AutoScroll = true;
            panelProceso1.Dock = DockStyle.Fill;
            panelProceso1.Location = new Point(0, 0);
            panelProceso1.Name = "panelProceso1";
            panelProceso1.Size = new Size(446, 628);
            panelProceso1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAgregarProceso);
            panel3.Location = new Point(584, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 79);
            panel3.TabIndex = 0;
            // 
            // btnAgregarProceso
            // 
            btnAgregarProceso.BackColor = Color.FromArgb(180, 195, 189);
            btnAgregarProceso.FlatStyle = FlatStyle.Flat;
            btnAgregarProceso.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProceso.ForeColor = Color.FromArgb(5, 2, 28);
            btnAgregarProceso.Location = new Point(9, 18);
            btnAgregarProceso.Name = "btnAgregarProceso";
            btnAgregarProceso.Size = new Size(196, 44);
            btnAgregarProceso.TabIndex = 3;
            btnAgregarProceso.Text = "Agregar Proceso";
            btnAgregarProceso.UseVisualStyleBackColor = false;
            btnAgregarProceso.Click += btnAgregarProceso_Click;
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(73, 77, 99);
            panelTabla.Controls.Add(panelProcesos);
            panelTabla.Controls.Add(button1);
            panelTabla.Controls.Add(label1);
            panelTabla.Controls.Add(comboBox1);
            panelTabla.Controls.Add(label2);
            panelTabla.Dock = DockStyle.Left;
            panelTabla.Location = new Point(0, 0);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(565, 628);
            panelTabla.TabIndex = 0;
            // 
            // panelProcesos
            // 
            panelProcesos.AutoScroll = true;
            panelProcesos.Location = new Point(0, 0);
            panelProcesos.Name = "panelProcesos";
            panelProcesos.Size = new Size(387, 628);
            panelProcesos.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 40, 53);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 78);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(843, 32);
            label3.Name = "label3";
            label3.Size = new Size(402, 29);
            label3.TabIndex = 5;
            label3.Text = "SIMULACION CON UN SOLO NUCLEO";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(180, 195, 189);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(5, 2, 28);
            button1.Location = new Point(393, 109);
            button1.Name = "button1";
            button1.Size = new Size(162, 44);
            button1.TabIndex = 4;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox1.Location = new Point(494, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(48, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(393, 56);
            label2.Name = "label2";
            label2.Size = new Size(95, 29);
            label2.TabIndex = 1;
            label2.Text = "Nucleos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(393, 6);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 0;
            label1.Text = "Opciones:";
            // 
            // timerBarra
            // 
            timerBarra.Tick += timerBarra_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(12, 32);
            label4.Name = "label4";
            label4.Size = new Size(402, 29);
            label4.TabIndex = 6;
            label4.Text = "SIMULACION CON VARIOS NUCLEOS";
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
            panelProcesos2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
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
        private Panel panelProcesos2;
        private Panel panel3;
        private Button btnAgregarProceso;
        private Panel panelTabla;
        private FlowLayoutPanel panelProcesos;
        private System.Windows.Forms.Timer timerBarra;
        private Button button1;
        private Panel panel4;
        private FlowLayoutPanel panelProceso1;
        private Label label3;
        private Label label4;
    }
}