﻿using DesignPatterns.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systembuilder
            , NameValueCollection collection)
        {
            systembuilder.AddDrive(collection["Drive"]);
            systembuilder.AddMemory(collection["RAM"]);
            systembuilder.AddMouse(collection["Mouse"]);
            systembuilder.AddKeyBoard(collection["Keyboard"]);
            systembuilder.AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
