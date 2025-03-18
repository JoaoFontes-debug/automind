using cadastroUsuarios.Models;
using cadastroUsuarios.Repository;
using cadastroUsuarios.Service;

namespace cadastroUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new UsuarioRepository();
            var service = new UsuarioService(repository);

            int selected = -1;

            while (selected != 0)
            {   System.Console.WriteLine();
                System.Console.WriteLine("Digite a opção desejada");
                System.Console.WriteLine("Digite 1 para adicionar um usuário");
                System.Console.WriteLine("Digite 2 para listar todos os usuários");
                System.Console.WriteLine("Digite 3 para buscar um usuário por nome");
                System.Console.WriteLine("Digite 0 para sair");

                selected = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
                
                switch (selected)
                {
                    case 1:
                        System.Console.WriteLine("Digite o nome do usuário");
                        var nome = System.Console.ReadLine();

                        System.Console.WriteLine("Digite o email do usuário");
                        var email = System.Console.ReadLine();

                        System.Console.WriteLine("Digite a idade do usuário");
                        var idade = int.Parse(System.Console.ReadLine());

                        var usuario = new Usuario
                        {
                            Nome = nome,
                            Email = email,
                            Idade = idade
                        };

                        service.AddUser(usuario);
                        break;
                    case 2:
                        var usuarios = service.GetAll();
                        foreach (var u in usuarios)
                        {
                            System.Console.WriteLine($"Nome: {u.Nome}, Email: {u.Email}, Idade: {u.Idade}");
                        }
                        break;
                    case 3:
                        System.Console.WriteLine("Digite o nome do usuário");
                        var nomeBusca = System.Console.ReadLine();

                        var usuarioBusca = service.GetByName(nomeBusca);
                        System.Console.WriteLine($"Nome: {usuarioBusca.Nome}, Email: {usuarioBusca.Email}, Idade: {usuarioBusca.Idade}");
                        break;
                    case 0:
                        System.Console.WriteLine("Saindo...");
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida");
                        break;
                }
               
            }
            
        }
    }
}