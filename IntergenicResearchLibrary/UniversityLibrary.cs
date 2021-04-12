using System;
using System.Collections.Generic;


namespace IntergenicResearchLibrary
{
    public class UniversityLibrary
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello University World!");
            var defaulters = new GenericDefaulterList<Library>();

            defaulters.Add(new Library("Ladoke Akintola", "2013/14", new Book("Ija irun-mole", "lang-3-08"), new Date(1,1,2013)));

            defaulters.Add(new Library("Ahmadu Bello", "2013/14", new Book("The invasion of north", "his-56-089"), new Date(28,1,2014)));

            defaulters.Process();
            // var date = new DateTime(2021,3,2).AddDays(50);
            // var date2 = new Date(1,3,2021).AddDays(50);
            // Console.WriteLine(date2);
        }
    }
}