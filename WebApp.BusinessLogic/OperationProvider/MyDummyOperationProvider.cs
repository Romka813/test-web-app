using WebApp.BusinessLogic.Operations;
using WebApp.Interfaces.Operation;
using WebApp.Interfaces.OperationProvider;

namespace WebApp.BusinessLogic.OperationProvider
{
	public class MyDummyOperationProvider : IOperationProvider
	{
		public IOperation[] GetOperations()
		{
			return new IOperation[] {new Addition(), new Substraction(), new Division(), new Multiplication()};
		}
	}
}
