namespace PROYECTO_BINAES
{
    partial class frmAgregarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarEvento));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dgvTodoslosEventos = new System.Windows.Forms.DataGridView();
            this.btnMostrarEventos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.txtTituloEvento = new System.Windows.Forms.TextBox();
            this.txtObjetivoEvento = new System.Windows.Forms.TextBox();
            this.txtIdH_E = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCantidadEvento = new System.Windows.Forms.Label();
            this.txtCantidadEvento = new System.Windows.Forms.TextBox();
            this.txtFhApertura = new System.Windows.Forms.TextBox();
            this.txtFhCierre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoslosEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(988, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvTodoslosEventos
            // 
            this.dgvTodoslosEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvTodoslosEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodoslosEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTodoslosEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dgvTodoslosEventos.Location = new System.Drawing.Point(563, 98);
            this.dgvTodoslosEventos.Name = "dgvTodoslosEventos";
            this.dgvTodoslosEventos.Size = new System.Drawing.Size(424, 288);
            this.dgvTodoslosEventos.TabIndex = 1;
            // 
            // btnMostrarEventos
            // 
            this.btnMostrarEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMostrarEventos.FlatAppearance.BorderSize = 0;
            this.btnMostrarEventos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMostrarEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMostrarEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEventos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrarEventos.Location = new System.Drawing.Point(799, 53);
            this.btnMostrarEventos.Name = "btnMostrarEventos";
            this.btnMostrarEventos.Size = new System.Drawing.Size(146, 23);
            this.btnMostrarEventos.TabIndex = 0;
            this.btnMostrarEventos.Text = "Mostrar";
            this.btnMostrarEventos.UseVisualStyleBackColor = false;
            this.btnMostrarEventos.Click += new System.EventHandler(this.btnMostrarEventos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(50, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "objetivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "id_HorarioEvento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(44, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha y hora de inicio:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(44, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha y hora de cierre:";
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Location = new System.Drawing.Point(101, 60);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(100, 20);
            this.txtIdEvento.TabIndex = 8;
            this.txtIdEvento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTituloEvento
            // 
            this.txtTituloEvento.Location = new System.Drawing.Point(101, 95);
            this.txtTituloEvento.Name = "txtTituloEvento";
            this.txtTituloEvento.Size = new System.Drawing.Size(100, 20);
            this.txtTituloEvento.TabIndex = 9;
            // 
            // txtObjetivoEvento
            // 
            this.txtObjetivoEvento.Location = new System.Drawing.Point(115, 129);
            this.txtObjetivoEvento.Multiline = true;
            this.txtObjetivoEvento.Name = "txtObjetivoEvento";
            this.txtObjetivoEvento.Size = new System.Drawing.Size(312, 72);
            this.txtObjetivoEvento.TabIndex = 10;
            // 
            // txtIdH_E
            // 
            this.txtIdH_E.Location = new System.Drawing.Point(152, 264);
            this.txtIdH_E.Name = "txtIdH_E";
            this.txtIdH_E.Size = new System.Drawing.Size(80, 20);
            this.txtIdH_E.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(305, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCantidadEvento
            // 
            this.lblCantidadEvento.AutoSize = true;
            this.lblCantidadEvento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidadEvento.Location = new System.Drawing.Point(46, 223);
            this.lblCantidadEvento.Name = "lblCantidadEvento";
            this.lblCantidadEvento.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadEvento.TabIndex = 17;
            this.lblCantidadEvento.Text = "Cantidad";
            // 
            // txtCantidadEvento
            // 
            this.txtCantidadEvento.Location = new System.Drawing.Point(117, 220);
            this.txtCantidadEvento.Name = "txtCantidadEvento";
            this.txtCantidadEvento.Size = new System.Drawing.Size(80, 20);
            this.txtCantidadEvento.TabIndex = 18;
            // 
            // txtFhApertura
            // 
            this.txtFhApertura.Location = new System.Drawing.Point(166, 305);
            this.txtFhApertura.Name = "txtFhApertura";
            this.txtFhApertura.Size = new System.Drawing.Size(219, 20);
            this.txtFhApertura.TabIndex = 19;
            // 
            // txtFhCierre
            // 
            this.txtFhCierre.Location = new System.Drawing.Point(166, 342);
            this.txtFhCierre.Name = "txtFhCierre";
            this.txtFhCierre.Size = new System.Drawing.Size(219, 20);
            this.txtFhCierre.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(410, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "EVENTOS";
            // 
            // frmAgregarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1025, 438);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFhCierre);
            this.Controls.Add(this.txtFhApertura);
            this.Controls.Add(this.txtCantidadEvento);
            this.Controls.Add(this.lblCantidadEvento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdH_E);
            this.Controls.Add(this.txtObjetivoEvento);
            this.Controls.Add(this.txtTituloEvento);
            this.Controls.Add(this.txtIdEvento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarEventos);
            this.Controls.Add(this.dgvTodoslosEventos);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarEvento";
            this.Text = "Agregar nuevo evento";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAgregarEvento_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodoslosEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView dgvTodoslosEventos;
        private System.Windows.Forms.Button btnMostrarEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.TextBox txtTituloEvento;
        private System.Windows.Forms.TextBox txtObjetivoEvento;
        private System.Windows.Forms.TextBox txtIdH_E;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCantidadEvento;
        private System.Windows.Forms.TextBox txtCantidadEvento;
        private System.Windows.Forms.TextBox txtFhApertura;
        private System.Windows.Forms.TextBox txtFhCierre;
        private System.Windows.Forms.Label label7;
    }
}