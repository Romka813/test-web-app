using WebApp.Interfaces.Operation;

namespace WebApp.BusinessLogic.Operations
{
	public class Addition : IOperation
	{
		public decimal Execute(decimal value1, decimal value2)
		{
			return value1 + value2;
		}
	}
}
