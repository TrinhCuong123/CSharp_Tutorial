using System;
using System.Net;

class Program
{
    static void DoSomthingAsync(int sconds, string mgs, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{mgs,10} ... Start");
        Console.ResetColor();

        // string a = "abe";

        // lock (a) // Khóa biến a
        // {

        // }

        for (int i = 0; i < sconds; i++)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(mgs);
                Console.ResetColor();
            }
            Thread.Sleep(100);
        }

        lock (Console.Out)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{mgs,10} ... End");
            Console.ResetColor();
        }

    }

    static async Task Task2()
    {
        Task t2 = new Task(
            () =>
            {
                DoSomthingAsync(5, "T2", ConsoleColor.Green);
            }
        );
        t2.Start();
        await t2; // Tương ứng với t2.Wait() khác nhau ở chỗ await phương thức trả về task luôn không cần return task2
        Console.WriteLine("T2 Done!");
        // t2.Wait();

        // return t2;
    }

    static async Task Task3()
    {
        Task t3 = new Task(
            (object? ob) =>
            {
                string a = (string)ob!;
                DoSomthingAsync(5, a, ConsoleColor.Yellow);
            },
            "T3"
        );

        t3.Start();
        await t3; // Tương ứng với t3.Wait() khác nhau ở chỗ await phương thức trả về task luôn không cần return task3
        Console.WriteLine("T3 Done!");
        // t3.Wait();
        // return t3;
    }

    static async Task Abc()
    {
        Task task = new Task(
            () =>
            {
                // ...
            }
        );

        task.Start();
        await task;
        // ...
    }

    static async Task<string> Task4()
    {
        Task<string> t4 = new Task<string>(
            () =>
            {
                DoSomthingAsync(5, "T4", ConsoleColor.Green);
                return "Return fromT4";
            }
        );
        t4.Start();
        string kq = await t4;
        return kq;
    }

    static async Task<string> Task5()
    {
        Task<string> t5 = new Task<string>(
            (object? ob) =>
            {
                string t = (string)ob!;
                DoSomthingAsync(5, t, ConsoleColor.Yellow);
                return $"Return from {t}";
            }
            , "T5"
            );
        t5.Start();
        // await t5;
        string kq = await t5;
        return kq;
    }

    static async Task<string> GetWeb(string url)
    {
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(url);
        string content = await response.Content.ReadAsStringAsync();
        return content;
    }

    // static void Main()
    // {
    // DoSomthingAsync(5, "Hello", ConsoleColor.Red);
    // Console.WriteLine("Welcome to .NET!");

    // Synchronous Đồng bộ chạy code 1 cách tuân tự
    //  Task, Task<T> Lớp biểu diễn tác vụ

    // Task t2 = new Task(Action); // Tham số khởi tạo tương ứng một delegate không có tham số không cần trả về giá trị
    // Task t2 = new Task(Action<object>, Object); // Tham số thứ 1 tương đương với một biểu thức Lamda nhận một kiểu Object và không cần có kiểu trả về, Tham số thứ 2 là một Object nó được dùng làm tham số để truyền vào action

    // Task t2 = new Task(() =>
    // {
    //     DoSomthingAsync(5, "T2", ConsoleColor.Green);
    // });

    // Task t3 = new Task((object? ob) =>
    // {
    //     string a = (string)ob!;
    //     DoSomthingAsync(5, a, ConsoleColor.Yellow);
    // }, "T3");

    // // 3 tác vụ chạy song song với nhau
    // t2.Start(); // Chạy trên các thread khác nhau
    // t3.Start();
    // DoSomthingAsync(5, "T1", ConsoleColor.Magenta);
    // // DoSomthingAsync(5, "T2", ConsoleColor.Green);
    // // DoSomthingAsync(5, "T3", ConsoleColor.Yellow);
    // Console.WriteLine("Hello World!");

    // t2.Wait(); // Đảm bảo tác vụ t2 đã hoàn thành
    // t3.Wait();

    // Task.WaitAll(t2, t3); // Đảm bảo tác vụ t2 và t3 đã hoàn thành

    // Asynchronous/Await

    //     DoSomthingAsync(5, "T1", ConsoleColor.Magenta);
    //     Task t2 = Task2();
    //     Task t3 = Task2();

    //     Console.WriteLine("Goodbye!");

    // }

    static async Task Main()
    {
        // Task t2 = Task2();
        // Task t3 = Task2();

        // DoSomthingAsync(5, "T1", ConsoleColor.Magenta);
        // await t2;
        // await t3;
        // Console.WriteLine("Goodbye!");

        // Task<string> t4 = new Task<string>(Func<string>);
        // Task<string> t5 = new Task<string>(Func<Object, string>, Object);

        // Task<string> t4 = new Task<string>(
        //     () =>
        //     {
        //         DoSomthingAsync(5, "T4", ConsoleColor.Green);
        //         return "Return fromT4";
        //     }
        // );

        // Task<string> t5 = new Task<string>(
        //     (object? ob) =>
        //     {
        //         string t = (string)ob!;
        //         DoSomthingAsync(5, t, ConsoleColor.Yellow);
        //         return $"Return from {t}";
        //     }
        //     , "T5"
        //     );
        // t4.Start();
        // t5.Start();

        // DoSomthingAsync(5, "T1", ConsoleColor.Magenta);

        // Task.WaitAll(t4, t5);

        // var kq4 = t4.Result;
        // var kq5 = t5.Result;

        // Console.WriteLine(kq4);
        // Console.WriteLine(kq5);

        Task<string> t4 = Task4();
        Task<string> t5 = Task5();
        DoSomthingAsync(5, "T1", ConsoleColor.Magenta);

        var kq4 = await t4;
        var kq5 = await t5;

        Console.WriteLine(kq4);
        Console.WriteLine(kq5);

        Console.WriteLine();

        var task = GetWeb("https://www.google.com");
        var content = await task;
        Console.WriteLine(content);
    }
}