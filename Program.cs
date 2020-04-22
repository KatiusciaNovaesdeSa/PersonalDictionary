//Katiuscia Novaes de Sa - id.100325522
using System;
using System.Collections.Generic;

namespace PersonalDictionary
{

    class Program
    {
        static SortedSet<WordInfo> List = new SortedSet<WordInfo>(new WordComparer());

        static void Main(string[] args)
        {
            Dictionary _dict = new Dictionary();

            int choice;
            string word, meaning;

            while (true)
            {
                Console.WriteLine("Personal Dictionary:");
                Console.WriteLine("*********************");
                Console.WriteLine("1. Add new word ");
                Console.WriteLine("2. Delete word ");
                Console.WriteLine("3. Get meaning ");
                Console.WriteLine("4. Number of words in the Dictionary ");
                Console.WriteLine("5. Word list ");
                Console.WriteLine("6. Print Dictionary "); 
                Console.WriteLine("7. Exit ");

                Console.WriteLine("Enter your choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    choice = 0;
                }

                if (choice == 7)
                    break;

                switch (choice)
                {

                    case 0:
                        Console.WriteLine("Only numbers allowed");
                        break;

                    case 1:
                        Console.Write("Enter a word to be added to the Dictionary: ");
                        word = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter word meaning to be added to the Dictionary: ");
                        meaning = Convert.ToString(Console.ReadLine());

                        bool inserted = _dict.AddWord(word, meaning);
                        if (inserted)
                        {
                            Console.WriteLine("Word inserted");
                        }
                        else
                        {
                            Console.WriteLine("No duplicate words are allowed: " + word);
                        }
                        break;


                    case 2:
                        Console.Write("Enter a word to be deleted from the Dictionary: ");
                        word = Convert.ToString(Console.ReadLine());

                        bool deleted = _dict.DeleteWord(word);
                        if (deleted)
                        {
                            Console.WriteLine("Word deleted" + word);
                        }
                        else
                        {
                            Console.WriteLine("Word not found: " + word);
                        }
                        break;

                    case 3:
                        Console.Write("Enter the word to see the meaning: ");
                        word = Convert.ToString(Console.ReadLine());
                        _dict.GetMeaning(word);
                        break;

                   
                   case 4:
                        Console.Write("Number of words in the dictionary: " + _dict.GetCount());
                        break;


                    case 5:
                        Console.Write("Word List is : \n");
                        List<String> WordList = _dict.PrintWordList();

                        foreach (String _word in WordList)
                        {
                            Console.WriteLine(_word);
                        }
                        break;

                    case 6:
                        _dict.PrintDictionary();
                        break;

                    case 7:
                        break;



                    default:
                        Console.WriteLine("Wrong choice");
                        break;

                }
                Console.WriteLine();

            }
            Console.WriteLine("Exiting");

        }
    }
}
