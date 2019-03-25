using dip.Interfaces;
using System;
using static System.Console;

namespace dip
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario
            {
                Id = Guid.NewGuid(),
                Nome = "Luciano Lima",
                Email = "lima@lucianolima.com.br",
                CPF = "01234567890"
            };

            //var usuarioRepository = new UsuarioRepository();
            //var result = usuarioRepository.Adicionar(usuario);
            //WriteLine(result ? "Adicionado" : "Erro ao adicionar");

            var usuaroService = Container.Get<IService<Usuario>>();
            var resultOk = usuaroService.Inserir(usuario);
            WriteLine(resultOk ? "Adicionado" : "Erro ao adicionar");

            ReadLine();

        }
    }
}
