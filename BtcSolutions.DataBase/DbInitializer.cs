using System.Data.Entity;

namespace BtcSolutions.DataBase.Connection
{
    /// <summary>
    /// Инициализатор базы данных
    /// </summary>
    public class DbInitializer : CreateDatabaseIfNotExists<Context>
    {

    }
}