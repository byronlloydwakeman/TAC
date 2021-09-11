using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TACDataManager.Library.Conversion
{
    public class ConvertInt : IConvertInt
    {
        public string ConvertListOfIntToString(List<int> list)
        {
            string temp = "";

            foreach (var item in list)
            {
                temp += $"{item};";
            }

            return temp;
        }

        public List<int> ConvertStringToListOfInt(string str)
        {
            List<string> stringList = new List<string>();

            string temp = "";
            foreach (var chr in str)
            {
                if (chr != ';')
                {
                    temp += chr;
                }
                else
                {
                    stringList.Add(temp);
                    temp = "";
                }
            }

            List<int> intList = new List<int>();

            foreach (var item in stringList)
            {
                intList.Add(int.Parse(item));
            }

            return intList;
        }
    }
}
