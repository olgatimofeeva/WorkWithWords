using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithWords
{
    interface IComplexEntity
    {
        bool Initialize(System.Data.DataRow row);
    }
}
