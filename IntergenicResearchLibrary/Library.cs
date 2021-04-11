using System.Collections.Generic;

namespace IntergenicResearchLibrary
{
    public class Library
    {
        public string Name { get; set; }
        public string YearOfStudy { get; set; }
        public List<string> Book { get; set; }
        public Date Issued { get; set; }    
        public Date Returned { get; set; }
        public string NameNotReturned { get; set; }

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
            return $"Book: {Book[0]}\nID: {Book[1]}";
        }
        public Date GetDateIssued()
        {
            return Issued;
        }

        public Date GetDateReturn()
        {
            return Returned;
        }

        public void GetDefaulters()
        {
            // Execution unknown
        }         
        
    }
}