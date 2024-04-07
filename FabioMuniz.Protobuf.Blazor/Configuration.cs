namespace FabioMuniz.Protobuf.Blazor;

public static class Configuration
{
	public static ApiConfiguration Api { get; set; } = new();
	public class ApiConfiguration
	{
		public string UrlBase { get; set; } = string.Empty;
		public string HttpClientName { get; set; } = string.Empty;
	}
}
