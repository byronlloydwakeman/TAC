using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TACDataManager.Library.Models.Enums;
using TACUI.Library.Models;

namespace TACUI.Library.Endpoints
{
    public interface IAutoClickEndpoint
    {
        List<AutoClickUIModel> GetModelsWithGivenBoss(EnumBoss boss);
        Task InsertAutoClickModel(AutoClickUIModel model);
    }
}