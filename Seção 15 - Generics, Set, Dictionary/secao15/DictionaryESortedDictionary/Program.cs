Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "987654321";
cookies["phone"] = "123456789";

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
    Console.WriteLine(cookies["email"]);
else
    Console.WriteLine("There is no \"email\" key");

Console.WriteLine($"Size: {cookies.Count}");

Console.WriteLine("ALL COOKIES:");

foreach (var cookie in cookies)
{
    Console.WriteLine($"{cookie.Key}: {cookie.Value}");
}