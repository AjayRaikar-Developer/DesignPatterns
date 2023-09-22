using System.Xml.Serialization;
using System.Xml;

namespace DesignPatterns.Structural_Patterns.Adapter.Adaptee
{
    public class EmployeeAdaptee
    {
        EmployeeAdaptee() { }
        public EmployeeAdaptee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }

    public class EmployeeManager
    {
        public List<EmployeeAdaptee> employees;
        public EmployeeManager()
        {
            employees = new List<EmployeeAdaptee>();
            this.employees.Add(new EmployeeAdaptee(1, "John"));
            this.employees.Add(new EmployeeAdaptee(2, "Michael"));
            this.employees.Add(new EmployeeAdaptee(3, "Jason"));
        }
        public virtual string GetAllEmployees()
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(employees.GetType());
            var settings = new XmlWriterSettings(); settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, employees, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }
}
