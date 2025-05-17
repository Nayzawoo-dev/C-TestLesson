using KPZPay;
Kpay:
KBZService kBZService = new KBZService();
Console.WriteLine("Welcome KBZ Pay");
Console.WriteLine("1.Login Account");
Console.WriteLine("2. View User");
Console.WriteLine("3. Create Account");
Console.WriteLine("4. Exit");
BeforeOption:
Console.Write("Enter Your Option : ");
string option = Console.ReadLine()!;

bool isInt = int.TryParse(option, out int value);
if (isInt is false)
{
    Console.WriteLine("Invalid Option");
    goto BeforeOption;
}
switch (value)
{
    case 1: if(kBZService.Login() is true)
        {
        BeforeOPT:
            Console.WriteLine("Please Select Your User Option?");
            Console.WriteLine("1. Insert Money");
            Console.WriteLine("2. Transfer Money");
            Console.WriteLine("3. WithDraw Money");
            Console.WriteLine("4. Exit System");
            string opt = Console.ReadLine()!;
            bool optInt = int.TryParse(opt, out int selectOption);
            if (optInt is false)
            {
                Console.WriteLine("Your Option is Invalid");
                goto BeforeOPT;
            }
            switch (selectOption)
            {
                case 1: kBZService.InsertMoney();goto BeforeOPT;
                case 2: kBZService.TransferMoney();goto BeforeOPT;
                case 3: kBZService.withDraw();goto BeforeOPT;
                case 4: goto Kpay;
            }
        }
        else
        {
            goto Kpay;
        };break;
        ;

    case 2:kBZService.ViewUser();goto Kpay;
    case 3:kBZService.CreateAcc();goto Kpay;
    case 4:goto Exit;
    default: break;
}
Exit:
Console.ReadKey();


