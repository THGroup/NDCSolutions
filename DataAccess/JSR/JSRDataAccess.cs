using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Contract.Models;

namespace DataAccess.JSR
{
    public class JSRDataAccess: IJSRDataAccess
    {
        public JSRDataContext DataContext { get; set; }

        protected volatile Type Dependency;

        public JSRDataAccess(JSRDataContext context)
        {
            DataContext = context;
        }

        public JSRDataAccess()
        {
            //Fix EF bugs which regards to message: "No Entity Framework provider found for the ADO.NET provider with invariant name 'System.Data.SqlClient'. Make sure the provider is registered in the 'entityFramework' section of the application config file. See http://go.microsoft.com/fwlink/?LinkId=260882 for more information."
            Dependency = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            string jsrConnectionString = ConfigurationManager.ConnectionStrings["JSRConnection"].ConnectionString;            
            DataContext = new JSRDataContext(jsrConnectionString);
        }

        public Task<List<Alert>> GetAlertsAsync()
        {
            try
            {
                return DataContext.Alerts.ToListAsync();
            }
            catch (Exception e)
            {
                var err = e.Message;
            }

            return null;
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && this.DataContext != null)
            {
                DataContext.Dispose();
            }
        }
        #endregion

    }
}
