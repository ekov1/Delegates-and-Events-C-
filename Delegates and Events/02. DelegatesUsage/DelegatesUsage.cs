namespace _02._DelegatesUsage
{
    class DelegatesUsage
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 101, Name = "Marry", Salary = 5000, Experience = 5});
            empList.Add(new Employee() { Id = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { Id = 101, Name = "John", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { Id = 101, Name = "Todd", Salary = 3000, Experience = 3 });

            IsPromoteble isPromoteble = new IsPromoteble(Promote);

            Employee.PromoteEmployee(empList, isPromoteble);
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            return false;
        }
    }
   
    delegate bool IsPromoteble(Employee empl);

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromoteble isEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if(isEligibleToPromote(employee))
                {
                    Console.WriteLine( employee.Name + " promoted" );
                }
            }
        }
    }

    // Old - No delegates

    //public static void Main()
    //{
    //    List<Employee> empList = new List<Employee>();
    //    empList.Add(new Employee() { Id = 101, Name = "Marry", Salary = 5000, Experience = 5 });
    //    empList.Add(new Employee() { Id = 101, Name = "Mike", Salary = 4000, Experience = 4 });
    //    empList.Add(new Employee() { Id = 101, Name = "John", Salary = 6000, Experience = 6 });
    //    empList.Add(new Employee() { Id = 101, Name = "Todd", Salary = 3000, Experience = 3 });
    //
    //    Employee.PromoteEmployee(empList);
    //}

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; } = string.Empty;
    //    public int Salary { get; set; }
    //    public int Experience { get; set; }

    //    public static void PromoteEmployee(List<Employee> employeeList, IsPromoteble IseligibleToPromote)
    //    {
    //        foreach (Employee employee in employeeList)
    //        {
    //            if (employee.Experience >= 5)
    //            {
    //                Console.WriteLine(employee.Name + " promoted");
    //            }
    //        }
    //    }
    //}
}