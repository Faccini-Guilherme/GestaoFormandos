namespace WindowsFormsBD
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.nacionalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formadorÁreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LogOut = new System.Windows.Forms.ToolStripButton();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formandosToolStripMenuItem,
            this.nacionalidadeToolStripMenuItem,
            this.formadorÁreaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formandosToolStripMenuItem
            // 
            this.formandosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.apagarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.listarToolStripMenuItem});
            this.formandosToolStripMenuItem.Name = "formandosToolStripMenuItem";
            this.formandosToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.formandosToolStripMenuItem.Text = "&Formandos";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // nacionalidadeToolStripMenuItem
            // 
            this.nacionalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.atualizarToolStripMenuItem,
            this.apagarToolStripMenuItem1,
            this.listarToolStripMenuItem1});
            this.nacionalidadeToolStripMenuItem.Name = "nacionalidadeToolStripMenuItem";
            this.nacionalidadeToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.nacionalidadeToolStripMenuItem.Text = "&Nacionalidade";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Image = global::WindowsFormsBD.Properties.Resources.Add;
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.inserirToolStripMenuItem1.Text = "&Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Image = global::WindowsFormsBD.Properties.Resources.Modify;
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.atualizarToolStripMenuItem.Text = "&Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem1
            // 
            this.apagarToolStripMenuItem1.Image = global::WindowsFormsBD.Properties.Resources.Erase;
            this.apagarToolStripMenuItem1.Name = "apagarToolStripMenuItem1";
            this.apagarToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.apagarToolStripMenuItem1.Text = "A&pagar";
            this.apagarToolStripMenuItem1.Click += new System.EventHandler(this.apagarToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Image = global::WindowsFormsBD.Properties.Resources.List;
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.listarToolStripMenuItem1.Text = "&Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // formadorÁreaToolStripMenuItem
            // 
            this.formadorÁreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formadorToolStripMenuItem,
            this.áreaToolStripMenuItem});
            this.formadorÁreaToolStripMenuItem.Name = "formadorÁreaToolStripMenuItem";
            this.formadorÁreaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.formadorÁreaToolStripMenuItem.Text = "Formador/Área";
            // 
            // formadorToolStripMenuItem
            // 
            this.formadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem3,
            this.atualizarToolStripMenuItem2,
            this.apagarToolStripMenuItem3,
            this.listarToolStripMenuItem3});
            this.formadorToolStripMenuItem.Name = "formadorToolStripMenuItem";
            this.formadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formadorToolStripMenuItem.Text = "&Formador";
            // 
            // inserirToolStripMenuItem3
            // 
            this.inserirToolStripMenuItem3.Image = global::WindowsFormsBD.Properties.Resources.Add;
            this.inserirToolStripMenuItem3.Name = "inserirToolStripMenuItem3";
            this.inserirToolStripMenuItem3.Size = new System.Drawing.Size(184, 26);
            this.inserirToolStripMenuItem3.Text = "&Inserir";
            this.inserirToolStripMenuItem3.Click += new System.EventHandler(this.inserirToolStripMenuItem3_Click);
            // 
            // atualizarToolStripMenuItem2
            // 
            this.atualizarToolStripMenuItem2.Image = global::WindowsFormsBD.Properties.Resources.Modify;
            this.atualizarToolStripMenuItem2.Name = "atualizarToolStripMenuItem2";
            this.atualizarToolStripMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.atualizarToolStripMenuItem2.Text = "&Atualizar";
            this.atualizarToolStripMenuItem2.Click += new System.EventHandler(this.atualizarToolStripMenuItem2_Click);
            // 
            // apagarToolStripMenuItem3
            // 
            this.apagarToolStripMenuItem3.Image = global::WindowsFormsBD.Properties.Resources.Erase;
            this.apagarToolStripMenuItem3.Name = "apagarToolStripMenuItem3";
            this.apagarToolStripMenuItem3.Size = new System.Drawing.Size(184, 26);
            this.apagarToolStripMenuItem3.Text = "A&pagar";
            this.apagarToolStripMenuItem3.Click += new System.EventHandler(this.apagarToolStripMenuItem3_Click);
            // 
            // listarToolStripMenuItem3
            // 
            this.listarToolStripMenuItem3.Image = global::WindowsFormsBD.Properties.Resources.List;
            this.listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            this.listarToolStripMenuItem3.Size = new System.Drawing.Size(184, 26);
            this.listarToolStripMenuItem3.Text = "&Listar";
            this.listarToolStripMenuItem3.Click += new System.EventHandler(this.listarToolStripMenuItem3_Click);
            // 
            // áreaToolStripMenuItem
            // 
            this.áreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem2,
            this.atualizarToolStripMenuItem1,
            this.apagarToolStripMenuItem2,
            this.listarToolStripMenuItem2});
            this.áreaToolStripMenuItem.Name = "áreaToolStripMenuItem";
            this.áreaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.áreaToolStripMenuItem.Text = "&Área";
            // 
            // inserirToolStripMenuItem2
            // 
            this.inserirToolStripMenuItem2.Image = global::WindowsFormsBD.Properties.Resources.Add;
            this.inserirToolStripMenuItem2.Name = "inserirToolStripMenuItem2";
            this.inserirToolStripMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.inserirToolStripMenuItem2.Text = "&Inserir";
            this.inserirToolStripMenuItem2.Click += new System.EventHandler(this.inserirToolStripMenuItem2_Click);
            // 
            // atualizarToolStripMenuItem1
            // 
            this.atualizarToolStripMenuItem1.Image = global::WindowsFormsBD.Properties.Resources.Modify;
            this.atualizarToolStripMenuItem1.Name = "atualizarToolStripMenuItem1";
            this.atualizarToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.atualizarToolStripMenuItem1.Text = "A&tualizar";
            this.atualizarToolStripMenuItem1.Click += new System.EventHandler(this.atualizarToolStripMenuItem1_Click);
            // 
            // apagarToolStripMenuItem2
            // 
            this.apagarToolStripMenuItem2.Image = global::WindowsFormsBD.Properties.Resources.Erase;
            this.apagarToolStripMenuItem2.Name = "apagarToolStripMenuItem2";
            this.apagarToolStripMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.apagarToolStripMenuItem2.Text = "A&pagar";
            this.apagarToolStripMenuItem2.Click += new System.EventHandler(this.apagarToolStripMenuItem2_Click);
            // 
            // listarToolStripMenuItem2
            // 
            this.listarToolStripMenuItem2.Image = global::WindowsFormsBD.Properties.Resources.List;
            this.listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            this.listarToolStripMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.listarToolStripMenuItem2.Text = "&Listar";
            this.listarToolStripMenuItem2.Click += new System.EventHandler(this.listarToolStripMenuItem2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOut,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // LogOut
            // 
            this.LogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogOut.Name = "LogOut";
            this.LogOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LogOut.Size = new System.Drawing.Size(23, 22);
            this.LogOut.Text = "LogOut";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Image = global::WindowsFormsBD.Properties.Resources.Add;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.inserirToolStripMenuItem.Text = "&Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::WindowsFormsBD.Properties.Resources.Modify;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItem2.Text = "&Atualizar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Image = global::WindowsFormsBD.Properties.Resources.Erase;
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.apagarToolStripMenuItem.Text = "A&pagar";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Image = global::WindowsFormsBD.Properties.Resources.List;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.listarToolStripMenuItem.Text = "&Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click_1);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 415);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.Text = "Projeto I";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton LogOut;
        private System.Windows.Forms.ToolStripMenuItem formadorÁreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem áreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem2;
    }
}