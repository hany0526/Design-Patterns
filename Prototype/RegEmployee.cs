namespace DesignPatterns.Prototype
{
    public class RegEmployee : EmployeePrototype
    {
        // Shallow Copy refernce to same old instance in the memory (with same data)
        // by using MemberwiseClone function
        public override EmployeePrototype ShallowCopy()
        {
            return (RegEmployee)this.MemberwiseClone();
        }

        // 
        public override EmployeePrototype DeepCopy()
        {
            RegEmployee emp = new RegEmployee();
            // emp = (RegEmployee)this.MemberwiseClone();

            emp.Id = this.Id;
            emp.Name = this.Name;

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