namespace StructuralDesignPatterns.StructuralPatterns.Adapter
{
    public class SalaryAdapter : SalaryCalculator
    {
        private Employee employee;
        public double CalcSalary(MachineOperator _operator)
        {
            employee = new Employee();
            employee.BasicSalary = _operator.BasicSalary;
            return CalcSalary(employee);
        }
    }
}