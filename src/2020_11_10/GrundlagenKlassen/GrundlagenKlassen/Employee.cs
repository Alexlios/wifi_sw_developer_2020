using System;
using WIFI.ToolLibrary.ConsoleIO;

namespace GrundlagenKlassen
{
    public class Employee
    {
        public string Name;
        public Guid Id;
        public DateTime Birthday;
        public EmployeeState State;
        private decimal Salary;

        public Employee()
        {
            Name = "Undefined Employee";
            Id = Guid.NewGuid();
            Salary = 1000.0m;
            Birthday = new DateTime(1000, 1, 1);
            State = EmployeeState.Employed;
        }

        //zuw Konstr:




        private bool ProofValidation()
        {
            bool isValid = true;
            if (State == EmployeeState.Discontinued)
            {
                ConsoleTools.DisplayMesssage("Mitarbeiter ist bereits gekuendigt!", ConsoleColor.Red);
                isValid = false;
            }

            if (Name == "Undefined Employee")
            {
                ConsoleTools.DisplayMesssage($"Mitarbeiter existiert nicht! \nFehlerwert: {Name}", ConsoleColor.Red);
                isValid = false;
            }

            if (Birthday == new DateTime(1000, 1, 1))
            {
                ConsoleTools.DisplayMesssage($"Mitarbeiter existiert nicht! \nFehlerwert: {Birthday.ToLongDateString()}", ConsoleColor.Red);
                isValid = false;
            }
            return isValid;
        }

        public void DisplayInfos()
        {
            if (ProofValidation())
            {
                ConsoleTools.DisplayMesssage($"   MA Id:  {Id}", ConsoleColor.Green);
                ConsoleTools.DisplayMesssage($"    Name:  {Name}", ConsoleColor.Green);

                switch (State)
                {
                    case EmployeeState.Education:
                        ConsoleTools.DisplayMesssage($"   State:  {State}", ConsoleColor.Cyan);
                        break;

                    case EmployeeState.Employed:
                        ConsoleTools.DisplayMesssage($"   State:  {State}", ConsoleColor.Green);
                        break;

                    case EmployeeState.SabatTime:
                        ConsoleTools.DisplayMesssage($"   State:  {State}", ConsoleColor.Yellow);
                        break;

                    case EmployeeState.Sick:
                        ConsoleTools.DisplayMesssage($"   State:  {State}", ConsoleColor.Yellow);
                        break;
                }

                ConsoleTools.DisplayMesssage($"Birthday:  {Birthday.ToLongDateString()}", ConsoleColor.Green);
            }
        }

        public void UpdateSalary(double amountInPercent)
        {
            if (ProofValidation())
            {
                ConsoleTools.DisplayMesssage($"Altes Gehalt: {Salary} EUR", ConsoleColor.Yellow);
                Salary += Salary * (decimal)(amountInPercent / 100);
                ConsoleTools.DisplayMesssage($"Neues Gehalt: {Salary} EUR", ConsoleColor.Yellow);
            }
        }
    }
}