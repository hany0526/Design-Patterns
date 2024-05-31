namespace DesignPatterns.Prototype
{
    public class TempEmployee : EmployeePrototype
    {

        // ShallowCopy refernce to same old instance in the memory (same data)
        // by using MemberwiseClone function
        public override EmployeePrototype ShallowCopy()
        {
            // casting to EmployeePrototype Class
            return (TempEmployee)this.MemberwiseClone();
        }

        //  DeepCopy return same data at a new instance
        public override EmployeePrototype DeepCopy()
        {
            TempEmployee emp = new TempEmployee();
            // emp = (TempEmployee)this.MemberwiseClone();

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