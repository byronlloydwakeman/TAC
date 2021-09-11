using System.Collections.Generic;
using TACDataManager.Library.Models;
using TACDataManager.Library.Models.Enums;

namespace TACDataManager.Library.DataAccess
{
    public interface IAutoClickData
    {
        List<AutoClickBEModel> GetAutoClickModelsByBoss(EnumBoss boss);
        void InsertAutoClickDBModel(AutoClickAPIModel model);
    }
}