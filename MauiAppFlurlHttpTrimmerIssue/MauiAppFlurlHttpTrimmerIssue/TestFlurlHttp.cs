using Flurl.Http;

namespace MauiAppFlurlHttpTrimmerIssue
{
    internal class TestFlurlHttp
    {
        public Task RunAsync()
        {
            return new FlurlClient(new HttpClient())
                .Request()
                .SendAsync(HttpMethod.Post, new StringContent("sc"));
        }
    }
}
