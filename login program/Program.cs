//دریاقت یوزرنیم از کاربر
Console.Write("enter your username: ");
//تعریف متغیر یوزرنیم
var username  = Console.ReadLine();
//دریافت پسوورد از کاربر
Console.Write("enter your password: ");
//تعریف و تبدیل متغیر پسوورد
var  password =int.Parse(Console.ReadLine()); 
//حالتی که یوزر و پسوورد هر دو درست باشند
if(username == "morteza" && password == 1234)
{
    Console.WriteLine("welcome to my application");
}
//حالت غلط بودن یوزرنیم
else if(username!="morteza" && password == 1234)
{
    Console.Write("username is not valid");
}
//حالت غلط بودن پسوورد
else if(username == "morteza" && password != 1234)
{
    Console.WriteLine("password is not valid");
}
//حالت غلط بودن هردو
else
{
    Console.WriteLine("you are not from here arent you?");
}
