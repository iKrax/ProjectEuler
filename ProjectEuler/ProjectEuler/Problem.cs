using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem
    {
        public virtual int id { get; protected set; }
        public virtual string name { get; protected set; }
        public virtual string description { get; protected set; }
        public virtual object execute()
        {
            return null;
        }
    }
}
