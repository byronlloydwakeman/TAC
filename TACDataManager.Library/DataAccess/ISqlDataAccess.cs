using System.Collections.Generic;

namespace TACDataManager.Library.DataAccess
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string storedProcedure, U parameters);
        void SaveData<T>(string storedProcedure, T parameters);
    }
}