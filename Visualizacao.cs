using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ContaEstrelas
{
    public partial class Visualizacao : Form
    {
        private int idUsuario;
        public Visualizacao(int idUsuario)
        {
            InitializeComponent();
            idUsuario = this.idUsuario;
        }

        private void Visualizacao_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void Visualizacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F5)
            {
                Recarregar();
            }
        }

        private void Recarregar()
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login novaPag = new Login();
            novaPag.Show();
            this.Close();
        }
    }
}
