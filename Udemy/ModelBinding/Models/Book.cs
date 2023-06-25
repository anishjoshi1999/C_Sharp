using Microsoft.AspNetCore.Mvc;
namespace ModelBinding.Models
{
    public class Book
    {
        //[FromQuery]
        public int? BookId { get; set; }
        public string? Author { get; set; }
        public override string ToString()
        {
            return $"Book Object - Book id: {this.BookId}, Author: {this.Author}";
        }
    }
}
