namespace SwapiWebApp.Services.Models
{
	public class ServiceResult
	{
		public bool Success { get; private set; }
		public string Message { get; set; }

		protected ServiceResult(bool success, string message)
		{
			Success = success;
			Message = message;
		}

		protected ServiceResult(bool success, string message, Dictionary<string, string> errors)
		{
			Success = success;
			Message = message;
		}
	}

	public class ServiceResult<T> : ServiceResult
	{
		public T Content { get; set; }

		protected internal ServiceResult(bool success, string message, T value)
			: base(success, message)
		{
			Content = value;
		}
	}
}