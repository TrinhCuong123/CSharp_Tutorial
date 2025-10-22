namespace Tutorial_Csharp
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void Main(string[] args)
        {
            // Console.WriteLine("Bài 1");
            // Lession1 lession1 = new Lession1();
            // lession1.Bai1(); // Gọi phương thức Bai1() từ đối tượng

            // Console.WriteLine();
            // Console.WriteLine("Bài 2");
            // Lession2_Rectangle rectangle = new Lession2_Rectangle();
            // rectangle.Acceptdetails(); // Gọi phương thức AcceptDetails() từ đối tượng
            // rectangle.DisplayArea(); // Gọi phương thức DisplayArea() từ đối tượng

            // Console.WriteLine();
            // Console.WriteLine("Bài 3");
            // Lession3 lession3 = new Lession3();
            // lession3.Bai1(); // Gọi phương thức Bai1() từ đối tượng

            // Console.WriteLine();
            // Console.WriteLine("Bài 4");
            // // Sử dụng enum Days
            // Console.WriteLine("Enum trong C#");
            // Console.WriteLine("------------------------\n");

            // int dau_tuan = (int)Days.Mon;
            // int cuoi_tuan = (int)Days.Fri;
            // Console.WriteLine("Thu hai: {0}", dau_tuan);
            // Console.WriteLine("Thu sau: {0}", cuoi_tuan);


            // Console.WriteLine();
            // Console.WriteLine("Bài 5");
            // Console.WriteLine("Constructor trong C#");
            // Console.WriteLine("---------------------");
            // //tao doi tuong Line bang constructor
            // Line line = new Line(10.0);
            // Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());

            // // thiet lap chieu dai cho duong
            // line.setChieuDai(6.0);
            // Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());


            // Console.WriteLine();
            // Console.WriteLine("Bài 6");
            // Lession5 lession5 = new Lession5();
            // lession5.Bai1(); // Gọi phương thức Bai1() từ đối tượng

            Console.WriteLine();
            Console.WriteLine("Bài 7");
            TestCsharp d = new TestCsharp();
            d.phepChia(25, 0); // Gọi phương thức Bai1() từ đối tượng
        }
    }
}
