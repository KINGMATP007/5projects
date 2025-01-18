//ورودی کاربر برای تعیین شعاع
Console.Write("enter the radius:");
int r = int.Parse(Console.ReadLine());
//تعریف عدد پی 
var pi = 3.14;
//فرمول محیط 
var mohit = 2 * pi * r;
Console.Write($"mohit:{mohit}");
//فاصله برای زیبایی 
Console.WriteLine();
//فرمول مساحت
var masahat = pi * r * r;
Console.Write($"masahat:{masahat}");
