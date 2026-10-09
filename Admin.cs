using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ContaEstrelas
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        bool usuarioSelecionado = false;
        int idUsuarioGlobal = 0;

        private void recarregar()
        {
            dtGridTabela.ClearSelection();
            dtGridTabela.Rows.Clear();

            MySqlDataReader leitorEstrelas = BancoDeDados.Consultar("SELECT id_usuario, nome, estrelinhas FROM usuarios ORDER BY estrelinhas DESC");
            while (leitorEstrelas.Read())
            {
                string id = leitorEstrelas["id_usuario"].ToString();
                string nome = leitorEstrelas["nome"].ToString();
                string estrelas = leitorEstrelas["estrelinhas"].ToString();

                dtGridTabela.Rows.Add(id, nome, estrelas);
            }
        }

        private void btnAddEstrela_Click(object sender, EventArgs e)
        {
            if (!usuarioSelecionado)
            {
                MessageBox.Show("Adicione um ID válido!", "Erro");
                txtIdCamarada.Clear();
                txtIdCamarada.Focus();
                return;
            }
            if (!int.TryParse(txtQuantidade.Text, out int quantidadeEstrelas))
            {
                MessageBox.Show("Quantidade inválida!", "Erro");
                txtQuantidade.Clear();
                txtQuantidade.Focus();
                return;
            }

            BancoDeDados.Executar("SET SQL_SAFE_UPDATES = 0");
            int linhasAfetadas = BancoDeDados.Executar("UPDATE usuarios SET estrelinhas = estrelinhas + @quantidade WHERE id_usuario = @id", comando =>
            {
                comando.Parameters.AddWithValue("@id", idUsuarioGlobal);
                comando.Parameters.AddWithValue("@quantidade", quantidadeEstrelas);
            });
            BancoDeDados.Executar("SET SQL_SAFE_UPDATES = 1");

            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Estrelas Adicionadas!", "Sucesso!");
                recarregar();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblIdCamarada.Text = string.Empty;
            recarregar();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Anti-Burro
            if (!int.TryParse(txtIdCamarada.Text, out int idUsuario))
            {
                MessageBox.Show("Adicione um ID válido!", "Erro");
                txtIdCamarada.Clear();
                txtIdCamarada.Focus();
                return;
            }

            MySqlDataReader leitorCamarada = BancoDeDados.Consultar(
                "SELECT nome, estrelinhas FROM usuarios WHERE id_usuario = @id",
                consulta => { consulta.Parameters.AddWithValue("@id", idUsuario); }
                );

            if (leitorCamarada.Read())
            {
                lblNome.Text = leitorCamarada["nome"].ToString();
                lblEstrelinhas.Text = leitorCamarada["estrelinhas"].ToString();
                usuarioSelecionado = true;
                idUsuarioGlobal = idUsuario;
            }
        }

        private void btnRemoveEstrela_Click(object sender, EventArgs e)
        {

            if (!usuarioSelecionado)
            {
                MessageBox.Show("Adicione um ID válido!", "Erro");
                txtIdCamarada.Clear();
                txtIdCamarada.Focus();
                return;
            }
            if (!int.TryParse(txtQuantidade.Text, out int quantidadeEstrelas))
            {
                MessageBox.Show("Quantidade inválida!", "Erro");
                txtQuantidade.Clear();
                txtQuantidade.Focus();
                return;
            }

            BancoDeDados.Executar("SET SQL_SAFE_UPDATES = 0");
            int linhasAfetadas = BancoDeDados.Executar("UPDATE usuarios SET estrelinhas = estrelinhas - @quantidade WHERE id_usuario = @id", comando =>
            {
                comando.Parameters.AddWithValue("@id", idUsuarioGlobal);
                comando.Parameters.AddWithValue("@quantidade", quantidadeEstrelas);
            });
            BancoDeDados.Executar("SET SQL_SAFE_UPDATES = 1");

            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Estrelas Removidas!", "Sucesso!");
                recarregar();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Ainda há campos faltando!", "Erro");
                return;
            }

            string hashSenha = Seguranca.GerarHash(txtSenha.Text);

            var inserir = BancoDeDados.Inserir("INSERT INTO usuarios(nome, senha) values (@nome, @senha);", parametros =>
            {
                parametros.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper());
                parametros.Parameters.AddWithValue("@senha", hashSenha);
            });

            if ( inserir.numeroLinhas > 0)
            {
                lblIdCamarada.Text = $"O ID do novo camarada é {inserir.ultimoId}.";
            }

            recarregar();
        }

        private void btnBANIR_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDBanir.Text, out int idDoBanido))
            {
                MessageBox.Show("Adicione um id válido!", "Erro");
                txtIDBanir.Clear();
                txtIDBanir.Focus();
                return;
            }

            DialogResult certeza = MessageBox.Show("VOCÊ TEM CERTEZA QUE VAI BANIR?", "Confirmação", MessageBoxButtons.YesNoCancel);

            if (certeza == DialogResult.Yes)
            {

                BancoDeDados.Executar("SET_SQL_SAFE_UPDATES = 0");
                int linhasAfetadas = BancoDeDados.Executar("DELETE FROM usuarios WHERE id_usuario = @id", comando =>
                {
                    comando.Parameters.AddWithValue("@id", idDoBanido);
                });
                BancoDeDados.Executar("SET_SQL_SAFE_UPDATES = 1");

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Camarada delet💀do!", "Serviço feito...");
                    recarregar();
                }
            }

            recarregar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login novaPag = new Login();
            novaPag.Show();
            this.Close();
        }
    }
}
