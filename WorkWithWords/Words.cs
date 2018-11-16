using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WorkWithWords
{
    class Words : Entity

    {
        /// <summary>
        /// Слово в таблице
        /// </summary>
        public virtual string word { get; set; }

        /// <summary>
        /// Часть речи слова
        /// </summary>
        public virtual PartOfSpeech PartOfSpeech { get; set; }

        /// <summary>
        /// Область, к которой относится слово
        /// </summary>
        public virtual Specification specification { get; set; }

        /// <summary>
        /// Промежуток возраста ребенка, для которого предназначено это слово
        /// </summary>
        public virtual ChildrenAge childrenAge { get; set; }



        //   public Words(int ID, string Word, string PartOfSpeech)
        //   {
        //       this.ID = ID;
        //       this.Word = Word;
        ////       this.PartOfSpeech = PartOfSpeech;

        //   }

        //   public int ID { get; set; }
        //   public string Word { get; set; }
        ////   public string PartOfSpeech { get; set; }

        //   public override bool Initialize(DataRow row)
        //   {


        //       return false;
        //   }
    }
}
 