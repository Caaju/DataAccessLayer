using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaajuTI.DAL.Factory
{
    public class CommandFactory
    {
        public static TCommand Build<TCommand>() 
            where TCommand:IDbCommand
        {
            return Activator.CreateInstance<TCommand>();
        }
    }
}
