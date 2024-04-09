using ConsoleApp26;

Leader leader = new Leader(6);
Console.WriteLine($"Зарплата керівництва: {leader.CalculateSalary()} UAH");
Executive execute = new Executive(4);
Console.WriteLine($"Зарплата управлінців: {execute.CalculateSalary()} UAH");
Perfomer perfomer = new Perfomer(7);
Console.WriteLine($"Зарплата виконавців: {perfomer.CalculateSalary()} UAH");
Manager Manager = new Manager(4,30);
Console.WriteLine($"Зарплата Менеджерів : {Manager.CalculateSalary()}");
Console.WriteLine($"Кількість підлеглих у менеджерів : {Manager.GetNumberOfSubordinates()}");
Engineer engineer = new Engineer(5, 88);
Console.WriteLine($"Зарплата Інженерів : {engineer.CalculateSalary()}");
Console.WriteLine($"Кількість вихідних в році: {engineer.GetCountHolidayDays()}");
ArchitectEngineer architectEngineer = new ArchitectEngineer(8, 90);
Console.WriteLine($"Зарплата У Архітектора-Інженера : {architectEngineer.CalculateSalary()}");
Console.WriteLine($"Кількість вихідних в році : {architectEngineer.GetCountHolidayDays()}");
Mechanic mechanic = new Mechanic(9);
Console.WriteLine($"Зарплата Механіка : {mechanic.CalculateSalary()}");

Console.ReadKey();