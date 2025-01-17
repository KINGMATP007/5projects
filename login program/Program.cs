Console.Write("enter your username: ");
var username  = Console.ReadLine();
Console.Write("enter your password: ");
var  password =int.Parse(Console.ReadLine());
if(username == "morteza" && password == 1234)
{
    Console.WriteLine("welcome to my application");
}
else if(username!="morteza" && password == 1234)
{
    Console.Write("username is not valid");
}
else if(username == "morteza" && password != 1234)
{
    Console.WriteLine("password is not valid");
}
else
{
    Console.WriteLine("you are not from here arent you?");
}
