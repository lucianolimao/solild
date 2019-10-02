using dip.Interfaces;
using System;

namespace dip
{
    internal class Container
    {
        public static IService<Usuario> Get<T>()
        {
            return new UsuarioService(new UsuarioRepository());
        }
    }
}