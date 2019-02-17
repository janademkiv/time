using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Threading; 


namespace ConsoleApplication20 
{ 
class Program 
{ 


static void Main(string[] args) 
{ 

//string text = "хороший день"; 

//text = text.Replace("хороший", "плохой"); 
//Console.WriteLine(text); 





//string time = DateTime.Now.ToLongDateString(); 
//time = time.Replace(DateTime.Now.ToLongDateString(), "замена"); 

// Console.WriteLine(time); 


TimerCallback timeCB = new TimerCallback(printTime); 

Timer time = new Timer(timeCB, null, 0, 1000); 
Console.WriteLine("Текущее время: " + time); 
//Console.WriteLine(printDate()); 


//string time2 = DateTime.Now.ToLongTimeString(); 
//time2 = time2.Replace(time2,time2); 
//Console.WriteLine(time2); 
//DateTime now = DateTime.Now; 
//Console.WriteLine("D: " + now.ToString("D")); 

Console.ReadKey(); 

} 

//яна дата 
static string printDate() { 
Console.WriteLine("Текущая дата: " + DateTime.Now.ToLongDateString()); 

string time = DateTime.Now.ToLongDateString(); 
return time; 
} 


//яна время в реальн времени 
static void printTime(object state) 
{ 
//Console.Clear(); 

//Console.WriteLine("Текущее время: " + DateTime.Now.ToLongTimeString()); 
Console.SetCursorPosition(1, 2); 
string time = DateTime.Now.ToLongTimeString(); 
time = time.Replace(DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongTimeString()); 

Console.WriteLine(time); 
} 




////яна 
//static void nameFio(out string name, out string surname, out string middlename) 
//{ 

// name = tryParseString("Введите ваше имя"); 
// surname = tryParseString("Введите вашу фамилию"); 
// middlename = tryParseString("Введите ваше отчество"); 
//} 

//static string tryParseString(string a) 
//{ 
// Console.WriteLine(a); 
// while (true) 
// { 
// try 
// { 
// string s = Console.ReadLine(); 
// proverka(s); 
// return s; 
// } 
// catch (Exception) { Console.WriteLine("Ваше введение данные содержат цифры. Попробуйте еще раз."); } 
// } 
//} 
////яна 
//static void proverka(string s) 
//{ 

// int[] cifri = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //обьевляем массив цифр 
// foreach (int cifr in cifri) 
// { //цикл по массиву 
// bool sodergit = s.Contains(cifr.ToString()); //тут проверяет наличие в строке цифры 

// if (sodergit) //если нет ошибки, ничег оне происходит 
// { //если есть ошибка, он возвращает ошибку throw new Exception(); 
// throw new Exception(); //она мне говорит что тут ошибка 
// } 
// } 

//} 



} 
}
