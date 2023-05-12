using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContext;
using Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models.StoredProceduresResult;
using Models.Tabelle;

namespace DataAccessLogic
{
    public class DALClass : IDAL
    {
        EcommerceAzureContext Context;
        public DALClass(EcommerceAzureContext Context)
        {
            this.Context = Context;
        }
    }
}
