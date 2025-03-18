using cadastroUsuarios.Models;
using cadastroUsuarios.Repository;
using System.Text.RegularExpressions;


namespace cadastroUsuarios.Service
{
    public class UsuarioService
    {
        /**
            Adiciona um usuário
            @param usuario Usuário a ser adicionado
         */
        private UsuarioRepository usuarioRepository = new UsuarioRepository();

        public void AdicionarUsuario(Usuario usuario)
        {
            validaUsuario(usuario);
            usuarioRepository.adicionarUsuario(usuario);
        }

        /**
            Retorna a lista de usuários
            @return Lista de usuários
         */
        public List<Usuario> ListarUsuarios()
        {   
            if (usuarioRepository.listarUsuarios().Count == 0)
            {
                throw new Exception("Nenhum usuário cadastrado");
            }

            return usuarioRepository.listarUsuarios();
        }

        /**
            Retorna um usuário pelo nome
            @param nome Nome do usuário
            @return Usuário
         */
        public Usuario BuscarUsuarioPorNome(string nome)
        {
            return usuarioRepository.buscarUsuarioPorNome(nome);
        }

        /**
            Valida um usuário
            @param usuario Usuário a ser validado
         */
        private void validaUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.GetNome()))
            {
                throw new ArgumentException("O nome é obrigatório");
            }
            if (string.IsNullOrWhiteSpace(usuario.GetEmail()))
            {
                throw new ArgumentException("O email é obrigatório");
            }
            if (usuario.GetIdade() < 1 || usuario.GetIdade() > 120)
            {
                throw new ArgumentException("Idade deve ser entre 1 e 100");
            }
            if (!Regex.IsMatch(usuario.GetEmail(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("Email inválido");
            }
        }
        
    }
}