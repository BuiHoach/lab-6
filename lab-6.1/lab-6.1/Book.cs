using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6._1
{
    internal class Book
    {
        // Các trường thông tin của sách
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Constructor khởi tạo đối tượng Book
        public Book(int id, string title, string author, string publisher, int year, double price)
        {
            Id = id;
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            Price = price;
        }

        // Phương thức hiển thị thông tin sách
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {Author}, Publisher: {Publisher}, Year: {Year}, Price: {Price}");
        }
    }
}

