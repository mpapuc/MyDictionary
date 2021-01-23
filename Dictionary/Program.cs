using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Book", "Kitap");
            myDictionary.Add("Table", "Masa");
            myDictionary.Add("Notebook", "Defter");
            myDictionary.Add("Paper", "Kağıt");
            myDictionary.Add(Console.ReadLine(),Console.ReadLine());
            
            foreach (var Eng in myDictionary.Eng)
            {
                Console.WriteLine(Eng);
                
            }
            foreach (var Tur in myDictionary.Tur)
            {
                Console.WriteLine(Tur);
            }

            Console.WriteLine(myDictionary.Count);
        }
    }
}
