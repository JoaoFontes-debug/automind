using cadastroUsuarios.Models;

namespace cadastroUsuarios.Repository
{
    public class UsuarioRepository
    {   
        /**
            Lista de usuários
         */
        private static List<Usuario> usuarios = new List<Usuario>();

        /**
            Adiciona um usuário
            @param usuario Usuário a ser adicionado
         */
        public void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        /**
            Retorna a lista de usuários
            @return Lista de usuários
         */ 
         public List<Usuario> listarUsuarios()
         {
             return usuarios;
         }

        /**
            Retorna um usuário pelo nome
            @param nome Nome do usuário
            @return Usuário
         */     
         public Usuario buscarUsuarioPorNome(string nome)
         {
             return usuarios.Find(usuario => usuario.GetNome().Equals(nome));
         }

    }
}