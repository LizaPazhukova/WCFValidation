using System.Linq;
using System.Text.RegularExpressions;


public class Service : IService
{
	private readonly Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
	public bool Validate(string name, string password)
	{
		Match match = emailRegex.Match(name);
		bool isName = match.Success;
	
		bool isPassword = !password.Any(ch => !char.IsLetterOrDigit(ch));
		return isPassword && isName;
	}
}
