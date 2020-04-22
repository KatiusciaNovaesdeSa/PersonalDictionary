//Katiuscia Novaes de Sa - id.100325522
using System;
using System.Collections.Generic;

namespace PersonalDictionary
{
    public class WordComparer : IComparer<WordInfo>
    {
        public int Compare(WordInfo x, WordInfo y)
        {
            int BeforeOrAfter = x.Word.CompareTo(y.Word);
            return BeforeOrAfter;
        }
    }

}
