using System;
using System.Collections.Generic;

namespace TACDataManager.Library.Conversion
{
    public interface IConvertEnum
    {
        string ConvertListOfEnumToString(List<Enum> list);
        List<Enum> ConvertStringToListOfEnum<T>(string str);
        T ConvertStringToEnum<T>(string str);
    }
}