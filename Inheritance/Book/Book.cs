using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        private string author;

        public string Author
        {
            get { return author; }
            set
            {
                if (AuthorCheck(value))
                {
                    InvalidInput("Author not valid!");
                }
                this.author = value;
            }
        }


        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    InvalidInput("Title not valid!");
                }
                title = value;
            }
        }


        private double price;

        public virtual double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    InvalidInput("Price not valid!");
                }
                price = value;
            }
        }

        public Book(string author, string title, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;

        }




        private void InvalidInput(string v)
        {
            throw new ArgumentException(v);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Title: {this.Title}");
            sb.AppendLine($"Author: {this.Author}");
            sb.AppendLine($"Price: {this.Price:F2}");

            return sb.ToString().TrimEnd();
        }

        private bool AuthorCheck(string value)
        {
            if (!value.Contains(" "))
            {
                return false;
            }

            string[] split = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (char.IsDigit(split[1][0]))
            {
                return true;
            }

            return false;
        }
    }
}
