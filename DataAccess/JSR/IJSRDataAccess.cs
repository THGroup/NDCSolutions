using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contract.Models;

namespace DataAccess.JSR
{
    public interface IJSRDataAccess : IDisposable
    {
        JSRDataContext DataContext { get; set; }
        Task<List<Alert>> GetAlertsAsync();
    }
}
