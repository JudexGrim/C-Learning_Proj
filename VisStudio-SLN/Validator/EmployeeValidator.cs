using Learning_Proj.PersonModel.EmolyeeModel;
namespace Learning_Proj.Validator
{
    internal class EmployeeValidator : PersonValidator
    {
        List<string> Roles = new List<string> {"Senior Engineer","Devops Engineer","HR Manager"};
        public bool ValidateRole(Employee employee)
        {
            foreach (var role in Roles)
            {
                if (role == employee.Role) return true; 
            }
            return false;
        }
        public bool ValidateSalary(Employee employee)
        {
            switch(employee.Role)
            {
                case "Senior Engineer":
                    if (employee.Salary >= 1000 && employee.Salary <= 1200) return true;
                    break;
                case "Devops Engineer":
                    if(employee.Salary >= 600 && employee.Salary <= 800) return true;
                    break;
                case "HR Manager":
                    if(employee.Salary >= 800 && employee.Salary <= 1000) return true;
                    break;
            }

            return false;
        }
    }
}
