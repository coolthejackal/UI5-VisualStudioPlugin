﻿using System.Collections.Generic;
using CodeGeneratorHelpers.T4;

namespace CodeGeneratorHelpers
{
    public class View
    {
        protected string ControllerName { get; private set; }
        protected virtual string MVCViewType { get; set; }
        public View(string controllerName)
        {
            this.ControllerName = controllerName;
        }
    }
}
