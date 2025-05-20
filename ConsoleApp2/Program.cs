using System.Data;
using System.Data.SqlTypes;
using System.Net.Http.Headers;
using ConsoleApp2;
using LINQTest;
using Microsoft.Data.SqlClient;

Services sv = new Services();
sv.Read();
sv.ReadDetail("2223CS-106");
Console.ReadKey();
 





