using dip.Interfaces;
using System;

namespace dip
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public bool Adicionar(Usuario usuario)
        {
            try
            {
                //throw new Exception();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
