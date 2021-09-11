using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.AutoFac;
using TACDataManager.Library.Conversion;
using TACDataManager.Library.DataAccess;
using TACDataManager.Library.Models;
using TACDataManager.Library.Models.Enums;

namespace TACDataManager.Library.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ILifetimeScope scope = DataManagerContainerConfig.Configure().BeginLifetimeScope())
            {
                //Test AutoClickData
                var autoClickData = scope.Resolve<IAutoClickData>();

                //Getting models from the database -Works as of 24 / 07 / 21
                var models = autoClickData.GetAutoClickModelsByBoss(EnumBoss.EyeOfCluthulu);

               

                //Inserting models into the database
                //autoClickData.InsertAutoClickDBModel(new AutoClickBEModel()
                //{
                //    MinHealth = 400,
                //    MinMana = 200,
                //    Weapons = new List<Enum>() { EnumWeapons.CopperShortSword },
                //    Boss = EnumBoss.EyeOfCluthulu,
                //    SequenceOfMoves = new MoveModel() { Moves = new List<string>() { "A", "D", "S", "LEFT" }, Timing = new List<int>() { 100, 50, 100, 60 } }
                //});
            }

            ////ConvertEnum convertEnum = new ConvertEnum();
            //new List<Enum>() { EnumBoss.EyeOfCluthulu, EnumBoss.EyeOfCluthulu };
            //List<Enum> bosses = new List<Enum>()
            //{
            //    EnumBoss.EyeOfCluthulu
            //};

            ////Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
