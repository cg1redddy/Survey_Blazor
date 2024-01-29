using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class SurveyDetails
{
    public int survey_id { get; set; }
    [Display(Name = "Survey Name")]
    public string survey_title { get; set; }

    public string survey_date { get; set; }
    public string survey_subtitle { get; set; }
    [Display(Name = "Status")]
    public string status { get; set; }
    [Display(Name = "Due Date")]
    public string capi_stop_date { get; set; }
    public string due_date { get; set; }
    public int skey { get; set; }

}