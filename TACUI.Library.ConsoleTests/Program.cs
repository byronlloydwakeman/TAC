using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TACDataManager.Library.Models;
using TACDataManager.Library.Models.Enums;
using TACUI.Library.AutoFac;
using TACUI.Library.Endpoints;
using TACUI.Library.Models;
using TACUIController;

namespace TACUI.Library.ConsoleTests
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (ILifetimeScope scope = UIContainerConfig.Configure().BeginLifetimeScope())
            {
                var apiHelper = scope.Resolve<IAPIHelper>();
                await apiHelper.Login("someEmail@gmail.com", "Password123");
                //apiHelper.Logout();

                var autoClick = scope.Resolve<IAutoClickEndpoint>();
                var models = autoClick.GetModelsWithGivenBoss(EnumBoss.EyeOfCluthulu);
                //await autoClick.InsertAutoClickModel(new AutoClickUIModel()
                //{
                //    MinHealth = 400,
                //    MinMana = 200,
                //    Weapons = new List<Enum>() { EnumWeapons.CopperShortSword },
                //    Boss = EnumBoss.EyeOfCluthulu,
                //    SequenceOfMoves = new MoveModel() { Moves = new List<string>() { "A", "D", "SPACE", "LEFT" }, Timing = new List<int>() { 100, 200, 50, 100 } },
                //    Potions = new List<Enum>() { EnumPotion.IronSkin, EnumPotion.Swiftness }
                //});
            }
  
        }
    }
}
