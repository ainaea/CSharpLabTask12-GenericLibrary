using System.Collections.Generic;

namespace IntergenicResearchLibrary
{
    public class Library : IDefaulterList
    {
        public string Name { get; set; }
        public string YearOfStudy { get; set; }
        public Book Booked { get; set; }
        public Date Issued { get; set; }    
        public Date Returned { get; set; }
        // public string NameNotReturned { get; set; }

        public Library(string name, string year, Book book, Date issued)
        {
            Name = name;
            YearOfStudy = year;
            Booked = book;
            Issued = issued;
            Returned = Issued.AddDays(7);
        }

        public string GetName()
        {
            return Name;
        }
        public string GetYear()
        {
            return YearOfStudy;
        }
        public string GetBook()
        {
            return $"{Booked}";
        }
        public Date GetDateIssued()
        {
            return Issued;
        }

        public Date GetDateReturn()
        {
            return Returned;
        }

        public string GetDefaulters()
        {
            return $"{Name,15}\t {Booked}\t {Issued}\t {Returned}";
        }         
        
    }
}