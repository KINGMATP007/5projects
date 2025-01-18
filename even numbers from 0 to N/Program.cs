//ورودی گرفتن از کاربر برای مشخص کردن طول آرایه
Console.Write("enter the lentgh:");
//تبدیل به متغیر عدد صحیح
int n = int.Parse(Console.ReadLine());
//حلقه ای برای چاپ اعداد ۰تا n
for(int i = 0; i <=n; i++)
{//شرطی برای جداسازی اعداد زوج
    if(i%2==0)
    {
        //چاپ اعداد زوج
        Console.WriteLine(i);
    }
}