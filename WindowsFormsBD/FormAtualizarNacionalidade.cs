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
    public partial class FormAtualizarNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_nacionalidade = "";
        public FormAtualizarNacionalidade()
        {
            InitializeComponent();
        }

        private void FormAtualizarNacionalidade_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
            groupBox1.Enabled = false;
            btnAtualizar.Enabled = false;

        }
        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string alf2 = "", nacionalidade = "";

            if (cmbNacionalidade.SelectedIndex != -1)
            {
                //MessageBox.Show(cmbNacionalidade.Text);
                id_nacionalidade = cmbNacionalidade.Text.Substring(
                    cmbNacionalidade.Text.LastIndexOf(' ') + 1);
                //MessageBox.Show(id_nacionalidade);
                if (ligacao.PesquisaNacionalidade(id_nacionalidade, ref alf2, ref nacionalidade))
                {
                    txtAlf2.Text = alf2;
                    txtNacionalidade.Text = nacionalidade;

                    cmbNacionalidade.Enabled = false;
                    btnAtualizar.Enabled = true;
                    groupBox1.Enabled=true;
                }
                else
                {
                    MessageBox.Show("Nacionaliadde não encontrada!");
                }

            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cmbNacionalidade.SelectedIndex != -1)
            {
                // Obtém a string selecionada no ComboBox
                string selectedItem = cmbNacionalidade.SelectedItem.ToString();

                // Divide a string selecionada para obter o id_nacionalidade
                string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
                string idNacionalidade = parts[2];

                // Mostra uma mensagem de confirmação antes de atualizar
                if (MessageBox.Show("Deseja atualizar o registo nacionalidade " + txtNacionalidade.Text, "Atualizar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Chama o método AtualizarNacionalidade passando o id_nacionalidade
                    if (ligacao.AtualizarNacionalidade(idNacionalidade, txtAlf2.Text, txtNacionalidade.Text))
                    {
                        MessageBox.Show("Registo atualizado!");
                        // Limpa o ComboBox e preenche novamente
                        cmbNacionalidade.Text = "";
                        cmbNacionalidade.Items.Clear();
                        ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
                        Limpar();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar o registo!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma nacionalidade para atualizar.");
            }
        }

        private void Limpar()
        {
            cmbNacionalidade.SelectedIndex = -1;
            cmbNacionalidade.Enabled = true;

            txtAlf2.Text = "";
            txtNacionalidade.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            cmbNacionalidade.Focus();
        }

    }
}
