namespace Models;

public class User : object
{
	public User() : base()
	{
	}

	public string? Username { get; set; }

	public string? FullName { get; set; }

	public string? Password { get; set; }
}
