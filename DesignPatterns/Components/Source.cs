﻿using DesignPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Components
{
    public class Source : GenericComponent
    {
        public Source(bool value)
        {
            input = new GenericComponent[0];
            this.state = value;
        }

        public override void accept(ComponentVisitor visitor)
        {
            visitor.visit(this);
        }

        public override void Execute()
        {
            notifyOutput();
        }
    }
}