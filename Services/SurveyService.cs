using SurevyPoC.Data;

public class SurveyService : ISurveyService
{
    private readonly HttpClient httpClient;

    private IEnumerable<SurveyModel> _response = null;

    public SurveyService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<IEnumerable<SurveyModel>> GetAllSurveysAsync()
    {
        _response = await httpClient.GetFromJsonAsync<SurveyModel[]>("/survey_datafed.json");

        return _response;
    }

    public async Task<SurveyOperator> GetSurveyOperatorAsync()
    {
        if (_response == null)
        {
            _response = await GetAllSurveysAsync();
        }
        var initialRecordForOperatorInfo = _response.FirstOrDefault();

        SurveyOperator surveyOperator = new()
        {
            operid = initialRecordForOperatorInfo.operid,
            oper_name = initialRecordForOperatorInfo.oper_name,
            whole_name = initialRecordForOperatorInfo.whole_name,
            state_id = initialRecordForOperatorInfo.state_id,
            state_alpha = initialRecordForOperatorInfo.state_alpha,
        };

        return surveyOperator;
    }

    public async Task<List<SurveyDetails>> GetSurveyDetailsAsync()
    {
        if (_response == null)
        {
            _response = await GetAllSurveysAsync();
        }
        List<SurveyDetails> surveyDetails = new();

        foreach (var item in _response)
        {
            SurveyDetails surveyObj = new()
            {
                survey_id = item.survey_id,
                survey_title = $"{item.survey_title} - {item.survey_date} - {item.survey_id} - {item.skey}",
                survey_subtitle = item.survey_subtitle,
                survey_date = item.survey_date,
                status = item.status,
                capi_stop_date = $"Submit by: {DateTime.Parse(item.capi_stop_date).ToShortDateString()}",
                due_date = item.capi_stop_date
            };
            surveyDetails.Add(surveyObj);
        }

        return surveyDetails;
    }
}