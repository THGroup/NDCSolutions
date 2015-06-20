using System.Data.Entity;
using Contract.Models;

namespace DataAccess.JSR
{
    public class JSRDataContext : DbContext
    {
        public JSRDataContext(string demoConnectionString): base(demoConnectionString)
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new NullDatabaseInitializer<JSRDataContext>());
        }

        public virtual IDbSet<Alert> Alerts { get; set; }

    }
}
