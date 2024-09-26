using AgendaWF.Data;
using AgendaWF.Models;
using System.Data;

namespace AgendaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // dbAgenda.path = "Novo caminho caso deseje alterar";
            dbAgenda.CriarBancoSQLite();
            dbAgenda.CriarTabelaSQLite();
            lbDados.Text = dbAgenda.path;

        }

        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dbAgenda.GetContatos();
                dgvDados.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ->" + ex.Message);
            }

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;

                dbAgenda.Add(contato);
                ExibirDados();

                // limpar campos após cadastrar
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ->" + ex.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.Email = txtEmail.Text;

                dbAgenda.Update(contato);
                ExibirDados();

                // limpar campos após cadastrar
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ->" + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                dbAgenda.Delete(id);
                ExibirDados();

                // limpar campos após cadastrar
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ->" + ex.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (txtId.Text != "")
                {
                    int id = Convert.ToInt32(txtId.Text);
                    dt = dbAgenda.GetContato(id);
                }
                else
                {
                    String nome = txtNome.Text;
                    dt = dbAgenda.GetContatos(nome);
                }
                dgvDados.DataSource = dt;
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ->" + ex.Message);
            }
        }
    }
}
