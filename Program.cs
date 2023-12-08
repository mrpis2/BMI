using System;
class Program
{
    static void Main(string[] args)
    {
        double height;
        double weight;
        Console.WriteLine("Nhap gia tri chieu cao: ");
        height = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap gia tri can nang: ");
        weight = double.Parse(Console.ReadLine());

        double bmi = weight / Math.Pow(height, 2);
        bmi = Math.Round(bmi, 1);

        Console.WriteLine("BMI: " + bmi);

        if(bmi < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else
        {
            if(bmi <25)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                if (bmi <30)
                {
                    Console.WriteLine("Overweight");
                }
                else
                {
                    Console.WriteLine("Obese");
                }
            }
        }
    }
}