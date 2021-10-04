using System;
using System.Collections.Generic;
using System.Linq;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<C_Dictionary> list_dictionary = new();

            list_dictionary.Add(new C_Dictionary("hi", "дарова"));
            list_dictionary.Add(new C_Dictionary("dima", "дима"));
            list_dictionary.Add(new C_Dictionary("maks", "макс"));
            list_dictionary.Add(new C_Dictionary("button", "батон"));
            list_dictionary.Add(new C_Dictionary("java", "жаба"));
            list_dictionary.Add(new C_Dictionary("namespace", "космос в имени"));
            list_dictionary.Add(new C_Dictionary("minecraft", "ремесло в шахте"));

            foreach (var item in list_dictionary.OrderBy(x => x._word1))
            {
                Console.WriteLine(item._word1 + "\t\t" + item._word2);
            }
        }
    }

    class C_Dictionary
    {
        public string _word1 { get; set; }
        public string _word2 { get; set; }

        public C_Dictionary(string word1, string word2)
        {
            this._word1 = word1;
            this._word2 = word2;
        }
    }
}