//تعیین عرض دنباله توسط کاربر
Console.Write("enter the horizontal table size:");
var a  = int.Parse(Console.ReadLine());
//تعیین طول دنباله توسط کاربر
Console.Write("enter the verctical table size:");
var b = int.Parse(Console.ReadLine());
//حلقه ی nest شده 
//حلقه ی اول برای ایجاد عرض دنباله 
for (int i =1; i <= a; i++)
{
    //حلقه ی دوم برای ایجاد طول دنباله 
    for (int j =1; j <= b; j++)
    {
        //چاپ دنباله 
        Console.Write($"{j * i}\t");
    }
    //فاصله برای زیبایی چاپ 
    Console.WriteLine();
}
