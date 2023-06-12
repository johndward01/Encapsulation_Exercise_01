namespace Encapsulation_Exercise_01;

internal class User
{
    private string _username = "";
    private string _email = "";
    private string _password = "";

    public string UserName
    {
        get => _username;
        set
        {
            if (_username == null)
            {
                throw new ArgumentNullException("The username must not be null");
            }
            else if (_username.Length == 0)
            {
                throw new ArgumentException("The username must not be empty");
            }
            else
            {
                _username = value;
            }
        }
    }
    public string Email 
    {
        get => _email;
        set
        {
            if (!_email.Contains('@'))
            {
                throw new ArgumentException("The email must contain an @ symbol");
            }
            else
            {
                _email = value;
            }
        }
    }

    public string GetPassword() => _password;
    public void SetValidPassword(string password)
    {
        bool lengthCheck = LengthCheck(password);
        bool symbolCheck = SymbolCheck(password);
        bool upperCaseCheck = LengthCheck(password);

        if (lengthCheck && symbolCheck && upperCaseCheck)
        {
            _password = password;
        }
    }

    public bool LengthCheck(string password)
    {
        if (password.Length > 10)
        {
            return true;
        }
        return false;
    }

    public bool SymbolCheck(string password)
    {
        var symbols = "!@#$%^&*()";
        var symbolCount = 0;

        foreach (var letter in password)
        {
            foreach (var symbol in symbols)
            {
                if (letter == symbol)
                {
                    symbolCount++;
                }
            }
        }

        if (symbolCount >= 2)
        {
            return true;
        }
        return false;
    }

    public bool UpperCaseCheck(string password)
    {
        var upperCaseCount = 0;

        foreach (var letter in password)
        {
            if (letter == char.ToUpper(letter))
            {
                upperCaseCount++;
            }
        }

        if (upperCaseCount >= 2)
        {
            return true;
        }
        return false;
    }

}
