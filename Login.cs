using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaEstrelas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Entrar();
            }
        }

        private void Entrar()
        { 

            
            //Anti-Burro
            if (
                !int.TryParse(txtLogin.Text, out int idUsuario) ||
                !txtSenha.MaskCompleted
               )
            {
                MessageBox.Show("Ainda há campos faltando!", "Erro!");
                return;
            }

            //procura no banco se o usuário existe
            MySqlDataReader leitor = BancoDeDados.Consultar(
                "SELECT * FROM usuarios WHERE id_usuario = @id",
                consulta => { consulta.Parameters.AddWithValue("@id", idUsuario); }
                );

            if (leitor.Read())
            {
                string senhaBanco = leitor["senha"].ToString();

                if (Seguranca.ConferirSenha(txtSenha.Text, senhaBanco)) //Se a senha está correta, então entra no aplicativo
                {
                    MessageBox.Show("Login realizado!", "Sucesso!");
                    if (idUsuario == 1)
                    {
                        Admin novaPag = new Admin();
                        novaPag.Show();
                        this.Hide();
                    }
                    else
                    {
                        Visualizacao novaPag = new Visualizacao(idUsuario);
                        novaPag.Show();
                        this.Hide();
                    }

                    this.Hide(); //Apenas esconder e não fechar, porque esta é a primeira página, fechá-la significa fechar o app inteiro.
                }
                else //Se não, então não entra
                {
                    MessageBox.Show("Senha incorreta!", "Erro");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!", "Erro!");
                return;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Entrar();
            }
        }
    }
}
