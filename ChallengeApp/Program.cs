using ChallengeApp;

Employee employee1 = new Employee("Daniel", "Kowalski", "36");
Employee employee2 = new Employee("Damian", "Koch", "41");
Employee employee3 = new Employee("Kasia", "Bigaj", "31");

employee1.AddScore(5);
employee1.AddScore(10);
employee1.AddScore(6);
employee1.AddScore(5);
employee1.AddScore(2);


employee2.AddScore(10);
employee2.AddScore(8);
employee2.AddScore(5);
employee2.AddScore(4);
employee2.AddScore(5);



employee3.AddScore(7);
employee3.AddScore(5);
employee3.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;

    }

}
                                                                 
Console.WriteLine("Pacownik z największą liczbą punktów:");
Console.WriteLine();
Console.WriteLine("Imię i Nazwisko:" + " ==> " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname);
Console.WriteLine("Lat :" + " ==> " + employeeWithMaxResult.Age);
Console.WriteLine("Liczba Uzyskanych Punktów:" + " ==> " + maxResult);
