# ⭐ ContaEstrelas

Sistema desktop de ranking e premiação baseado em estrelinhas, desenvolvido em C# com Windows Forms e integração com MySQL. O projeto funciona como uma espécie de "placar gamificado", em que cada usuário acumula estrelas e sobe no ranking conforme seu desempenho ou participação.

## 🎯 Ideia do Projeto

O sistema foi pensado para funcionar como uma ferramenta de incentivo e reconhecimento dentro de um grupo, equipe ou comunidade. As estrelinhas representam uma forma de premiação, bônus ou conquista, funcionando como uma espécie de medalha virtual para recompensar comportamentos, esforço, pontualidade ou participação.

Cada usuário possui um cadastro com nome, senha e quantidade de estrelinhas. O administrador pode conceder ou remover estrelas, e o ranking é exibido automaticamente em ordem decrescente de pontos.

## 🏆 Como o ranking funciona

A lógica principal do sistema é simples e objetiva:

- cada usuário tem um campo `estrelinhas` no banco;
- o administrador adiciona ou remove estrelas conforme a necessidade;
- a aplicação consulta os usuários em ordem decrescente por `estrelinhas`;
- a lista é exibida em tela para todos os usuários ou admins.

Em termos práticos, o ranking funciona assim:

- mais estrelinhas = melhor posição no ranking;
- estrelinhas são usadas como medida de reconhecimento;
- o sistema cria uma dinâmica de competição saudável e motivacional.

## ✨ Funcionalidades

### Para usuários comuns
- Login com ID e senha
- Visualização do ranking geral
- Acesso à tela de consulta do ranking
- Atualização da tabela com os dados mais recentes

### Para o administrador
- Cadastrar novos usuários
- Consultar usuário por ID
- Adicionar estrelinhas
- Remover estrelinhas
- Excluir usuários
- Visualizar a classificação completa

## 🔐 Segurança

O projeto inclui autenticação com senha criptografada usando BCrypt, o que aumenta a segurança do sistema e evita armazenamento de senhas em texto puro.

A validação também é feita na interface, garantindo que campos vazios ou valores inválidos não sejam enviados ao banco de dados.

## 🧩 Arquitetura do Sistema

O projeto é composto basicamente por:

- `Login.cs`: tela de autenticação
- `Admin.cs`: painel administrativo
- `Visualizacao.cs`: tela para visualizar a classificação
- `Classes.cs`: conexão com banco de dados e funções de segurança
- `Program.cs`: inicialização da aplicação

## 📦 Tecnologias utilizadas

- C#
- Windows Forms
- MySQL
- BCrypt.Net
- MySql.Data

## 🗄️ Estrutura do banco

A tabela principal do sistema é a de usuários:

```sql
CREATE TABLE usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    senha VARCHAR(255) NOT NULL,
    estrelinhas INT DEFAULT 0
);
```

Com isso, cada usuário pode ter seu nome, senha protegida e quantidade de estrelinhas acumuladas.

## ⚙️ Configuração

No arquivo `Classes.cs`, a string de conexão com o banco deve ser ajustada para o ambiente real:

```csharp
private static readonly string strConexao = "server=SERVER;port=3306;database=DB;user=USER;pwd=PASSWORD;";
```

Depois disso, basta instalar as dependências do projeto e executar em ambiente Windows com o MySQL configurado.

## 🏅 Exemplo de uso do sistema

O administrador pode, por exemplo:

- dar 5 estrelinhas para um colaborador por bom desempenho;
- remover 2 estrelinhas por atraso ou regra específica;
- acompanhar em tempo real a posição de cada usuário no ranking.

Isso faz com que a aplicação funcione como um sistema de premiação visual e motivacional, semelhante a uma competição gamificada.

## 📌 Observações

Este projeto é uma aplicação desktop simples, prática e funcional para gerenciamento de ranking por premiação, com foco em facilidade de uso e manutenção. Embora seja uma solução direta, a ideia central é bastante clara e útil para ambientes internos, salas de aula, equipes, competições ou comunidades que desejam reforçar engajamento através de recompensas visuais.

## 🚀 Resumo

O ContaEstrelas é um sistema de ranking em que as estrelinhas funcionam como medalhas de premiação. A aplicação permite administrar usuários, controlar pontuação e exibir uma classificação dinâmica em ordem de mérito, tornando o reconhecimento mais visível e motivador.

---

Desenvolvido para incentivar participação, desempenho e reconhecimento através de um ranking simples, transparente e gamificado.
