namespace WebApp.Interfaces.Calculator
{
	public interface ICalculatorService
	{
		decimal Calculate(decimal[] values);
		int GetNumberOfArguments();
	}
}
