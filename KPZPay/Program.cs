using KPZPay;

KBZService kBZService = new KBZService();
Console.WriteLine("Welcome KBZ Pay");
Console.WriteLine("1.Login Account");
Console.WriteLine("2. View User");
Console.Write("Enter Your Option : ");
string option = Console.ReadLine()!;
bool isInt = int.TryParse(option, out var value);
if (isInt is false)
{
    Console.WriteLine("Invalid Option");
}
switch (value)
{
    case 1: if(kBZService.Login() is true)
        {
            Console.WriteLine("Please Select Your User Option");
            string opt = Console.ReadLine()!;
            bool optInt = int.TryParse(opt, out int selectOption);
            if (optInt is false)
            {

            }
            switch (selectOption)
            {
                
            }
        };break;

    case 2: kBZService.ViewUser();break;
}


