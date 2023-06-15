using System.ComponentModel.DataAnnotations;
using System.Timers;
using System.Net.Mail;

string? emailAddress = "";
string email = $"{emailAddress}";
string userAge = ">=18";


Console.WriteLine("Online Voting Application");
Console.WriteLine();    

System.Threading.Thread.Sleep(3000);

while (true)
{//ask user for their age
    Console.WriteLine("Please Enter Your Age");
    //read the users age and store it in the userAge variable
    int Age = Convert.ToInt32(Console.ReadLine());
    userAge = Console.ReadLine();

    Console.WriteLine("Please Wait As We Verify Your Age");

    System.Threading.Thread.Sleep(3000);

    if (Age >= 18)
    {
        Console.WriteLine("Verified");
        Console.WriteLine();
        break;
    }
    //handle age that is less than 18
    //display cannot proceed and ask for user age again
    Console.WriteLine("Cannot Vote");
}

while (true)
{ //validate user email address
    //ask for user address
    Console.WriteLine("Please Enter Your email Address");
    //read what user has written and store it in useNumber variable
    emailAddress = Console.ReadLine();


    Console.WriteLine("Please Wait");
    Console.WriteLine();


    System.Threading.Thread.Sleep(3000);
    //if user address is correct exit send a link and exit the loop
    if (emailAddress == emailAddress)
    {
        Console.WriteLine("https : //instagram.com");
        Console.WriteLine() ;
        break;
    }


}

bool IsValidEmail(string email)
{
    var trimmedEmail = email.Trim();

    if (trimmedEmail.EndsWith("."))
    {
        return false; // suggested by @TK-421
    }
    try
    {
        var addr = new System.Net.Mail.MailAddress(email);
        return addr.Address == trimmedEmail;
    }
    catch
    {
        return false;
    }
}

