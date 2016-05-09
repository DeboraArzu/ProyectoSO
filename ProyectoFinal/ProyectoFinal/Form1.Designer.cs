namespace ProyectoFinal
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btagregar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btiniciar = new System.Windows.Forms.Button();
            this.txtorigen = new System.Windows.Forms.TextBox();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.intconsumidor = new System.Windows.Forms.TextBox();
            this.intproductor = new System.Windows.Forms.TextBox();
            this.intcola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConsumidor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intprocesos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lconsumidor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvConsumidor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductor = new System.Windows.Forms.DataGridView();
            this.Thread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductor)).BeginInit();
            this.SuspendLayout();
            // 
            // btagregar
            // 
            this.btagregar.Enabled = false;
            this.btagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.Location = new System.Drawing.Point(11, 184);
            this.btagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(100, 26);
            this.btagregar.TabIndex = 7;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Enabled = false;
            this.bteliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.Location = new System.Drawing.Point(119, 184);
            this.bteliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(100, 26);
            this.bteliminar.TabIndex = 8;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btiniciar
            // 
            this.btiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiniciar.Location = new System.Drawing.Point(467, 43);
            this.btiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(100, 26);
            this.btiniciar.TabIndex = 6;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.btiniciar_Click);
            // 
            // txtorigen
            // 
            this.txtorigen.Location = new System.Drawing.Point(11, 46);
            this.txtorigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtorigen.Name = "txtorigen";
            this.txtorigen.Size = new System.Drawing.Size(132, 21);
            this.txtorigen.TabIndex = 0;
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(153, 45);
            this.txtdestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(132, 21);
            this.txtdestino.TabIndex = 1;
            // 
            // intconsumidor
            // 
            this.intconsumidor.Location = new System.Drawing.Point(11, 128);
            this.intconsumidor.Margin = new System.Windows.Forms.Padding(4);
            this.intconsumidor.Name = "intconsumidor";
            this.intconsumidor.Size = new System.Drawing.Size(132, 21);
            this.intconsumidor.TabIndex = 3;
            // 
            // intproductor
            // 
            this.intproductor.Location = new System.Drawing.Point(153, 128);
            this.intproductor.Margin = new System.Windows.Forms.Padding(4);
            this.intproductor.Name = "intproductor";
            this.intproductor.Size = new System.Drawing.Size(132, 21);
            this.intproductor.TabIndex = 4;
            // 
            // intcola
            // 
            this.intcola.Location = new System.Drawing.Point(309, 128);
            this.intcola.Margin = new System.Windows.Forms.Padding(4);
            this.intcola.Name = "intcola";
            this.intcola.Size = new System.Drawing.Size(132, 21);
            this.intcola.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destino";
            // 
            // lblConsumidor
            // 
            this.lblConsumidor.AutoSize = true;
            this.lblConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumidor.Location = new System.Drawing.Point(28, 97);
            this.lblConsumidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsumidor.Name = "lblConsumidor";
            this.lblConsumidor.Size = new System.Drawing.Size(90, 16);
            this.lblConsumidor.TabIndex = 10;
            this.lblConsumidor.Text = "Consumidor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Productor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tamaño Cola";
            // 
            // intprocesos
            // 
            this.intprocesos.Location = new System.Drawing.Point(309, 46);
            this.intprocesos.Margin = new System.Windows.Forms.Padding(4);
            this.intprocesos.Name = "intprocesos";
            this.intprocesos.Size = new System.Drawing.Size(132, 21);
            this.intprocesos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad";
            // 
            // lconsumidor
            // 
            this.lconsumidor.AutoSize = true;
            this.lconsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconsumidor.Location = new System.Drawing.Point(572, 189);
            this.lconsumidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lconsumidor.Name = "lconsumidor";
            this.lconsumidor.Size = new System.Drawing.Size(90, 16);
            this.lconsumidor.TabIndex = 18;
            this.lconsumidor.Text = "Consumidor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Productor";
            // 
            // dgvConsumidor
            // 
            this.dgvConsumidor.AllowUserToAddRows = false;
            this.dgvConsumidor.AllowUserToDeleteRows = false;
            this.dgvConsumidor.AllowUserToResizeColumns = false;
            this.dgvConsumidor.AllowUserToResizeRows = false;
            this.dgvConsumidor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsumidor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsumidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvConsumidor.Location = new System.Drawing.Point(576, 212);
            this.dgvConsumidor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsumidor.Name = "dgvConsumidor";
            this.dgvConsumidor.ReadOnly = true;
            this.dgvConsumidor.RowHeadersVisible = false;
            this.dgvConsumidor.Size = new System.Drawing.Size(292, 173);
            this.dgvConsumidor.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Thread";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 77;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Registros Creados";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 137;
            // 
            // dgvProductor
            // 
            this.dgvProductor.AllowUserToAddRows = false;
            this.dgvProductor.AllowUserToDeleteRows = false;
            this.dgvProductor.AllowUserToResizeColumns = false;
            this.dgvProductor.AllowUserToResizeRows = false;
            this.dgvProductor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thread,
            this.Status,
            this.Registros});
            this.dgvProductor.Location = new System.Drawing.Point(249, 212);
            this.dgvProductor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductor.Name = "dgvProductor";
            this.dgvProductor.ReadOnly = true;
            this.dgvProductor.RowHeadersVisible = false;
            this.dgvProductor.Size = new System.Drawing.Size(290, 173);
            this.dgvProductor.TabIndex = 15;
            // 
            // Thread
            // 
            this.Thread.HeaderText = "Thread";
            this.Thread.Name = "Thread";
            this.Thread.ReadOnly = true;
            this.Thread.Width = 77;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 72;
            // 
            // Registros
            // 
            this.Registros.HeaderText = "Registros Creados";
            this.Registros.Name = "Registros";
            this.Registros.ReadOnly = true;
            this.Registros.Width = 137;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(916, 417);
            this.Controls.Add(this.lconsumidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvConsumidor);
            this.Controls.Add(this.dgvProductor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intprocesos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConsumidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intcola);
            this.Controls.Add(this.intproductor);
            this.Controls.Add(this.intconsumidor);
            this.Controls.Add(this.txtdestino);
            this.Controls.Add(this.txtorigen);
            this.Controls.Add(this.btiniciar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btagregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proyecto final";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.TextBox txtorigen;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.TextBox intconsumidor;
        private System.Windows.Forms.TextBox intproductor;
        private System.Windows.Forms.TextBox intcola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConsumidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox intprocesos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lconsumidor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvConsumidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvProductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thread;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registros;
        private System.Windows.Forms.Timer timer1;
    }
}

