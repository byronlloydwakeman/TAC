using TACDataManager.Library.Models;

namespace TACDataManager.Library.Conversion
{
    public interface IConvertModel
    {
        AutoClickBEModel ConvertToBEModel(AutoClickDBModel model);
        AutoClickDBModel ConvertToDBModel(AutoClickAPIModel model);
    }
}