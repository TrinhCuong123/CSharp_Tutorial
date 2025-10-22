namespace Tutorial_Csharp
{
  struct Lession3_Struct
  {
    public string ten_sach;
    public string tac_gia;
    public string the_loai;
    public int ma_sach;
  }

  class Lession3
  {
    public void Bai1()
    {
      Console.WriteLine("Struct trong C#");
      Console.WriteLine("----------------------------\n");

      Lession3_Struct Book1;   /* khai bao Book1 thuoc kieu cau truc Book */
      Lession3_Struct Book2;   /* khai bao Book2 thuoc kieu cau truc Book */

      /* thong tin chi tiet ve Book1 */
      Book1.ten_sach = "English Grammar in Use";
      Book1.tac_gia = "Raymond Murphy";
      Book1.the_loai = "Tieng Anh";
      Book1.ma_sach = 6495407;

      /* thong tin chi tiet ve Book2 */
      Book2.ten_sach = "Toan hoc cao cap";
      Book2.tac_gia = "Tran Van A";
      Book2.the_loai = "Toan hoc";
      Book2.ma_sach = 6495700;

      /* in cac thong tin cua Book1*/
      Console.WriteLine("In thong tin cua cuon sach 1:");
      Console.WriteLine("Ten sach: {0}", Book1.ten_sach);
      Console.WriteLine("Tac gia: {0}", Book1.tac_gia);
      Console.WriteLine("The loai: {0}", Book1.the_loai);
      Console.WriteLine("Ma sach: {0}", Book1.ma_sach);

      /* in cac thong tin cua Book2 */
      Console.WriteLine("\nIn thong tin cua cuon sach 2:");
      Console.WriteLine("Ten sach: {0}", Book2.ten_sach);
      Console.WriteLine("Tac gia: {0}", Book2.tac_gia);
      Console.WriteLine("The loai: {0}", Book2.the_loai);
      Console.WriteLine("Ma sach: {0}", Book2.ma_sach);
    }
  }
}