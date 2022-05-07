/* Leap Year
a.I / P ­> Year, ensure it is a 4 digit number.
b. Logic ­> Determine if it is a Leap Year.
c. O/P ­> Print the year is a Leap Year or not.
    */


using System;


       Console.WriteLine("Enter the Year");

int Year = int.Parse(Console.ReadLine());



if ((Year % 4 == 0) && (Year % 100 != 0))
       Console.WriteLine("Leap Year");

else Console.WriteLine("Not Leap Year");
     




     
