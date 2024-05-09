namespace WindowsFormsBD
{
    partial class FormAtualizarFormador
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
            this.GP3 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GP2 = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.mtxUtilizador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtNIF = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mtxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GP1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.GP3.SuspendLayout();
            this.GP2.SuspendLayout();
            this.GP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // GP3
            // 
            this.GP3.Controls.Add(this.btnAtualizar);
            this.GP3.Controls.Add(this.btnCancelar);
            this.GP3.Location = new System.Drawing.Point(7, 365);
            this.GP3.Margin = new System.Windows.Forms.Padding(2);
            this.GP3.Name = "GP3";
            this.GP3.Padding = new System.Windows.Forms.Padding(2);
            this.GP3.Size = new System.Drawing.Size(385, 81);
            this.GP3.TabIndex = 2;
            this.GP3.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(244, 29);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 34);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(65, 29);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 34);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GP2
            // 
            this.GP2.Controls.Add(this.cmbArea);
            this.GP2.Controls.Add(this.mtxUtilizador);
            this.GP2.Controls.Add(this.label8);
            this.GP2.Controls.Add(this.mtxtNIF);
            this.GP2.Controls.Add(this.dateTimePicker1);
            this.GP2.Controls.Add(this.mtxtDataNascimento);
            this.GP2.Controls.Add(this.label7);
            this.GP2.Controls.Add(this.label5);
            this.GP2.Controls.Add(this.label4);
            this.GP2.Controls.Add(this.txtNome);
            this.GP2.Controls.Add(this.label2);
            this.GP2.Location = new System.Drawing.Point(7, 125);
            this.GP2.Margin = new System.Windows.Forms.Padding(2);
            this.GP2.Name = "GP2";
            this.GP2.Padding = new System.Windows.Forms.Padding(2);
            this.GP2.Size = new System.Drawing.Size(385, 236);
            this.GP2.TabIndex = 1;
            this.GP2.TabStop = false;
            // 
            // cmbArea
            // 
            this.cmbArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(107, 101);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(231, 21);
            this.cmbArea.TabIndex = 5;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
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
            this.mtxtNIF.Size = new System.Drawing.Size(134, 20);
            this.mtxtNIF.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 136);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
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
            this.mtxtDataNascimento.TextChanged += new System.EventHandler(this.mtxtDataNascimento_TextChanged);
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
            // GP1
            // 
            this.GP1.Controls.Add(this.btnPesquisa);
            this.GP1.Controls.Add(this.nudID);
            this.GP1.Controls.Add(this.label6);
            this.GP1.Location = new System.Drawing.Point(7, 30);
            this.GP1.Margin = new System.Windows.Forms.Padding(2);
            this.GP1.Name = "GP1";
            this.GP1.Padding = new System.Windows.Forms.Padding(2);
            this.GP1.Size = new System.Drawing.Size(385, 91);
            this.GP1.TabIndex = 0;
            this.GP1.TabStop = false;
            this.GP1.Text = "Pesquisa";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::WindowsFormsBD.Properties.Resources.Zoom;
            this.btnPesquisa.Location = new System.Drawing.Point(209, 38);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(58, 19);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(105, 39);
            this.nudID.Margin = new System.Windows.Forms.Padding(2);
            this.nudID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(90, 20);
            this.nudID.TabIndex = 1;
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
            // FormAtualizarFormador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 457);
            this.Controls.Add(this.GP2);
            this.Controls.Add(this.GP3);
            this.Controls.Add(this.GP1);
            this.Name = "FormAtualizarFormador";
            this.Text = "Atualizar Formador";
            this.Load += new System.EventHandler(this.FormAtualizarFormador_Load);
            this.GP3.ResumeLayout(false);
            this.GP2.ResumeLayout(false);
            this.GP2.PerformLayout();
            this.GP1.ResumeLayout(false);
            this.GP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GP3;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox GP2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtNIF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mtxtDataNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GP1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mtxUtilizador;
        private System.Windows.Forms.ComboBox cmbArea;
    }
}