﻿namespace Encapsulation_Exercise_01;

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
            if (value == null)
            {
                throw new ArgumentNullException("The username must not be null");
            }
            if (value.Length == 0)
            {
                throw new ArgumentException("The username must not be empty");
            }            
            _username = value;
        }
    }
    public string Email 
    {
        get => _email;
        set
        {
            if (!value.Contains('@'))
            {
                throw new ArgumentException("The email must contain an @ symbol");
            }
            _email = value;
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