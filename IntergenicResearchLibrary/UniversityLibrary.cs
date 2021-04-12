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

            defaulters.Add(new Library("Ladoke Akintola", "2013/14", new Book("Ija irun-mole", "lang-3-08"), new Date(1,1,2013), new Date(1,2,2013)));

            defaulters.Add(new Library("Ahmadu Bello", "2013/14", new Book("The invasion of north", "his-56-089"), new Date(1,1,2014), new Date(1,2,2017)));

            defaulters.Process();
        }
    }
}