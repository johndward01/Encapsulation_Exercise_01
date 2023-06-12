using Encapsulation_Exercise_01;

// TODO: Create a User class with 3 private fields for _username, _password, and _email
// TODO: Initialize the 3 fields with an empty string ""


// TODO: Use a property to encapsulate the _username field
// In the setter, if the value is null throw new ArgumentNullException("The username must not be null");
// In the setter, else if the value is empty throw new ArgumentException("The username must not be empty");
// In the setter, else set the _username = value;


// TODO: Use a property to encapsulate the _email field
// In the setter, if the the _email doesn't contain an @ symbol throw new ArgumentException("The email must contain an @ symbol");
// In the setter, else set the _email = value;


// TODO: Create 2 methods to encapsulate the _password field
// 1 called GetPassword() which returns the value stored in the _password field
// 1 called SetValidPassword() which validates the _password field before setting it
// the password should be at least 10 characters long
// the password should contain at least 2 special symbols [!@#$%^&*()]
// the password should contain at least 2 uppercase letters


// TODO: Create a new User and give the 3 fields valid values
var user1 = new User();
user1.UserName = "John";
user1.Email = "123@gmail.com";
user1.SetValidPassword("TestPa$$word");


// TODO: Display the 3 fields to the console
Console.WriteLine($"Username: {user1.UserName}");
Console.WriteLine($"Email: {user1.Email}");
Console.WriteLine($"Password: {user1.GetPassword()}");