using cadastroUsuarios.Models;
using cadastroUsuarios.Repository;

namespace cadastroUsuarios.Service
{
    public class UsuarioService
    {
        private UsuarioRepository usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public void AddUser(Usuario usuario)
        {
            if (usuario.Nome == null || usuario.Email == null || usuario.Idade.Equals(null))
            {
                throw new System.InvalidOperationException("Nenhum campo pode ser vazio");
            }

            usuarioRepository.AddUser(usuario);
        }

        public List<Usuario> GetAll()
        {
            if (usuarioRepository.GetAll().Count == 0)
            {
                throw new System.InvalidOperationException("Nenhum usuário cadastrado");
            }
            return usuarioRepository.GetAll();
        }

        public Usuario GetByName(string nome)
        { 
            var usuario = usuarioRepository.GetAll().FirstOrDefault(u => u.Nome == nome);
            
            if(usuario == null || usuario.Nome != nome)
            {
                throw new Exception($"Usuário {nome} não encontrado");
            }

            return usuarioRepository.GetByName(nome);
            
        }
    }
}