using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Application.Constants;

namespace TaxiApp.Infraestructure.Log
{
    public class SerilogHelper
    {
        private readonly IConfiguration _configuration;
        public SerilogHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public LoggerConfiguration SerilogConfiguration()
        {
            return new LoggerConfiguration()
                .WriteTo.PostgreSQL(_configuration.GetConnectionString("DefaultConnection"),
                _configuration.GetSection(ConstantsConnection.LogTable).Value,                
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning)                
                .Enrich.FromLogContext();
        }
        
    }
}
