namespace CreationalDesignPatterns.CreationalPatterns.Prototype
{
    public class RegEmployee : EmployeePrototype
    {
        // Shallow Copy refernce to same old instance in the memory (with same data)
        // by using MemberwiseClone function
        public override EmployeePrototype ShallowCopy()
        {
            return (RegEmployee)MemberwiseClone();
        }

        // 
        public override EmployeePrototype DeepCopy()
        {
            RegEmployee emp = new RegEmployee();

            emp.Id = Id;
            emp.Name = Name;

            emp.EmpAddress = new Address()
            {
                Building = EmpAddress.Building,
                City = EmpAddress.City,
                StreetName = EmpAddress.StreetName
            };

            return emp;
        }
    }
}