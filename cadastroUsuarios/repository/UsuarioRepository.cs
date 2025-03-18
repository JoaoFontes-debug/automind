using cadastroUsuarios.Models;

namespace cadastroUsuarios.Repository
{
    public class UsuarioRepository
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void AddUser(Usuario usuario)
        {   
             if(usuario == null)
            {
                throw new InvalidOperationException("usuario não pode ser nulo");
            }
            
            usuarios.Add(usuario);
        }

        public List<Usuario> GetAll()
        {   if(usuarios.Count == 0)
            {
                throw new Exception("Nenhum usuário cadastrado");
            }
            return usuarios;
        }

        public Usuario GetByName(string nome)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Nome == nome);
            
            if(usuario == null || usuario.Nome != nome)
            {
                throw new Exception($"Usuário {nome} não encontrado");
            }

            return usuario;
        }
    }
}