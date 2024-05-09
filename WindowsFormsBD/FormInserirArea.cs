using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsBD
{
    public partial class FormInserirArea : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormInserirArea()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (ligacao.InserirArea(nudID.Text, txtArea.Text))
                {
                    MessageBox.Show("Inserido com sucesso!");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro na inserção!");
                    txtArea.Focus();
                }
            }
        }

        bool VerificarCampos()
        {
            nudID.Text = Geral.TirarEspacos(nudID.Text);
            if (nudID.Text.Length <=0)
            {
                MessageBox.Show("Erro no campo ID Área!");
                nudID.Focus();
                return false;
            }

            txtArea.Text = Geral.TirarEspacos(txtArea.Text);
            if (txtArea.Text.Length < 3)
            {
                MessageBox.Show("Erro na Área!");
                txtArea.Focus();
                return false;
            }

            return true;
        }

        void Limpar()
        {
            nudID.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtArea.Focus();
        }
    }
}
