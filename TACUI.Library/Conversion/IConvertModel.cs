using TACUI.Library.Models;

namespace TACUI.Library.Conversion
{
    public interface IConvertModel
    {
        AutoClickAPIModel ConvertUIModelToAPIModel(AutoClickUIModel autoClickUIModel);
    }
}