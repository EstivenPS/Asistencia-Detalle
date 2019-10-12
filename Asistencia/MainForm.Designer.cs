namespace Asistencia
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEstudiantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEstudiantesToolStripMenuItem,
            this.registroDeAsistenciasToolStripMenuItem,
            this.registroDeEstudiantesToolStripMenuItem1});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeEstudiantesToolStripMenuItem
            // 
            this.registroDeEstudiantesToolStripMenuItem.Name = "registroDeEstudiantesToolStripMenuItem";
            this.registroDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.registroDeEstudiantesToolStripMenuItem.Text = "Registro de Asistencias";
            this.registroDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeEstudiantesToolStripMenuItem_Click);
            // 
            // registroDeAsistenciasToolStripMenuItem
            // 
            this.registroDeAsistenciasToolStripMenuItem.Name = "registroDeAsistenciasToolStripMenuItem";
            this.registroDeAsistenciasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.registroDeAsistenciasToolStripMenuItem.Text = "Registro de Asignaturas";
            this.registroDeAsistenciasToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeAsistenciasToolStripMenuItem_Click);
            // 
            // registroDeEstudiantesToolStripMenuItem1
            // 
            this.registroDeEstudiantesToolStripMenuItem1.Name = "registroDeEstudiantesToolStripMenuItem1";
            this.registroDeEstudiantesToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.registroDeEstudiantesToolStripMenuItem1.Text = "Registro de Estudiantes";
            this.registroDeEstudiantesToolStripMenuItem1.Click += new System.EventHandler(this.RegistroDeEstudiantesToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeAsignaturaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeAsignaturaToolStripMenuItem
            // 
            this.consultaDeAsignaturaToolStripMenuItem.Name = "consultaDeAsignaturaToolStripMenuItem";
            this.consultaDeAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.consultaDeAsignaturaToolStripMenuItem.Text = "Consulta de Asistencias";
            this.consultaDeAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeAsignaturaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAsistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEstudiantesToolStripMenuItem1;
    }
}

