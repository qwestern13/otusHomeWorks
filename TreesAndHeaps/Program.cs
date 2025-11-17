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
            
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                break;
            }
            
            Console.Write("Введите зарплату: ");
            if (!int.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Некорректный ввод");
                continue;
            }
            
            root = Insert(root, name, salary);
        }
        
        Console.WriteLine("Готово!");
        InOrderTraversal(root);

        while (true)
        {
            Console.WriteLine("Введите зарплату для поиска");
            if (!int.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Некорректный ввод");
                continue;
            }
            
            EmployeeTree found = FindBySalary(root, salary);
            
            if (found != null)
            {
                Console.WriteLine($"Найден: {found.Name} - {found.Salary}");
            }
            else
            {
                Console.WriteLine("Такой сотрудник не найден");
            }
            
            Console.WriteLine("Введите 0 для ввода новых сотрудников или 1 для повторного поиска:");
            string choice = Console.ReadLine();
            if (choice == "0")
            {
                break;
            }
            else if (choice == "1")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Допускается только 0 или 1");
            }
        }
        
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
            Console.WriteLine($"{tree.Name} - {tree.Salary}");
            InOrderTraversal(tree.Right);
        }
    }

    static EmployeeTree FindBySalary(EmployeeTree tree, int salary)
    {
        if (tree == null || salary == tree.Salary)
        {
            return tree;
        }

        if (salary < tree.Salary)
        {
            return FindBySalary(tree.Left, salary);
        }
        else
        {
            return FindBySalary(tree.Right, salary);
        }
    }
}