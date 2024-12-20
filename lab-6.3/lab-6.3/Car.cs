using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6._3
{
    internal class Car
    {
        // Các trường thông tin của xe
        public string Name { get; set; }
        public string Color { get; set; }

        // Constructor khởi tạo đối tượng Car
        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }

        // Phương thức hiển thị thông tin của xe
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}");
        }
    }
}

