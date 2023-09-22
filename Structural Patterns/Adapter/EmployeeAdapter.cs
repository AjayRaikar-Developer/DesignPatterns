using DesignPatterns.Structural_Patterns.Adapter.Adaptee;
using DesignPatterns.Structural_Patterns.Adapter.Target;
using Newtonsoft.Json;
using System.Xml;

namespace DesignPatterns.Structural_Patterns.Adapter
{
    public class EmployeeAdapter : EmployeeManager, IEmployeeTarget
    {
        public override string GetAllEmployees()
        {
            string returnXml = base.GetAllEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
