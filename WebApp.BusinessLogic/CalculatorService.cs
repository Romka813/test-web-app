using System;
using WebApp.Interfaces.Calculator;
using WebApp.Interfaces.Operation;
using WebApp.Interfaces.OperationProvider;

namespace WebApp.BusinessLogic
{
	public class CalculatorService : ICalculatorService
	{
		private readonly IOperation[] _operations;

		public CalculatorService(IOperationProvider operationProvider)
		{
			_operations = operationProvider.GetOperations();
		}

		public decimal Calculate(decimal[] values)
		{
			if (values.Length != _operations.Length + 1)
				throw new InvalidOperationException("Argument count doesn't match with operations");

			decimal result = values[0];
			for (int i = 0; i < _operations.Length; i++)
			{
				result = _operations[i].Execute(result, values[i + 1]);
			}
			return result;
		}

		public int GetNumberOfArguments()
		{
			return _operations.Length + 1;
		}
	}
}
