using System;

namespace Projeto_de_produtos.classes
{
    public class Usuario
    {
        public Usuario()
        { // Cadastrar usuário automaticamente quando esta classe for instanciada
            Cadastrar();
        }
        public Usuario(int _codigo, string _nome, string _email, string _senha)
        { // Quando colocamos o argumento, realizamos uma sobrecarga no método construtor e posso iniciar colocando atributos diferentes no método Cadastrar;
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;
        }
        int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        DateTime DataCadastro { get; set; }

        public void Cadastrar()
        {
            Nome = "Taila";
            Email = "taila@admin.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;

        }
        public void Deletar()
        {
            Nome = "";
            Email = "";
            Senha = "";
        }
    }

}