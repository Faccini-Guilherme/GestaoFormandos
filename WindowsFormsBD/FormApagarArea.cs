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
    public partial class FormApagarArea : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_area = "";
        public FormApagarArea()
        {
            InitializeComponent();
        }

        private void FormApagarArea_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboArea(ref cmbArea);

            nudID.ReadOnly = true;
            txtArea.ReadOnly = true;

            btnEliminar.Enabled = false;
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
                    btnEliminar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Área não encontrada!");
                }

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            cmbArea.Focus();
        }
        private void Limpar()
        {
            cmbArea.SelectedIndex = -1;
            cmbArea.Enabled = true;

            nudID.Text = "";
            txtArea.Text = "";

            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o registo Área " + txtArea.Text, "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.DeleteArea(txtArea.Text))
                {
                    MessageBox.Show("Registo eliminado!");
                    cmbArea.Text = "";
                    cmbArea.Items.Clear();
                    ligacao.PreencherComboArea(ref cmbArea);
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
