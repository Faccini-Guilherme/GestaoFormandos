namespace WindowsFormsBD
{
    partial class FormApagarFormador
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.GP1 = new System.Windows.Forms.GroupBox();
            this.mtxUtilizador = new System.Windows.Forms.TextBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtNIF = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GP2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Button();
            this.nuID2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4.SuspendLayout();
            this.GP1.SuspendLayout();
            this.GP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuID2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Eliminar);
            this.groupBox4.Controls.Add(this.Cancelar);
            this.groupBox4.Location = new System.Drawing.Point(11, 361);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(385, 73);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(244, 29);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(71, 34);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click_1);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(65, 29);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(71, 34);
            this.Cancelar.TabIndex = 0;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // GP1
            // 
            this.GP1.Controls.Add(this.mtxUtilizador);
            this.GP1.Controls.Add(this.cmbArea);
            this.GP1.Controls.Add(this.label8);
            this.GP1.Controls.Add(this.mtxtNIF);
            this.GP1.Controls.Add(this.dateTimePicker1);
            this.GP1.Controls.Add(this.mtxtDataNascimento);
            this.GP1.Controls.Add(this.label7);
            this.GP1.Controls.Add(this.label5);
            this.GP1.Controls.Add(this.label4);
            this.GP1.Controls.Add(this.txtNome);
            this.GP1.Controls.Add(this.label2);
            this.GP1.Location = new System.Drawing.Point(11, 121);
            this.GP1.Margin = new System.Windows.Forms.Padding(2);
            this.GP1.Name = "GP1";
            this.GP1.Padding = new System.Windows.Forms.Padding(2);
            this.GP1.Size = new System.Drawing.Size(385, 236);
            this.GP1.TabIndex = 1;
            this.GP1.TabStop = false;
            // 
            // mtxUtilizador
            // 
            this.mtxUtilizador.Location = new System.Drawing.Point(100, 174);
            this.mtxUtilizador.Margin = new System.Windows.Forms.Padding(2);
            this.mtxUtilizador.MaxLength = 100;
            this.mtxUtilizador.Name = "mtxUtilizador";
            this.mtxUtilizador.Size = new System.Drawing.Size(232, 20);
            this.mtxUtilizador.TabIndex = 10;
            // 
            // cmbArea
            // 
            this.cmbArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(108, 101);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(230, 21);
            this.cmbArea.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Utilizador:";
            // 
            // mtxtNIF
            // 
            this.mtxtNIF.Location = new System.Drawing.Point(106, 62);
            this.mtxtNIF.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtNIF.Mask = "000 000 000";
            this.mtxtNIF.Name = "mtxtNIF";
            this.mtxtNIF.Size = new System.Drawing.Size(232, 20);
            this.mtxtNIF.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 136);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // mtxtDataNascimento
            // 
            this.mtxtDataNascimento.Location = new System.Drawing.Point(108, 136);
            this.mtxtDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDataNascimento.Mask = "00/00/0000";
            this.mtxtDataNascimento.Name = "mtxtDataNascimento";
            this.mtxtDataNascimento.Size = new System.Drawing.Size(63, 20);
            this.mtxtDataNascimento.TabIndex = 7;
            this.mtxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Área:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "NIF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 22);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // GP2
            // 
            this.GP2.Controls.Add(this.nuID2);
            this.GP2.Controls.Add(this.Pesquisa);
            this.GP2.Controls.Add(this.label6);
            this.GP2.Location = new System.Drawing.Point(11, 16);
            this.GP2.Margin = new System.Windows.Forms.Padding(2);
            this.GP2.Name = "GP2";
            this.GP2.Padding = new System.Windows.Forms.Padding(2);
            this.GP2.Size = new System.Drawing.Size(385, 91);
            this.GP2.TabIndex = 0;
            this.GP2.TabStop = false;
            this.GP2.Text = "Pesquisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Formador:";
            // 
            // Pesquisa
            // 
            this.Pesquisa.Image = global::WindowsFormsBD.Properties.Resources.Zoom;
            this.Pesquisa.Location = new System.Drawing.Point(209, 38);
            this.Pesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(58, 19);
            this.Pesquisa.TabIndex = 2;
            this.Pesquisa.UseVisualStyleBackColor = true;
            this.Pesquisa.Click += new System.EventHandler(this.Pesquisa_Click);
            // 
            // nuID2
            // 
            this.nuID2.Location = new System.Drawing.Point(108, 37);
            this.nuID2.Margin = new System.Windows.Forms.Padding(2);
            this.nuID2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nuID2.Name = "nuID2";
            this.nuID2.Size = new System.Drawing.Size(90, 20);
            this.nuID2.TabIndex = 1;
            // 
            // FormApagarFormador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GP1);
            this.Controls.Add(this.GP2);
            this.Name = "FormApagarFormador";
            this.Text = "Apagar Formador";
            this.Load += new System.EventHandler(this.FormApagarFormador_Load);
            this.groupBox4.ResumeLayout(false);
            this.GP1.ResumeLayout(false);
            this.GP1.PerformLayout();
            this.GP2.ResumeLayout(false);
            this.GP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuID2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.GroupBox GP1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtNIF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.TextBox mtxUtilizador;
        private System.Windows.Forms.GroupBox GP2;
        private System.Windows.Forms.NumericUpDown nuID2;
        private System.Windows.Forms.Button Pesquisa;
        private System.Windows.Forms.Label label6;
    }
}