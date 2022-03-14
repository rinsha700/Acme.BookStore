using Acme.BookStore.Books;

namespace Acme.BookStore.UserTypes
{
    public class CombainedData
    {
        public BookDto Book { get; set; }
        public UserTypeDto UserType { get; set; }
    }
}