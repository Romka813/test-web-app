using WebApp.Interfaces.Operation;

namespace WebApp.Interfaces.OperationProvider
{
	public interface IOperationProvider
	{
		IOperation[] GetOperations();
	}
}
