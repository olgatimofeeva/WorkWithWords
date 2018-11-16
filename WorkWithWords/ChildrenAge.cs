using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithWords
{
    class ChildrenAge
    {
        /// <summary>
        /// Промежуток возраста ребенка, для которого предназначено это слово
        /// </summary>
        public string childrenAge;

        public ChildrenAge(int ID, string childrenAge)
        {
            this.ID = ID;
      //      this.childrenAge = childrenAge;

        }

        public int ID { get; set; }
     //   public string childrenAge { get; set; }

    }
}
