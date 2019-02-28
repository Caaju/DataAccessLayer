using CaajuTI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaajuTI.DAL.Implements
{
    public class QueryParameter : IQueryParameter
    {
        public object this[string index]
        {
            set
            {
                _parameters.Add(index, value);
            }
        }
        readonly IDictionary<string, object> _parameters;

        public QueryParameter()
        {
            _parameters = new Dictionary<string,object>();
        }
        
        public IDictionary<string, object> Get()
        {
            return _parameters;
        }
    }
}
