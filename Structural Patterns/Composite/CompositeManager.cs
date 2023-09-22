using DesignPatterns.Factory;
using DesignPatterns.Structural_Patterns.Composite.Component;

namespace DesignPatterns.Structural_Patterns.Composite
{
    public class CompositeManager : IEmployeeComponent
    {
        public List<IEmployeeComponent> SubOrdinates;
        public CompositeManager(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
            SubOrdinates = new List<IEmployeeComponent>();
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public void GetDetails(int indentation)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("{0}+ Name:{1}, " +
                "Dept:{2} - Manager(Composite)",
                new String('-', indentation), this.Name.ToString(),
                this.Department));
            foreach (IEmployeeComponent component in SubOrdinates)
            {
                component.GetDetails(indentation + 1);
            }
        }
    }
}
