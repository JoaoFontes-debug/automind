using cadastroUsuarios.Models;
using cadastroUsuarios.Service;

namespace cadastroUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
                * Instancia um novo usuário            
             */
            var usuarioService = new UsuarioService();

            int opcao = -1;

            while (opcao != 0)
            {   
                // Pula uma linha
                Console.WriteLine();

                Console.WriteLine("=== Cadastro de usuarios ===");
                Console.WriteLine("1. Adicionar usuário");
                Console.WriteLine("2. Listar usuários");
                Console.WriteLine("3. Buscar usuário por nome");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                
                // Pula uma linha
                Console.WriteLine();

                /**
                    trata exceções de conversão de tipos de dados
                 */
                try
                {
                     opcao = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, insira um valor numérico válido.");
                }
                // catch (Exception ex)
                // {
                //     Console.WriteLine($"Erro: {ex.Message}");
                // }

                // Pula uma linha
                Console.WriteLine();
                
                /**
                    * Verifica a opção escolhida pelo usuário
                 */
                switch (opcao)
                {
                    case 1:
                        {
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            Console.Write("Email: ");
                            string email = Console.ReadLine();
                            Console.Write("Idade: ");
                            int idade = int.Parse(Console.ReadLine());

                            var usuario = new Usuario(nome, email, idade);
                            usuarioService.AdicionarUsuario(usuario);
                            break;
                        }
                    case 2:
                        {
                            var usuarios = usuarioService.ListarUsuarios();
                            foreach (var usuario in usuarios)
                            {
                                Console.WriteLine("Nome: " + usuario.GetNome());
                                Console.WriteLine("Email: " + usuario.GetEmail());
                                Console.WriteLine("Idade: " + usuario.GetIdade());
                                Console.WriteLine("===================================");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            var usuario = usuarioService.BuscarUsuarioPorNome(nome);
                            if (usuario != null)
                            {
                                Console.WriteLine("Nome: " + usuario.GetNome());
                                Console.WriteLine("Email: " + usuario.GetEmail());
                                Console.WriteLine("Idade: " + usuario.GetIdade());
                            }
                            else
                            {
                                Console.WriteLine("Usuário não encontrado!");
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Programa finalizado!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida!");
                            break;

                        }
                }
                
                // Pula uma linha
                Console.WriteLine();
            }
        }
    }
}