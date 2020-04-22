//Katiuscia Novaes de Sa - id.100325522
using System;
using System.Collections;
using System.Collections.Generic;

namespace PersonalDictionary
{
    class Dictionary
    {
        public static SortedSet<WordInfo> List = new SortedSet<WordInfo>(new WordComparer());


        public Dictionary()
        {
        }

        // add word
        public bool AddWord(string _inputWord, string _inputMeaning)
        {
            if (List != null)
            {
                return List.Add(new WordInfo { Word = _inputWord, Meaning = _inputMeaning });
            }
            return false;
        }

        //delete word
        public bool DeleteWord(string _inputWord)
        {
            WordInfo tmpObj = new WordInfo { Word = _inputWord, Meaning = "" };
            if (List != null)
            {
                return List.Remove(tmpObj);
            }
            return false;
        }

        //print dictionary list
        public void PrintDictionary()
        {
            if (List != null)
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("List is empty.");
                }
                Console.Write("Word + Meaning is : \n");
                foreach (WordInfo item in List)
                {
                    Console.WriteLine(item.Word + " + " + item.Meaning);
                }
                Console.WriteLine();

            }
            return;
        }

        //print word list
        public List<String> PrintWordList()
        {
            List<String> ListWords = new List<String>();

            if (List != null)
            {
                if (List.Count == 0)
                {
                    ListWords.Add("List is empty.");
                }
                else
                {
                    foreach (WordInfo item in List)
                    {
                        ListWords.Add(item.Word);
                    }
                }



            }
            return ListWords;
        }




        //get word meaning
        public String GetMeaning(String word)
        {
            if (List != null)
            {
                if (List.Count == 0)
                {
                    return "List is empty.";
                }
                WordInfo wordSearch = new WordInfo { Word = word, Meaning = "" };
                //foreach (WordInfo item in List) 
                //{
                //    List.Comparer
                //}

                WordInfo testArray = new WordInfo { Word = word, Meaning = "" };

                //testArray[0] = new WordInfo { Word = word, Meaning = "" };


                WordInfo[] wordArray = new WordInfo[List.Count];
                List.CopyTo(wordArray);
                //int myIndex = Array.BinarySearch(wordArray, wordSearch);
                int myIndex = Array.BinarySearch(wordArray, testArray);
                //int myIndex = wordArray.BinarySearch(testArray, new WordComparer());

                Console.WriteLine(myIndex);
                Console.WriteLine();

            }
            return "";
        }



        //count number of words in the dictionary
        public int GetCount()
        {
            if (List != null)
            {
                return List.Count;
            }
            else
            {
                return 0;
            }


        }


    }
}
