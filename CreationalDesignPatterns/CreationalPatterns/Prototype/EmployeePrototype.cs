namespace CreationalDesignPatterns.CreationalPatterns.Prototype
{

    public abstract class EmployeePrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }

        // نسخه تبق الاصل منه ونفس reference imn the memory
        public abstract EmployeePrototype ShallowCopy();

        public abstract EmployeePrototype DeepCopy();

        public override string ToString()
        {
            return
            $@"
                Id: {Id} 
                Name: {Name}
                Address: {EmpAddress.City},{EmpAddress.StreetName},{EmpAddress.Building}
            ";
        }
    }
}