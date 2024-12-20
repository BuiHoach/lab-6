using System.Text;

namespace lab_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Khởi tạo danh sách 10 chiếc xe
            List<Car> cars = new List<Car>
        {
            new Car("Car 1", "Red"),
            new Car("Car 2", "Blue"),
            new Car("Car 3", "Green"),
            new Car("Car 4", "Red"),
            new Car("Car 5", "Yellow"),
            new Car("Car 6", "Red"),
            new Car("Car 7", "Black"),
            new Car("Car 8", "White"),
            new Car("Car 9", "Red"),
            new Car("Car 10", "Blue")
        };

            // Xóa các Car có màu "Red"
            cars.RemoveAll(car => car.Color == "Red");

            // In danh sách các Car còn lại
            Console.WriteLine("Danh sách các xe còn lại:");
            foreach (var car in cars)
            {
                car.DisplayInfo();
            }
        }
    }
}
