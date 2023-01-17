string password = Console.ReadLine();

if (!CheckPasswordLenght(password)) 
{
	Console.WriteLine("Password must be between 6 and 10 characters");
}
if (!CheckContainLettersAndDigits(password))
{
	Console.WriteLine("Password must consist only of letters and digits");
}
if (!CheckPasswordContainAtLeastTwoDigits(password))
{
	Console.WriteLine("Password must have at least 2 digits");
}
if (CheckPasswordLenght(password) && CheckContainLettersAndDigits(password) && CheckPasswordContainAtLeastTwoDigits(password))
{
	Console.WriteLine("Password is valid");
}

static bool CheckPasswordLenght(string password)
{
	if (password.Length >= 6 && password.Length <= 10)
	{
		return true;
	}
	return false;
}
static bool CheckContainLettersAndDigits(string password)
{
	foreach (char c in password)
	{
		if (!Char.IsLetterOrDigit(c))
		{
			return false;
		}
	}
	return true;
}
static bool CheckPasswordContainAtLeastTwoDigits(string password)
{
	int cntDig = 0;
	foreach (char c in password) 
	{ 
		if (Char.IsDigit(c)) 
		{ 
			cntDig++; 
		}
	}
	return cntDig >= 2;
}