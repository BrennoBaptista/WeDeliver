using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace WeDeliver.Infraestrutura.Transversal.IoC
{
    public class IoCModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            IoCConfig.Load(builder);
        }
    }
}
