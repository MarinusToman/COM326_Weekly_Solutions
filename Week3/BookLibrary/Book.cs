/*
 * Book.cs
 *  
 * Version information
 * Author: Marinus Toman
 * Date:   10/10/23
 * 
 * Copyright notice
 */

namespace BookLibrary
{
    public class Book
    {
        private string title;
        private string author;
        private string genre;
        private int isbn;
        private int year;
        private string publisher;
        private static int bookCount = 0;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int Isbn
        {
            get { return isbn; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public Book()
        {
            isbn = ++bookCount;
            title = string.Empty;
            author = string.Empty;
            publisher = string.Empty;
            genre = string.Empty;
            year = 0;
        }
        public Book(string title, string author, string genre, int year, string publisher)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            isbn = ++bookCount;
            this.year = year;
            this.publisher = publisher;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Book details:{isbn}: {title}, by {author}, published in {year} by {publisher}, in the {genre} genre");
        }
    }
}