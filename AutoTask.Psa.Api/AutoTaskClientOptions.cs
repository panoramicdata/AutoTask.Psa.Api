using System.ComponentModel.DataAnnotations;

namespace AutoTask.Psa.Api
{
	public class AutoTaskClientOptions
	{
		public int? ServerId { get; set; }

		public string? UserName { get; set; }

		public string? Password { get; set; }

		public string? IntegrationCode { get; set; }

		public void Validate()
		{
			if (ServerId is null)
			{
				throw new ValidationException($"{nameof(ServerId)} missing.");
			}
			if (UserName is null)
			{
				throw new ValidationException($"{nameof(UserName)} missing.");
			}
			if (Password is null)
			{
				throw new ValidationException($"{nameof(Password)} missing.");
			}
			if (IntegrationCode is null)
			{
				throw new ValidationException($"{nameof(IntegrationCode)} missing.");
			}
		}
	}
}