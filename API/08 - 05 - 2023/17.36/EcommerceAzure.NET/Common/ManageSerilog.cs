using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Serilog;

namespace Common.Serilog
{
    public class ManageSerilog
    {
        public static void LogError(string UtenteLoggato, string NameSpace, string Message)
        {
            Log.Logger.Error(string.Format("{0} {1} - {2}", UtenteLoggato, NameSpace, Message));
        }
    }
}
