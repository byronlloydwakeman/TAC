using Autofac;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using TACDataManager.Library.AutoFac;
using TACDataManager.Library.DataAccess;
using TACDataManager.Library.Models;

namespace TACDataManager.Controllers
{
    [Authorize]
    public class AutoClickController : ApiController
    {
        private readonly IAutoClickData _autoClickData;
        public AutoClickController()
        {
            using (ILifetimeScope scope = DataManagerContainerConfig.Configure().BeginLifetimeScope())
            {
                _autoClickData = scope.Resolve<IAutoClickData>();
            }
        }

        [HttpPost]
        [Route("api/AutoClick/InsertDBModel")]
        public void InsertDBModel(AutoClickAPIModel autoClick)
        {
            _autoClickData.InsertAutoClickDBModel(autoClick);
        }
    }
}
