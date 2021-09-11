using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.Conversion;
using TACDataManager.Library.Models;
using TACDataManager.Library.Models.Enums;

namespace TACDataManager.Library.DataAccess
{
    public class AutoClickData : IAutoClickData
    {
        private readonly ISqlDataAccess _sqlDataAccess;
        private readonly IConvertModel _convertModel;

        public AutoClickData(ISqlDataAccess sqlDataAccess, IConvertModel convertModel)
        {
            _sqlDataAccess = sqlDataAccess;
            _convertModel = convertModel;
        }

        public List<AutoClickBEModel> GetAutoClickModelsByBoss(EnumBoss boss)
        {
            List<AutoClickDBModel> dBModel = _sqlDataAccess.LoadData<AutoClickDBModel, dynamic>("spGetAutoClickModel_ByBoss", new { Boss = boss.ToString() });

            List<AutoClickBEModel> bEModel = new List<AutoClickBEModel>();

            foreach (var item in dBModel)
            {
                bEModel.Add(_convertModel.ConvertToBEModel(item));
            }

            return bEModel;
        }

        public void InsertAutoClickDBModel(AutoClickAPIModel model)
        {
            //We first need to convert the BE model into a DB model as theyre slightly different
            AutoClickDBModel dBModel = _convertModel.ConvertToDBModel(model);

            _sqlDataAccess.SaveData("spInsertDBModel", dBModel);
        }
    }
}
