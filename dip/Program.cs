using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

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

            // low-level module
            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);
        }
    }
}
