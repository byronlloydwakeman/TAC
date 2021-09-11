using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACDataManager.Library.Conversion
{
    public class ConvertString : IConvertString
    {
        public string ConvertListOfStringToString(List<string> list)
        {
            string temp = "";

            foreach (var item in list)
            {
                temp += $"{item};";
            }

            return temp;
        }

        public List<string> ConvertStringToListOfString(string str)
        {
            List<string> toReturn = new List<string>();

            string temp = "";

            foreach (var chr in str)
            {
                if (chr != ';')
                {
                    temp += chr;
                }
                else
                {
                    toReturn.Add(temp);
                    temp = "";
                }
            }

            return toReturn;
        }
    }
}
