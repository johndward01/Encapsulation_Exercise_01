﻿// TODO: Create a User class with private fields for username, password, and email
// TODO: Give these 3 fields a default value of an empty string  ""


// TODO: Use a property to encapsulate the username field
// In the setter, if the username is null throw new ArgumentNullException("The username must not be null");
// In the setter, else if the username is empty throw new ArgumentException("The username must not be empty");
// In the setter, else set the username = value;


// TODO: Use a property to encapsulate the email field
// In the setter, if the the email doesn't contain an @ symbol throw new ArgumentException("The email must contain an @ symbol");


// TODO: Create 2 methods to encapsulate the password field
// 1 called GetPassword() which returns the value stored in the _password field
// 1 called SetValidPassword() which validates the password before setting the field
// the password should be at least 10 characters long
// the password should contain at least 2 special symbols [!@#$%^&*()]
// the password should contain at least 2 uppercase letters