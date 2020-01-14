using System;

namespace _38.uzd_names_array_surnames_array_together
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Janis", "Aivis", "Ance", "Andris", "Juris", "Gusts", "Arnis", "Anna", "John", "Liga" };
            string[] surnames = { "Berzs", "Ozols", "Lapa", "Bozis", "Drinks", "Links", "Babuls", "Honda", "Deel", "Rasa" };

            string[] persons = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                persons[i] = names[i] + " " + surnames[i];
            }

            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
// Ir definēti divi string tipa masīvi, pirmajā masīvā atrodas cilvēku vārdi, otrajā cilvēku uzvārdi.
// Abu masīvu lielums ir identisks(10 ieraksti). 
// Izveidot tādu programmu, kur Vārdi un Uzvārdi tiek apvienoti vienā masīvā un izdrukāti uz ekrāna.
