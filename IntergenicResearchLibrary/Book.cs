namespace IntergenicResearchLibrary
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookId { get; set; }

        public Book(string name, string id)
        {
            BookName = name;
            BookId = id;
        }

        public override string ToString()
        {
            return $"Book: {BookName,25}\tID: {BookId,15}";
        }
    }

    

    // public string ToStri
}