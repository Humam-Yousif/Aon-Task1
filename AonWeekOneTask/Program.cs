const String USERNAME = "humam";
const String PASSWORD = "H1234$";
int opt;

Console.WriteLine("Welcome to the Simple Login System!");
Console.WriteLine("Enter Your User Name :");
string userName = Console.ReadLine();
Console.WriteLine("Enter Your Password :");
string password = Console.ReadLine();

if (String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(password))
{
    Console.WriteLine("Username or password cannot be empty.");
}
else
{
    if (userName != USERNAME || password != PASSWORD)
    {
        Console.WriteLine("Invalid username or password. Access denied.");
    }
    else
    {
        Random rand = new Random();
        opt = rand.Next(100000,1000000);
        Console.WriteLine("Your OPT is : " + opt);
        Console.WriteLine("Enter Your OPT :");
        string stringUserOpt = Console.ReadLine();
        int userOpt;
        bool isInt = int.TryParse(stringUserOpt, out userOpt);

        if (!isInt || userOpt != opt)
        {
            Console.WriteLine("Invalid OTP. Access denied.");
        }
        else
        {
            Console.WriteLine("Success! You are logged in.");
        }
    }
}