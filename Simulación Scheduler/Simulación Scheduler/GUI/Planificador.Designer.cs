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
            panel1 = new Panel();
            panel2 = new Panel();
            panelPrincipal = new FlowLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            label4 = new Label();
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
            panel1.Size = new Size(1241, 678);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelPrincipal);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 614);
            panel2.TabIndex = 8;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Right;
            panelPrincipal.Location = new Point(674, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(567, 614);
            panelPrincipal.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 614);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 90, 88);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(25, 30);
            button1.Name = "button1";
            button1.Size = new Size(201, 46);
            button1.TabIndex = 0;
            button1.Text = "Agregar Proceso";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(428, 20);
            label4.Name = "label4";
            label4.Size = new Size(395, 29);
            label4.TabIndex = 7;
            label4.Text = "SIMULACION DE SCHEDULER - FIFO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Planificador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 678);
            Controls.Add(panel1);
            Name = "Planificador";
            Text = "Planificador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private FlowLayoutPanel panelPrincipal;
    }
}