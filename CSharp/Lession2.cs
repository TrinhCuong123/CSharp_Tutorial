namespace Tutorial_Csharp
{
  class Lession2_Rectangle
  {
    private double Length { get; set; }
    private double Width { get; set; }

    public void Acceptdetails()
    {
      Console.WriteLine("Nhap chieu dai: ");
      Length = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Nhap chieu rong: ");
      Width = Convert.ToDouble(Console.ReadLine());
    }

    public double CalculateArea()
    {
      return Length * Width;
    }

    public void DisplayArea()
    {
      Console.WriteLine("Chieu dai: " + Length);
      Console.WriteLine("Chieu rong: " + Width);
      Console.WriteLine("Dien tich hinh chu nhat: " + CalculateArea());
    }
  }
}