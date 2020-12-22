using System;

namespace Projeto_de_produtos.classes
{
    public class Login
    {
        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);

            if (Logado)
            {
                GerarMenu();
            }
        }
        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();
            int Menu = 0;
            do
            {
                Console.WriteLine($"Escolha uma opção válida");
                Console.WriteLine($"[1] Cadastrar Produto");
                Console.WriteLine($"[2] Listar produtos cadastrados");
                Console.WriteLine($"[3] Deletar produtos cadastrados");
                Console.WriteLine($"[4] Cadastrar uma marca");
                Console.WriteLine($"[5] Listar marcas cadastradas");
                Console.WriteLine($"[6] Deletar marca cadastrada");
                Console.WriteLine($"[0] Sair da aplicação");                
                Menu = int.Parse(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                        produto.Cadastrar();
                        break;
                    case 2:
                        produto.Listar();
                        break;
                    case 3:
                        Console.WriteLine($"Digite o código do produto para excluir: ");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;
                    case 4:
                        marca.CadastrarMarca();
                        break;
                    case 5:
                        marca.Listar();
                        break;
                    case 6:
                        Console.WriteLine($"Digite o código da marca para excluir: ");
                        int codMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codMarca);
                        break;
                    default:
                        break;
                }
                
            } while (Menu != 0);
        }
        public bool Logado { get; set; }
        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Digite seu e-mail:");
            string emailLogin = Console.ReadLine();

            Console.WriteLine($"Digite sua senha:");
            string senhaLogin = Console.ReadLine();
            
            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha)
            {
                Logado = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Login efetuado com sucesso.");
                Console.ResetColor();
            }
            else
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Falha ao logar na aplicação.");
                Console.ResetColor();
            }
            
        }
        public void Deslogar()
        {
            Logado = false;
        }
    }
}