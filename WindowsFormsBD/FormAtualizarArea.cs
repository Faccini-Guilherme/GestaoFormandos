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
    public partial class FormAtualizarArea : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_area = "";
        public FormAtualizarArea()
        {
            InitializeComponent();
        }
        private void FormAtualizarArea_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboArea(ref cmbArea);
            groupBox1.Enabled = false;
            btnAtualizar.Enabled = false;
        }
        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idarea = "", area = "";
            if (cmbArea.SelectedIndex != -1)
            {
                id_area = cmbArea.Text.Substring(
                    cmbArea.Text.LastIndexOf(' ') + 1);
                if (ligacao.PesquisaArea(id_area, ref idarea, ref area))
                {
                    nudID.Text = idarea;
                    txtArea.Text = area;

                    cmbArea.Enabled = false;
                    btnAtualizar.Enabled = true;
                    groupBox1.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Área não encontrada!");
                }

            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cmbArea.SelectedIndex != -1)
            {
                // Obtém a string selecionada no ComboBox
                string selectedItem = cmbArea.SelectedItem.ToString();

                // Divide a string selecionada para obter o id_nacionalidade
                string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
                string id_area = parts[1];

                // Mostra uma mensagem de confirmação antes de atualizar
                if (MessageBox.Show("Deseja atualizar o registo área " + txtArea.Text, "Atualizar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Chama o método AtualizarNacionalidade passando o id_nacionalidade
                    if (ligacao.AtualizarArea(id_area, nudID.Text, txtArea.Text))
                    {
                        MessageBox.Show("Registo atualizado!");
                        // Limpa o ComboBox e preenche novamente
                        cmbArea.Text = "";
                        cmbArea.Items.Clear();
                        ligacao.PreencherComboArea(ref cmbArea);
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
                MessageBox.Show("Por favor, selecione uma área para atualizar.");
            }
        }
        private void Limpar()
        {
            cmbArea.SelectedIndex = -1;
            cmbArea.Enabled = true;

            nudID.Text = "";
            txtArea.Text = "";

            btnAtualizar.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            cmbArea.Focus();
        }

        
    }
}
