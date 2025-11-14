namespace TreesAndHeaps;

class Program
{
    static void Main(string[] args)
    {
        
    }

    static EmployeeTree Insert(EmployeeTree node, string name, int salary)
    {
        if (node == null)
        {
            return new EmployeeTree(name, salary);
        }

        if (salary < node.Salary)
        {
            node.Left = Insert(node.Left, name, salary);
        }

        else
        {
            node.Right = Insert(node.Right, name, salary);
        } 
        
        return node;
    }
}