namespace TreesAndHeaps;

public class EmployeeTree
{
    public int Salary { get; set; }
    public string Name { get; set; }
    public EmployeeTree Left { get; set; }
    public EmployeeTree Right { get; set; }
    public EmployeeTree (string name, int salary)
    {
        Salary = salary;
        Name = name;
        Left = null;
        Right = null;
    }
}