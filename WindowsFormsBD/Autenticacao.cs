using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBD
{
    public partial class Autenticacao : Form
    {
        DBConnect ligacao = new DBConnect();
        //public string userName = "";
        public Autenticacao()
        {
            InitializeComponent();
        }

        private void Autenticacao_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            ControlBox = false;
            AcceptButton = Login;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            int nfalhas = 0;
            if (ligacao.ValidateUserStatus(txtUser.Text, ref nfalhas))
            {
                MessageBox.Show("Utilizador bloqueado! Nº Falhas de autenticação: " + nfalhas + "\nContacte o Administrador do Sistema.");
                return;
            }

            //if (ligacao.ValidateUser(txtUser.Text, txtPass.Text, ref userName)) 
            //if (ligacao.ValidateUser(txtUser.Text, txtPass.Text, ref Geral.id_user))
            if (ligacao.ValidateUser2(txtUser.Text, txtPass.Text, ref Geral.id_user))
                {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Erro na autenticação!");
            }
        }
    }
}
