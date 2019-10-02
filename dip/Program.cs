using dip.Interfaces;
using System;
using static System.Console;

namespace dip
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Person
    {
        public string Name;
    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    public class Relationships : IRelationshipBrowser // low-level
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
              .Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }
    }

    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
                WriteLine($"John has a child called {p.Name}");
        }
    }


    public static class Program
    {
        static void Main(string[] args)
        {

            var parent = new Person { Name = "Johnny" };
            var child1 = new Person { Name = "Christina" };
            var child2 = new Person { Name = "Matthew" };

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
