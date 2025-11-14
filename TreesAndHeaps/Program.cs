namespace TreesAndHeaps;

class Program
{
    static void Main(string[] args)
    {
        EmployeeTree root = null;
        string name;
        int salary;

        while (true)
        {
            
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                break;
            }
            
            Console.Write("Enter salary: ");
            if (!int.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }
            
            root = Insert(root, name, salary);
        }
        
        Console.WriteLine("Complete!");
        InOrderTraversal(root);
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

    static void InOrderTraversal(EmployeeTree tree)
    {
        if (tree != null)
        {
            InOrderTraversal(tree.Left);
            Console.WriteLine($"Name: {tree.Name}, Salary: {tree.Salary}");
            InOrderTraversal(tree.Right);
        }
    }
}