using HR_helper.Services.Contracts;

namespace HR_helper.Services
{
    public class MLService : IMLService
    {
        public async Task<string> AnalyzeSkillsAsync(string[] skills)
        {
            var random = new Random();
            var positions = new[] { "девопсер", "аналитик", "сисьадмин", "погромист" };
            return await Task.FromResult(positions[random.Next(positions.Length)]);
        }
    }
}
