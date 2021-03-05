﻿using Logger.Models.Conflicts;
using Logger.Models.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Factories
{
    public class LayoutFactory
    {
        public ILayout ProduceLayout(string type)
        {
            ILayout layout;

            if (type == "SimpleLayout")
            {
                layout = new SimpleLayout();
            }
            else if (type == "XmlLayout")
            {
                layout = new XmlLayout();
            }
            else if (type == "JsonLayout")
            {
                layout = new JsonLayout();
            }
            else
            {
                throw new ArgumentException("Invalid layout type");
            }

            return layout;
        }
    }
}
