namespace HomeLibrary.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? Series { get; set; }
        public string? Classification { get; set; }
        public bool? HaveRead { get; set; }
        public Book()
        {

        }

    }
}
