namespace Tutorial_Csharp
{

  class Shape
  {
    protected double length;
    protected double width;

    public void setChieuRong(double w)
    {
      width = w;
    }

    public void setChieuDai(double l)
    {
      length = l;
    }
  }

  class Rectangle : Shape
  {
    public double CalculateArea()
    {
      return length * width;
    }

    public void DisplayArea()
    {
      Console.WriteLine("Chieu dai: " + length);
      Console.WriteLine("Chieu rong: " + width);
      Console.WriteLine("Dien tich hinh chu nhat: " + CalculateArea());
    }
  }

  class Lession5
  {
    public void Bai1()
    {
      Console.WriteLine("Tinh ke thua trong C#");
      Console.WriteLine("------------------------\n");

      //tao doi tuong HinhChuNhat
      Rectangle hcn = new Rectangle();

      hcn.setChieuRong(5);
      hcn.setChieuDai(7);

      // in dien tich cua doi tuong.
      hcn.DisplayArea();
    }
  }
}