﻿using DesignPatterns.AbstractFactory.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class MACFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class MACLaptopFactory : MACFactory
    {

        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
