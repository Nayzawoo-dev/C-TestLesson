int[] number = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
//Noraml Syntax
foreach (var i in number)
{
    if(i % 2 == 0)
    {
        Console.WriteLine($"{i} is Even");
    }
    else
{
    Console.WriteLine($"{i} is Odd");
}
}
//Query Symtax
var EvenNumber = from i in number
                 where i % 2 == 0
                 select i;
foreach (var i in EvenNumber)
{
    Console.WriteLine(i);
}

//Method Syntax
var evenNumber = number.Where(i => i % 2 == 0);

foreach (var i in evenNumber)
{
    Console.WriteLine(i);
}
//First or Default
int[] str = [];
var result = str.FirstOrDefault();
Console.WriteLine(result);
////Write Text File And Read Text File
//File.WriteAllText("C://Text/text.txt", "hello nigga");
//var ans = File.ReadAllText("C://Text/text.txt");
//Console.WriteLine(ans);

//Read Desktop File Path
//string path = "C://Text/Text.txt";
//StreamReader reader = new StreamReader(path);
//    try
//    {
//        string line = reader.ReadToEnd();
//        Console.WriteLine(line);
//    }
//    catch (Exception exe)
//    {
//        Console.WriteLine(exe.Message);
//    }
//finally
//{
//    if (reader != null)
//    {
//        reader.Close();
//    }
//    Console.WriteLine("Clean code executed");
//}

decimal amount = 1000000.90M;
//Console.WriteLine(amount.ToString("n0"));
Console.WriteLine(amount.ToString("n2"));

//Try and Catch Runtime Error
try
{
    int[] arr = { 1, 2, 3, 4, };
    Console.WriteLine(arr[4]);
}catch(Exception ex)
{
    //Console.WriteLine(ex.ToString());
    Console.WriteLine(ex.Message);
}
//throw new Exception
int Age = 15;
 void checkAge(int age)

{     
    Age = age;
    if (age < 18)
    {
        throw new ArgumentOutOfRangeException("Age must be greater than 18");
    }
   
}

int findAge(int year)
{
    int currenYear = 2025;
    int age = currenYear - year;
    return age;
}
Console.WriteLine(findAge(2005));


DateTime time = DateTime.Now;
//Clock Time
Console.WriteLine(time.ToString("hhh-mm-ss"));
//Date Time
Console.WriteLine(time.ToString("yyy-MM-dd"));
//Add Day
DateTime today = DateTime.Now;
DateTime nextWeek = today.AddDays(14);
Console.WriteLine(today.ToString("yyy-MM-dd"));
Console.WriteLine(nextWeek.ToString("yyy-MM-dd"));

//Today Code Is Enough
