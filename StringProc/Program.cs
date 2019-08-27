using System;
using System.Linq;

namespace StringProc
{
  class Program
  {
    /// <summary>
    /// 4080105 - Lập trình .NET 1 + BTL
    /// GV: Trần Trung Chuyên, email: trantrungchuyen@humg.edu.vn
    /// 03. StringProc - Sử dụng .NET framework với chuỗi và mảng
    /// Mục tiêu:
    /// - Biết cách sử dụng Language Integrated Query (LINQ) trong .NET 
    /// - Biết dùng linq để truy vấn trực tiếp trong C# để lọc các phẩn tử
    ///   ra khỏi mảng.
    /// - Biết chuyển số sang chuỗi
    /// - Biết tìm một chuỗi con trong chuỗi cho trước
    /// </summary>
    /// <param name="args">Tham số khi chạy chương trình</param>
    static void Main(string[] args)
    {
      // Mã hóa output theo Unicode
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      Console.WriteLine("Sử dụng .NET framework với chuỗi và mảng\r");
      Console.WriteLine("----------------------------------------\n");

      // Cho một mảng các số nguyên
      int[] numbers = { 1, 3, 4, 9, 4, 17, 2, 7 };

      // Loại bỏ phần tử có giá trị = 4 ra khỏi mảng bằng cách tạo mảng mới
      // với các phần tử của mảng cũ, trừ ra các phần tử có giá trị = 4
      int numberToRemove = 4;
      int[] numbers1 = numbers.Where(val => val != numberToRemove).ToArray();

      // In ra màn hình mảng mới
      Console.WriteLine("\nMảng sau khi loại các phần tử có giá trị = 4:");
      foreach (int item in numbers1)
      {
        Console.Write($"{item}\t");
      }
      Console.WriteLine();

      // Loại bỏ phần tử có chữ số cuối = 7 ra khỏi mảng bằng cách tạo mảng mới
      // với các phần tử của mảng cũ, trừ ra các phần tử có chữ số cuối = 7
      int[] numbers2 = numbers.Where(val => !IsSevenOfTheLast(val)).ToArray();

      // In ra màn hình mảng mới
      Console.WriteLine("\nMảng sau khi loại các phần tử có số cuối cùng là 7:");
      foreach (int item in numbers2)
      {
        Console.Write($"{item}\t");
      }
      _ = Console.ReadKey();
    }

    /// <summary>
    /// Hàm kiểm tra số có chữ số cuối cùng là 7
    /// </summary>
    /// <param name="n">Số cần kiểm tra</param>
    /// <returns></returns>
    static bool IsSevenOfTheLast(int n)
    {
      string s = n.ToString();
      return s.Substring(s.Length - 1, 1) == "7";
    }
  }
}
