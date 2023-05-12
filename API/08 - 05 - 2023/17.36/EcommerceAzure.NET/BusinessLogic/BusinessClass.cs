using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Models.StoredProceduresResult;
using Models.Tabelle;

namespace BusinessLogic
{
    public class BusinessClass : IBusiness 
    {
        IDAL Dal;

        public BusinessClass(IDAL Dal)
        {
            this.Dal = Dal;
        }
    }
}
