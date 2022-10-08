// See https://aka.ms/new-console-template for more information


using Solid.App.OCPGood2;

Console.WriteLine("Hello, World!");

SalaryCalculator salaryCalculator = new SalaryCalculator();

// Bad way
//Console.WriteLine($"Low salary :{ salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle salary :{salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High salary :{salaryCalculator.Calculate(1000, SalaryType.High)}");

//Good way
//Console.WriteLine($"Low salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate())}");
//Console.WriteLine($"Middle salary :{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate())}");
//Console.WriteLine($"High salary :{salaryCalculator.Calculate(1000,new HighSalaryCalculate())}");
//Console.WriteLine($"Manager salary :{salaryCalculator.Calculate(1000, new ManagerSalaryCalcualte())}");


//Good2 way
Console.WriteLine($"Low salary :{salaryCalculator.Calculate(1000, new LowSalaryCalculate().Calculate)}");
Console.WriteLine($"Middle salary :{salaryCalculator.Calculate(1000, new MiddleSalaryCalculate().Calculate)}");
Console.WriteLine($"High salary :{salaryCalculator.Calculate(1000, new HighSalaryCalculate().Calculate)}");
Console.WriteLine($"Manager salary :{salaryCalculator.Calculate(1000, new ManagerSalaryCalcualte().Calculate)}");

Console.WriteLine($"Custom salary :{salaryCalculator.Calculate(1000, x =>
{
    return x * 10;

})}");


