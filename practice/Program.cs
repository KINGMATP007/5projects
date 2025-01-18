//این کد تشخیص دهنده ی قایم الزاویه بودن یک مثلث است
//فرمول فیثاغورس تعریف کننده ی یک مثلث قایم الزاویه است
//تعریف ضلع اول 
Console.Write("enter first number:");
int a  = int.Parse(Console.ReadLine());
//تعریف ضلع دوم
Console.Write("enter second number:");
int  b = int.Parse(Console.ReadLine());
//تعریف ضلع سوم
Console.Write("enter third number:");
int c = int.Parse(Console.ReadLine());
//اگر شرط  زیر که فرمول فیثاغورس است برقرار باشد قایم الزاویه تشخیص داده میشود
if (c * c == (a * a) + (b * b))
{
    Console.WriteLine("yep its true");
}
//در غیر این صورت قایم الزاویه نیست
else
{
    Console.WriteLine("nope you got it wrong");
}