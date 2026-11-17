using LAB07_1;

// 1. Проверка ToString()
Worker w1 = new Worker("Guiseppe Leonardi", new DateTime(1990, 6, 12), new DateTime(2013, 5, 6), 23);
Programmer p1 = new Programmer("Alison Krause", new DateTime(1990, 6, 12), new DateTime(2013, 5, 6), Level.MIDDLE);
Manager m1 = new Manager("Ritchy Mitchell", new DateTime(1995, 3, 12), new DateTime(2019, 5, 6), 12, true);

Console.WriteLine(w1);
Console.WriteLine(p1);
Console.WriteLine(m1);
Console.WriteLine();

// 2. Проверка полиморфизма (через базовый тип Employee)
Employee w2 = new Worker("Worker 2", new DateTime(1995, 3, 12), new DateTime(2019, 5, 6), 18);
Employee p2 = new Programmer("Alex Dunlop", new DateTime(1995, 3, 12), new DateTime(2019, 5, 6), Level.SENIOR);
Employee m2 = new Manager("Manager 2", new DateTime(1995, 3, 12), new DateTime(2019, 5, 6), 12, true);

Console.WriteLine(w2);
Console.WriteLine(w2.TotalSalary());
Console.WriteLine(p2);
Console.WriteLine(p2.TotalSalary());
Console.WriteLine(m2);
Console.WriteLine(m2.TotalSalary());