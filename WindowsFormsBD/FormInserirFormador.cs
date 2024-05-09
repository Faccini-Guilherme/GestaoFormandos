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
    public partial class FormInserirFormador : Form
    {
        DBConnect ligacao = new DBConnect();
        private string NIFAux = "";
        string id_area = "";
        public FormInserirFormador()
        {
            InitializeComponent();
        }

        private void FormInserirFormador_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboArea(ref cmbArea);
            nudID.Value = ligacao.DevolveUltimoIDFormador();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                
                if (ligacao.Insert2(nudID.Value.ToString(), txtNome.Text, NIFAux, id_area,
                    DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), mtxUtilizador.Text))
                {
                    MessageBox.Show("Gravado com sucesso!");
                    Limpar();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na gravação do registo!");
                }
            }
        }

        private bool VerificarCampos()
        {
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID Formador!");
                nudID.Focus();
                return false;
            }

            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            NIFAux = mtxtNIF.Text.Replace(" ", "");

            if (NIFAux.Length != 0 && NIFAux.Length != 9)
            {
                MessageBox.Show("Erro no campo NIF!");
                mtxtNIF.Focus();
                return false;
            }

            if (cmbArea.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo  ID Área!");
                cmbArea.Focus();
                return false;
            }
       
            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data Nascimento!");
                mtxtDataNascimento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(mtxUtilizador.Text))
            {
                MessageBox.Show("Erro no campo ID Utilizador!");
                mtxUtilizador.Focus();
                return false;
            }
            else
            {
                if (!int.TryParse(mtxUtilizador.Text, out int userInput))
                {
                    MessageBox.Show("Erro no campo ID Utilizador!");
                    mtxUtilizador.Focus();
                    return false;
                }
                else if (userInput < 1 || userInput > 3)
                {
                    MessageBox.Show("O número deve estar entre 1 e 3.");
                    mtxUtilizador.Focus();
                    return false;
                }
            }


            return true;
        }

        private void Limpar()
        {
            nudID.Value = ligacao.DevolveUltimoIDFormador();
            txtNome.Text = string.Empty;
            mtxtNIF.Clear();
            cmbArea.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            mtxtDataNascimento.Clear();
            mtxUtilizador.Clear();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea.SelectedIndex != -1)
            {
                //MessageBox.Show(cmbNacionalidade.Text);
                id_area = cmbArea.Text.Substring(
                    cmbArea.Text.LastIndexOf(' ') + 1);
                //MessageBox.Show(id_nacionalidade);
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            mtxtDataNascimento.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void mtxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            int dia, mes, ano;
            string textoData;
            DateTime data;

            if (mtxtDataNascimento.MaskCompleted == true)
            {
                textoData = mtxtDataNascimento.Text;
                dia = int.Parse(textoData.Substring(0, 2));
                mes = int.Parse(textoData.Substring(3, 2));
                ano = int.Parse(textoData.Substring(6));

                try
                {
                    data = DateTime.Parse(dia + "-" + mes + "-" + ano);
                    dateTimePicker1.Value = data;
                }
                catch
                {
                    MessageBox.Show("Data incorreta!", "Erro!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    mtxtDataNascimento.Focus();
                }
            }
        }
    }
}
