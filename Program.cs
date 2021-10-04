using System;
using System.Collections.Generic;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<C_Dictionary> list_dictionary = new();
            List<C_Dictionary> list_dictionary = new List<C_Dictionary>();

            list_dictionary.Add(new C_Dictionary("hi", "дарова"));
            list_dictionary.Add(new C_Dictionary("dima", "дима"));
            list_dictionary.Add(new C_Dictionary("maks", "макс"));
            list_dictionary.Add(new C_Dictionary("button", "батон"));
            list_dictionary.Add(new C_Dictionary("java", "жаба"));
            list_dictionary.Add(new C_Dictionary("namespace", "имя космоса"));

            foreach (var item in list_dictionary)
            {
                Console.WriteLine(item.word1 + "\t\t" + item.word2);
            }
        }
    }

    class C_Dictionary
    {
        public C_Dictionary(string _word1, string _word2)
        {
            word1 = _word1;
            word2 = _word2;
        }

        public string word1;
        public string word2;
    }
}