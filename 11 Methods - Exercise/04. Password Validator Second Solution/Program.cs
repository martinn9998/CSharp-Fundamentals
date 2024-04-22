namespace _04._Password_Validator_Second_Solution
{
    internal class Program
    {
        static void Main()
        {
            string passwordInput = Console.ReadLine();
            CheckingPasswrodParameters(passwordInput);
        }
        static void CheckingPasswrodParameters(string passwordInput)
        {
            bool isInvalid = false;
            if (passwordInput.Length < 6 || passwordInput.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isInvalid = true;
            }
            if (!ConsistingOnlyLettersAndDigits(passwordInput))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isInvalid = true;
            }
            if(!CheckingForAtLeastTwoDigits(passwordInput))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isInvalid = true;
            }
            if(!isInvalid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ConsistingOnlyLettersAndDigits(string passwordInput)
        {
            for (int i = 0; i < passwordInput.Length; i++)
            {
                if (!char.IsLetterOrDigit(passwordInput[i]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckingForAtLeastTwoDigits(string passwordInput)
        {
            int counter = 0;
            bool isPasswordConsistTwoDigits = false;
            for (int i = 0; i < passwordInput.Length;i++)
            {
                if (passwordInput[i] >= 48 && passwordInput[i] <= 57)
                {
                    counter++;
                    if (counter == 2)
                    {
                        isPasswordConsistTwoDigits = true;
                        break;
                    }
                }
            }
            if (isPasswordConsistTwoDigits)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
