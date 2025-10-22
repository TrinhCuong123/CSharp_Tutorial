namespace Tutorial_Csharp
{
    class Lession1
    {
        public void Bai1()
        {
            Console.WriteLine(typeof(bool));
            Console.WriteLine(sizeof(bool));
            Console.WriteLine("Hello World1");
            Console.WriteLine();

            // Là lớp cơ sở cơ bản cho tất cả kiểu dữ liệu trong C# Common Type System (CTS). Object là một alias cho lớp System.Object
            // Khi một kiểu giá trị được chuyển đổi thành kiểu object, nó được gọi là boxing và ngược lại, khi một kiểu object được chuyển đổi thành kiểu giá trị, nó được gọi là unboxing.
            object obj = 1;
            Console.WriteLine(obj.GetType());
            Console.WriteLine();

            // Kiểu dynamic là tương tự với kiểu object, ngoại trừ việc kiểm tra cho các biến kiểu object diễn ra tại compile time, trong khi việc kiểm tra các biến kiểu dynamic diễn ra tại run time.
            dynamic d = 20;
            Console.WriteLine(d.GetType());

            // Ép kiểu
            // Chuyển đổi kiểu ngầm định (implicit) - Việc chuyển đổi này được thực hiện bởi C# theo một phương thức an toàn kiểu (type-safe). Ví dụ: việc chuyển đổi từ các lớp kế thừa thành các lớp cơ sở.
            // Chuyển đổi kiểu tường minh (explicit) - Việc chuyển đổi này được thực hiện một cách rõ ràng bởi người dùng bằng việc sử dụng các hàm được định nghĩa trước. Các chuyển đổi kiểu tường minh cần một toán tử cast.
            Console.WriteLine();
            int i = 75;
            float f = 53.005f;
            double d1 = 2345.7652;
            bool b = true;
            //su dung phuong thuc ToString()
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(b.ToString());


            // Hàm Convert.ToInt32() chuyển đổi dữ liệu đã nhập bởi người dùng thành kiểu dữ liệu int, bởi vì Console.ReadLine() chấp nhận dữ liệu trong định dạng chuỗi.
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);


            // Có hai loại biểu thức trong C#:
            // lvalue: Một biểu thức mà là một lvalue có thể xuất hiện hoặc bên trái hoặc bên phải của phép gán trong C#.
            // rvalue: Một biểu thức mà là một rvalue có thể xuất hiện bên phải nhưng không thể ở bên trái của một phép gán trong C#.


            // Encapsulation (Tính đóng gói) được định nghĩa là "tiến trình đóng gói một hoặc nhiều mục bên trong một gói logic hoặc vật lý". Tính đóng gói, trong phương pháp lập trình hướng đối tượng, ngăn cản việc truy cập tới chi tiết của trình trình triển khai (Implementation Detail).
            // Tính trừu tượng và tính đóng gói là hai đặc điểm có liên quan với nhau trong lập trình hướng đối tượng. Tính trừu tượng cho phép tạo các thông tin liên quan có thể nhìn thấy và tính đóng gói cho lập trình viên khả năng triển khai độ trừu tượng đã được kế thừa.
            // Tính đóng gói được triển khai bởi sử dụng Access Specifier. Một Access Specifier định nghĩa phạm vi và tính nhìn thấy của một thành viên lớp. C# hỗ trợ các Access Specifier sau:
            // Public
            // Private
            // Protected
            // Internal
            // Protected internal
        }
    }
}