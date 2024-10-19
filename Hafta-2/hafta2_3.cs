string username = "admin";
string password = "Admin_32453@";

Console.Write("Kullanıcı Adı: ");
string inputUser = Console.ReadLine() ?? string.Empty;

Console.Write("Şifre: ");
string inputPass = Console.ReadLine() ?? string.Empty;

if (inputUser == username && inputPass == password)
{
    Console.WriteLine("Giriş yapıldı");
}
else
{
    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
}
