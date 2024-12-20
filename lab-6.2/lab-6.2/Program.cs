using System.Collections;
using System.Text;

namespace lab_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Tạo một Hashtable lưu trữ danh sách các ngày trong tuần
            Hashtable daysOfWeek = new Hashtable()
        {
            { 1, "Monday" },
            { 2, "Tuesday" },
            { 3, "Wednesday" },
            { 4, "Thursday" },
            { 5, "Friday" },
            { 6, "Saturday" },
            { 7, "Sunday" }
        };

            // Tìm ngày "Tuesday" trong Hashtable
            string dayToFind = "Tuesday";
            bool found = false;

            foreach (DictionaryEntry entry in daysOfWeek)
            {
                if ((string)entry.Value == dayToFind)
                {
                    Console.WriteLine($"Found {dayToFind} on key {entry.Key}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{dayToFind} not found.");
            }

            // In ra tất cả các ngày trong tuần bao gồm cả key và value
            Console.WriteLine("\nDanh sách các ngày trong tuần:");
            foreach (DictionaryEntry entry in daysOfWeek)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}