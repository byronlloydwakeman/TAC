using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.Models.Enums;

namespace TACDataManager.Library.Conversion
{
    public class ConvertEnum : IConvertEnum
    {
        public string ConvertListOfEnumToString(List<Enum> list)
        {
            string toReturn = "";

            if (list != null)
            {
                foreach (var item in list)
                {
                    toReturn += $"{item};";
                }
            }

            return toReturn;
        }

        public List<Enum> ConvertStringToListOfEnum<T>(string str)
        {
            List<Enum> toReturn = new List<Enum>();

            string temp = "";
            foreach (var chr in str)
            {
                if (chr != ';')
                {
                    temp += chr;
                }
                else
                {
                    toReturn.Add(Enum.Parse(typeof(T), temp) as Enum);
                    temp = "";
                }
            }

            return toReturn;
        }

        public T ConvertStringToEnum<T>(string str)
        {
            return (T)Enum.Parse(typeof(T), str);
        }
    }
}
