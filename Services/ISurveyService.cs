using SurevyPoC.Data;

public interface ISurveyService
{
    Task<IEnumerable<SurveyModel>> GetAllSurveysAsync();
    Task<SurveyOperator> GetSurveyOperatorAsync();
    Task<List<SurveyDetails>> GetSurveyDetailsAsync();
}