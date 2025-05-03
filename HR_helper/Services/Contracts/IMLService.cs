namespace HR_helper.Services.Contracts
{
    public interface IMLService
    {
        Task<string> AnalyzeSkillsAsync(string[] skills);
    }
}
