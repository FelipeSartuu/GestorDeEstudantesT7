namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
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
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelTotalDeEstudantes = new System.Windows.Forms.Panel();
            this.labelTotalDeEstudantes = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.panelMeninas.SuspendLayout();
            this.panelTotalDeEstudantes.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.Plum;
            this.panelMeninas.Controls.Add(this.panel2);
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(398, 249);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(380, 189);
            this.panelMeninas.TabIndex = 0;
            this.panelMeninas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(115, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 5;
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(96, 65);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(185, 31);
            this.labelMeninas.TabIndex = 4;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.Click += new System.EventHandler(this.label3_Click);
            this.labelMeninas.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // panelTotalDeEstudantes
            // 
            this.panelTotalDeEstudantes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTotalDeEstudantes.Controls.Add(this.labelTotalDeEstudantes);
            this.panelTotalDeEstudantes.Location = new System.Drawing.Point(12, 12);
            this.panelTotalDeEstudantes.Name = "panelTotalDeEstudantes";
            this.panelTotalDeEstudantes.Size = new System.Drawing.Size(766, 222);
            this.panelTotalDeEstudantes.TabIndex = 1;
            this.panelTotalDeEstudantes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // labelTotalDeEstudantes
            // 
            this.labelTotalDeEstudantes.AutoSize = true;
            this.labelTotalDeEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeEstudantes.Location = new System.Drawing.Point(239, 93);
            this.labelTotalDeEstudantes.Name = "labelTotalDeEstudantes";
            this.labelTotalDeEstudantes.Size = new System.Drawing.Size(316, 31);
            this.labelTotalDeEstudantes.TabIndex = 7;
            this.labelTotalDeEstudantes.Text = "Total de Estudantes: 999";
            this.labelTotalDeEstudantes.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.labelTotalDeEstudantes.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(12, 249);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(380, 189);
            this.panelMeninos.TabIndex = 2;
            this.panelMeninos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(74, 65);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(185, 31);
            this.labelMeninos.TabIndex = 6;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.Click += new System.EventHandler(this.labelMeninos_Click);
            this.labelMeninos.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelTotalDeEstudantes);
            this.Controls.Add(this.panelMeninas);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelTotalDeEstudantes.ResumeLayout(false);
            this.panelTotalDeEstudantes.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTotalDeEstudantes;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Label labelTotalDeEstudantes;
        private System.Windows.Forms.Label labelMeninos;
    }
}