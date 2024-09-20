public abstract class SalaryCalculator {
    public abstract double CalculateSalary(Employee employee);
}

public class PermanentSalaryCalculator : SalaryCalculator {
    public override double CalculateSalary(Employee employee) {
        return employee.BaseSalary * 1.2;
    }
}

public class ContractSalaryCalculator : SalaryCalculator {
    public override double CalculateSalary(Employee employee) {
        return employee.BaseSalary * 1.1;
    }
}

public class InternSalaryCalculator : SalaryCalculator {
    public override double CalculateSalary(Employee employee) {
        return employee.BaseSalary * 0.8;
    }
}
