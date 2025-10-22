
using System.Data;

public class Product
{
    public int ID { set; get; }
    public string Name { set; get; }         // tên
    public double Price { set; get; }        // giá
    public string[] Colors { set; get; }     // các màu sắc
    public int Brand { set; get; }           // ID Nhãn hiệu, hãng
    public Product(int id, string name, double price, string[] colors, int brand)
    {
        ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
    }
    // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
    override public string ToString()
       => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
}

public class Brand
{
    public string? Name { set; get; }
    public int ID { set; get; }
}
class Program
{
    static void Main(string[] args)
    {
        var brands = new List<Brand>() {
            new Brand{ID = 1, Name = "Công ty AAA"},
            new Brand{ID = 2, Name = "Công ty BBB"},
            new Brand{ID = 4, Name = "Công ty CCC"},
        };

        var products = new List<Product>()
        {
            new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
            new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
            new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
            new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
            new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
            new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
            new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
        };

        var query = from p in products
                    where p.Price == 400
                    select p;
        // foreach (var product in query)
        // {
        //     Console.WriteLine(product);
        // }

        // Select
        var kq = products.Select(p =>
        {
            return p.Price;
        });

        // Select Many
        var kq1 = products.SelectMany(p =>
        {
            return p.Colors;
        });

        // Where
        var kq2 = products.Where(p => p.Price == 400);

        var kq3 = products.Join(brands, p => p.Brand, b => b.ID, (p, b) => new { Product = p, Brand = b });
        var kq4 = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
        {
            return new
            {
                Ten = p.Name,
                ThuongHieu = b.Name
            };
        });

        var kq5 = brands.GroupJoin(products, b => b.ID, p => p.Brand, (brand, pros) =>
        {
            return new
            {
                ThuongHieu = brand.Name,
                CacSanPham = pros
            };
        });

        // foreach (var gr in kq5)
        // {
        //     Console.WriteLine(gr.ThuongHieu);
        //     foreach(var p in gr.CacSanPham)
        //     {
        //         Console.WriteLine(p);
        //     }
        // }

        // Take
        products.Take(4).ToList().ForEach(p => Console.WriteLine(p));

        // Skip
        products.Skip(2).ToList().ForEach(p => Console.WriteLine(p)); // Bỏ qua 2 phần tử đầu tiên

        // Order by
        products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));

        // Order by descending
        products.OrderByDescending(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));

        // Single: khác where ở chỗ chỉ lấy 1 phần tử duy nhất
        products.Single(p => p.Price == 400);

        // SingleOrDefault: khác where ở chỗ lấy 1 phần tử duy nhất hoặc không khác single ở chỗ nếu không thấy sẽ là null không phát sinh lỗi
        // Nếu nhiều hơn 2 phần tử duy nhất thì lỗi
        products.SingleOrDefault(p => p.Price == 400);

        // Any: Trả về True khi thỏa mãn điều kiện
        products.Any(p => p.Price == 400);

        // All: Kiểm tra tất cả phần tử có thỏa mãn điều kiện
        products.All(p => p.Price == 400); 

        
        // foreach (var color in kq3)
        // {
        //     Console.WriteLine(color);
        // }

        // Min, Max, Sum, Average
    }
}