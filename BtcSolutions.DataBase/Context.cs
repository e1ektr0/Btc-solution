using System.Data.Entity;
using BtcSolutions.DataBase.Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BtcSolutions.DataBase.Connection
{
    /// <summary>
    /// Контекст для работы с базой данный
    /// Заточен под code first
    /// Соединён с membership
    /// </summary>
    public class Context : IdentityDbContext<MembershipUser>
    {
        public Context()
            : base("DefaultConnection")
        {
            //Содаёт базу если её нет
            Database.SetInitializer(new DbInitializer());
        }
    }
}
