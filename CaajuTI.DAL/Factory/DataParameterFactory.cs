using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaajuTI.DAL.Factory
{
    class DataParameterFactory
    {
        static bool success;
        public static TDataParameter Builder<TDataParameter>(string paramaterName,object value)
            where TDataParameter:new()
        {
            return (TDataParameter)Activator.CreateInstance(typeof(TDataParameter), paramaterName, value);
        }
    }
}
