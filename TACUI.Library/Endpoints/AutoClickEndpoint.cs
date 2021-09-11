using Autofac;
using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TACDataManager.Library.AutoFac;
using TACDataManager.Library.DataAccess;
using TACDataManager.Library.Models;
using TACDataManager.Library.Models.Enums;
using TACUI.Library.Conversion;
using TACUI.Library.Models;

namespace TACUI.Library.Endpoints
{
    public class AutoClickEndpoint : IAutoClickEndpoint
    {
        private readonly IMapper _mapper;
        private readonly IAutoClickData _autoClickData;
        private readonly IAPIHelper _aPIHelper;
        private readonly IConvertModel _convertModel;

        public AutoClickEndpoint(IAPIHelper aPIHelper, IConvertModel convertModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AutoClickBEModel, AutoClickUIModel>());
            _mapper = new Mapper(config);


            using (ILifetimeScope scope = DataManagerContainerConfig.Configure().BeginLifetimeScope())
            {
                _autoClickData = scope.Resolve<IAutoClickData>();
            }

            _aPIHelper = aPIHelper;
            _convertModel = convertModel;
        }


        public async Task InsertAutoClickModel(AutoClickUIModel model)
        {
            Models.AutoClickAPIModel autoClickAPIModel = _convertModel.ConvertUIModelToAPIModel(model);
            using (HttpResponseMessage response = await _aPIHelper._apiClient.PostAsJsonAsync("/api/AutoClick/InsertDBModel", autoClickAPIModel))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public List<AutoClickUIModel> GetModelsWithGivenBoss(EnumBoss boss)
        {
            List<AutoClickBEModel> bEModel = _autoClickData.GetAutoClickModelsByBoss(boss);

            //Map the BEModel to a UIModel
            List<AutoClickUIModel> uIModel = _mapper.Map<List<AutoClickUIModel>>(bEModel);

            return uIModel;
         }
    }
}
