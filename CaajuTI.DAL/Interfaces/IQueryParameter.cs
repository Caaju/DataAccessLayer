using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaajuTI.DAL.Interfaces
{
    public interface IQueryParameter
    {
        IDictionary<string,object> Get();
    }
}
