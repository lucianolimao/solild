using dip.Interfaces;

namespace dip
{
    public class UsuarioService : IService<Usuario>
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool Inserir(Usuario usuario)
        {
            if (!usuario.IsValid())
                return false;

            return _usuarioRepository.Adicionar(usuario);
        }
    }
}
