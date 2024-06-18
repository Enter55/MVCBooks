using BooksWorldMVC.com.Models.Base;

namespace BooksWorldMVC.com.Models
{
    public class Book : BaseModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }
    }
}
