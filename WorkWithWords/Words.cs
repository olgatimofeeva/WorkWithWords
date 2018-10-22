using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithWords
{
    class Words
    {
        public Words(int ID, string Word, string PartOfSpeech)
        {
            this.ID = ID;
            this.Word = Word;
            this.PartOfSpeech = PartOfSpeech;

        }

        public int ID { get; set; }
        public string Word { get; set; }
        public string PartOfSpeech { get; set; }
    }
}
 