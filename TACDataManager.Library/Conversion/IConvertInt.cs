using System.Collections.Generic;

namespace TACDataManager.Library.Conversion
{
    public interface IConvertInt
    {
        string ConvertListOfIntToString(List<int> list);
        List<int> ConvertStringToListOfInt(string str);
    }
}