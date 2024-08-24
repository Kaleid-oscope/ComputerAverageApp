Console.WriteLine("Enter 5 Grades separated by New lines: ");
double grades0 = Convert.ToDouble(Console.ReadLine());
double grades1 = Convert.ToDouble(Console.ReadLine());
double grades2 = Convert.ToDouble(Console.ReadLine());
double grades3 = Convert.ToDouble(Console.ReadLine());
double grades4 = Convert.ToDouble(Console.ReadLine());

double sum = grades0 + grades1 + grades2 + grades3 + grades4;
double average = sum/5;
Console.WriteLine("The average grade is: " + average + " rounded off to " + Convert.ToInt32(average));