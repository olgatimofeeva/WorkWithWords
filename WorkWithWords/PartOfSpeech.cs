using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithWords
{
    class PartOfSpeech
    {

        public PartOfSpeech(int ID, string partOfspeech)
        {
            this.ID = ID;
            this.partOfspeech = partOfspeech;

        }

        public int ID { get; set; }
        public string partOfspeech { get; set; }
    }
}
