using System;

namespace dip
{
    public class Usuario
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        internal bool IsValid()
        {
            return true;
        }
    }
}
