using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral_Patterns.Visitor
{
    public class ObjectStructure
    {
        private List<IVisitableElement> _cart;

        public ObjectStructure(List<IVisitableElement> items)
        {
            _cart = items;
        }

        public void RemoveItem(IVisitableElement item)
        {
            _cart.Remove(item);
        }

        public void ApplyVisitor(IVisitor visitor)
        {
            Console.WriteLine("\n------- Visitor Breakdown -------");
            foreach (var item in _cart)
                item.Accept(visitor);

            visitor.Print();
        }
    }
}
