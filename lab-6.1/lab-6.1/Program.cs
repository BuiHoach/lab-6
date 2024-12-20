using System.Text;

namespace lab_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Tạo một danh sách sách
            List<Book> books = new List<Book>
        {
            new Book(1, "Book A", "Author A", "Nhi Dong", 2014, 150.0),
            new Book(2, "Book B", "Author B", "NXB X", 2015, 120.0),
            new Book(3, "Book C", "Author C", "Nhi Dong", 2014, 200.0),
            new Book(4, "Book D", "Author D", "NXB Y", 2016, 180.0),
            new Book(5, "Book E", "Author E", "NXB X", 2014, 220.0),
            new Book(6, "Book F", "Author F", "NXB Z", 2017, 300.0),
            new Book(7, "Book G", "Author G", "Nhi Dong", 2018, 90.0),
            new Book(8, "Book H", "Author H", "NXB Z", 2019, 50.0),
            new Book(9, "Book I", "Author I", "NXB X", 2020, 120.0),
            new Book(10, "Book J", "Author J", "NXB Y", 2021, 250.0)
        };

            // In danh sách sách tăng dần theo giá
            Console.WriteLine("Danh sách sách tăng dần theo giá:");
            var sortedBooksByPrice = books.OrderBy(b => b.Price).ToList();
            foreach (var book in sortedBooksByPrice)
            {
                book.DisplayInfo();
            }

            // Tìm quyển sách theo title nhập từ bàn phím
            Console.Write("\nNhập tiêu đề sách để tìm: ");
            string searchTitle = Console.ReadLine();
            var foundBooks = books.Where(b => b.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine($"\nSách có tiêu đề chứa '{searchTitle}':");
            foreach (var book in foundBooks)
            {
                book.DisplayInfo();
            }

            // Lọc các quyển sách xuất bản năm 2014
            var books2014 = books.Where(b => b.Year == 2014).ToList();
            Console.WriteLine("\nCác quyển sách xuất bản năm 2014:");
            foreach (var book in books2014)
            {
                book.DisplayInfo();
            }

            // Xóa các quyển sách của nhà xuất bản "Nhi Dong"
            books.RemoveAll(b => b.Publisher == "Nhi Dong");
            Console.WriteLine("\nDanh sách sách sau khi xóa các sách của nhà xuất bản 'Nhi Dong':");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }
    }
}
