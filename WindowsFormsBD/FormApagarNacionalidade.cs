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
    public partial class FormApagarNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_nacionalidade = "";
        public FormApagarNacionalidade()
        {
            InitializeComponent();
        }

        private void FormApagarNacionalidade_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
              
            txtAlf2.ReadOnly = true;
            txtNacionalidade.ReadOnly = true;
            
            btnEliminar.Enabled = false;
        }
        private void cmbNacionalidade_SelectedIndexChanged_1(object sender, EventArgs e)
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
                    btnEliminar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Nacionaliadde não encontrada!");
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            cmbNacionalidade.Focus();
        }

        private void Limpar()
        {
            cmbNacionalidade.SelectedIndex = -1;
            cmbNacionalidade.Enabled = true;

            txtAlf2.Text = "";
            txtNacionalidade.Text = "";

            btnEliminar.Enabled = false;
        }
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o registo nacionalidade " + txtNacionalidade.Text, "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.DeleteNacionalidade(txtNacionalidade.Text))
                {
                    MessageBox.Show("Registo eliminado!");
                    cmbNacionalidade.Text = "";
                    cmbNacionalidade.Items.Clear();
                    ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Não foi possível eliminar o registo!");
                }
            }
        }  
    }
}
