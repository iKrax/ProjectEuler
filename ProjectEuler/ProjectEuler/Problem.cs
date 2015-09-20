using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem
    {
        public virtual string name { get; protected set; }
        public virtual string description { get; protected set; }
        public virtual object execute()
        {
            return null;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", name, description);
        }
    }
}
