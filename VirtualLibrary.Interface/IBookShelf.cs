using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualLibrary.Interface
{
    public interface IBookShelf
    {


        //C.R.U.D.

        IEnumerable<Book> GetBooks(); //r
        Book GetBook(int id); //r
        void AddBook(Book newBook); //c
        void UpdateBook(int id, Book updatedBook); //u
        void DeleteBook(int id); //d





    }
}
