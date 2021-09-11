using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.Conversion;
using TACDataManager.Library.DataAccess;

namespace TACDataManager.Library.AutoFac
{
    public static class DataManagerContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SqlDataAccess>().As<ISqlDataAccess>();
            builder.RegisterType<AutoClickData>().As<IAutoClickData>();
            builder.RegisterType<ConvertEnum>().As<IConvertEnum>();
            builder.RegisterType<ConvertModel>().As<IConvertModel>();
            builder.RegisterType<ConvertString>().As<IConvertString>();
            builder.RegisterType<ConvertInt>().As<IConvertInt>();
            builder.RegisterType<ConvertModel>().As<IConvertModel>();

            return builder.Build();
        }
    }
}
