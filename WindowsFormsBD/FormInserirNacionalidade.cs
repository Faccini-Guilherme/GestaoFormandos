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
    public partial class FormInserirNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormInserirNacionalidade()
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
                if (ligacao.InserirNacionalidade(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("Inserido com sucesso!");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro na inserção!");
                    textBox1.Focus();
                }
            }
        }
        void Limpar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }
        bool VerificarCampos()
        {
            textBox1.Text = Geral.TirarEspacos(textBox1.Text);
            if(textBox1.Text.Length != 2 )
            {
                MessageBox.Show("Erro no ALF2 (ISO2)!");
                textBox1.Focus();
                return false;
            }

            textBox2.Text = Geral.TirarEspacos(textBox2.Text);
            if (textBox2.Text.Length < 3 )
            {
                MessageBox.Show("Erro na Nacionalidade");
                textBox2.Focus();
                return false;
            }

            return true;
        }
    }
}
