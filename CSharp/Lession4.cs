namespace Tutorial_Csharp
{
  class Line
  {
    private double chieu_dai;
    public Line(double len)
    {
      Console.WriteLine("Doi tuong dang duoc tao, chieu dai = {0}", len);
      chieu_dai = len;
    }

    ~Line() // destructor
    {
      Console.WriteLine("Doi tuong dang bi xoa!!!");
    }

    public void setChieuDai(double len)
    {
      chieu_dai = len;
    }

    public double getChieuDai()
    {
      return chieu_dai;
    }

  }
}