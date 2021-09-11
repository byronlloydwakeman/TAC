using System.Collections.Generic;

namespace TACDataManager.Library.Conversion
{
    public interface IConvertString
    {
        string ConvertListOfStringToString(List<string> list);
        List<string> ConvertStringToListOfString(string str);
    }
}