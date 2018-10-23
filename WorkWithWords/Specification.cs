using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithWords
{
    class Specification
    {

        public Specification(int ID, string specification)
        {
            this.ID = ID;
            this.specification = specification;

        }

        public int ID { get; set; }
        public string specification { get; set; }


    }
}
