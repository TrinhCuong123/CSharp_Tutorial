namespace Tutorial_Csharp
{
  class Lession6
  {
    public void Bai1()
    {
      // Từ polymorphism (tính đa hình) nghĩa là có nhiều hình thái. Trong lập trình hướng đối tượng, tính đa hình thường được diễn đạt như là "một Interface, nhiều hàm".
      // Tính đa hình trong C# có thể là static hoặc dynamic. Trong đó, kiểu đa hình static có thể được gọi là đa hình tĩnh và kiểu đa hình dynamic có thể được gọi là đa hình động.
      // Trong đa hình tĩnh, phần phản hồi tới một hàm được xác định tại compile time. Trong khi đó với đa hình động, nó được quyết định tại runtime.
    }
  }


  class TestCsharp
  {
    // Xử lý ngoại lệ ( Exception Handling) trong C#
    // C# cung cấp một giải pháp mang tính cấu trúc cao để xử lý ngoại lệ trong form các khối try và catch. Sử dụng các khối này, các lệnh chương trình được phân biệt riêng rẽ với các lệnh xử lý ngoại lệ trong C#.

    // Những khối xử lý ngoại lệ này được triển khai bởi sử dụng các từ khóa try, catch và finally trong C#. Ví dụ sau ném một exception khi chia cho số 0.
    int result;
    public TestCsharp()
    {
      result = 0;
    }
    public void phepChia(int num1, int num2)
    {
      try
      {
        result = num1 / num2;
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine("Bat Exception: {0}", e);
      }
      finally
      {
        Console.WriteLine("Ket qua: {0}", result);
      }
    }
  }
}