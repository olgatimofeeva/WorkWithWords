using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WorkWithWords
{
    public abstract class Entity 
    {
        public virtual int Id { get; set; }

        public bool IsNew => Id == default(int);

        //public Int32 Code { get; protected set; }

        //public abstract bool Initialize(DataRow row);
    }
}
