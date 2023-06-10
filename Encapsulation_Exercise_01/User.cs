namespace Encapsulation_Exercise_01;

internal class User
{
    private string username;
    private string email;
    private string password;

    public string UserName
    {
        get => username;
        set
        {
            if (username == null)
            {
                throw new ArgumentNullException("The username must not be null");
            }
            else if (username.Length == 0)
            {
                throw new ArgumentException("The username must not be empty");
            }
            else
            {
                username = value;
            }
        }
    }


}
