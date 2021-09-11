using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACUI.Library.Conversion;
using TACUI.Library.Endpoints;

namespace TACUI.Library.AutoFac
{
    public static class UIContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<APIHelper>().As<IAPIHelper>().SingleInstance();
            builder.RegisterType<AutoClickEndpoint>().As<IAutoClickEndpoint>();
            builder.RegisterType<ConvertModel>().As<IConvertModel>();

            return builder.Build();
        }
    }
}
