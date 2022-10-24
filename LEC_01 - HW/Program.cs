// See https://aka.ms/new-console-template for more information
/******************************************************************************
*                              שיעורי בית
                        ------------------------
* A) private ליצור מחלקה חדשה של רכב ולהגדיר 3 משתנים מסוג 
* 1) שם החברה של הרכב
* 2) מספר הרכב
* 3) שנת ייצור

* B) לכל אחד מהם get-ו set מגדירים
* נבצע בדיקה של שנת הייצור
* במידה והשנת ייצור קטנה מ-1991
* לא לעשות השמה

* C) ניצור פונקציה שמדפיסה את שם החברה של הרכב
*    פונקציה שמדפיסה את מספר הרכב
*    פונקציה שמדפיסה את שנת הייצור
*******************************************************************************/

using LEC_01___HW;

while (true)
{
  Car Ex = new Car();

  Console.WriteLine("\nPlease Enter Your Car Company Name:\n");
  Ex.Company = Console.ReadLine();


  Console.WriteLine("\nPlease Enter Your Car License Plate:\n");
  Ex.Plate = int.Parse(Console.ReadLine());


  Console.WriteLine("\nPlease Enter Your Car Model Year:\n");
  Ex.Model = int.Parse(Console.ReadLine());

  Console.WriteLine("\nYour Car Details:\n-------------------");
  Ex.printCN();
  Ex.printLP();
  Ex.printModel();
}
