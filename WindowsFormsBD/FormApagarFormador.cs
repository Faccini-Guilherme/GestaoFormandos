using Microsoft.Win32;
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
    public partial class FormApagarFormador : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_area = "";
        public FormApagarFormador()
        {
            InitializeComponent();
        }
        private void FormApagarFormador_Load(object sender, EventArgs e)
        {
            GP1.Enabled = false;
            Eliminar.Enabled = false;
            this.AcceptButton = this.Pesquisa;
            ligacao.SelecionarArea(ref cmbArea, id_area);
        }
        
        private void Pesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", nif = "", id_area = "", dataNascimento = "", id_utilizador = "";

            if (ligacao.PesquisaFormador(nuID2.Value.ToString(), ref nome, ref nif, ref id_area,
                ref dataNascimento, ref id_utilizador))
            {
                txtNome.Text = nome;
                mtxtNIF.Text = nif;
                ligacao.SelecionarArea(ref cmbArea, id_area);
                mtxtDataNascimento.Text = dataNascimento;
                mtxUtilizador.Text = id_utilizador;

                GP2.Enabled = false;
                Eliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Formador não encontrado!");
                Limpar();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            GP2.Enabled = true;
            Eliminar.Enabled = false;
            nuID2.Focus();
            Limpar();
        }
        private void Limpar()
        {
            nuID2.Value = ligacao.DevolveUltimoIDFormador();
            txtNome.Text = string.Empty;
            mtxtNIF.Clear();
            cmbArea.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            mtxtDataNascimento.Clear();
            mtxUtilizador.Clear();
        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o registo ID Formador " + nuID2.Value.ToString(), "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.DeleteFormador(nuID2.Value.ToString()))
                {
                    MessageBox.Show("Registo eliminado!");
                    Cancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Não foi possível eliminar o registo!");
                }
            }
        }
    }
}
