namespace SurevyPoC.Data;

public class SurveyModel
{
    public int survey_id { get; set; }
    public string survey_title { get; set; }
    public string survey_subtitle { get; set; } = string.Empty;
    public string status { get; set; }
    public string e_mail { get; set; }
    public string county_name { get; set; }
    public string opcounty_name { get; set; }
    public string whole_name { get; set; }
    public string target_poid { get; set; }
    public string poid { get; set; }
    public int oy_mm { get; set; }
    public string addr_other { get; set; }
    public string op_zip4 { get; set; }
    public string state_alpha { get; set; }
    public string project_code { get; set; }
    public int xstatelink { get; set; }
    public bool farm_flag { get; set; }
    public bool saved_flag { get; set; }
    public string place_name { get; set; }
    public string af_imageid { get; set; }
    public string op_email { get; set; }
    public string op_phone { get; set; }
    public bool cati_flag { get; set; }
    public string phone { get; set; }
    public bool capi_flag { get; set; }
    public string zip5 { get; set; }
    public int SDsurvey { get; set; }
    public string personid { get; set; }
    public bool phone_cell_flag { get; set; }
    public int lang { get; set; }
    public bool callout_flag { get; set; }
    public string op_county_id { get; set; }
    public bool capi_appt_flag { get; set; }
    public int child_quest_id_1 { get; set; }
    public string sample_id { get; set; }
    public string enumerator_id { get; set; }
    public int af_seg_reported_acres { get; set; }
    public string cawi_stop_date { get; set; }
    public bool deleted { get; set; }
    public bool op_phone_cell_flag { get; set; }
    public string op_state_alpha { get; set; }
    public string addr_delivery { get; set; }
    public string op_zip5 { get; set; }
    public string survey_date { get; set; }
    public string smeta_key { get; set; }
    public string userkey { get; set; }
    public int coordination_id { get; set; }
    public int capi_attempted_contacts { get; set; }
    public string cawi_start_date { get; set; }
    public string op_addr_delivery { get; set; }
    public bool review_flag { get; set; }
    public string respdate { get; set; }
    public string zip4 { get; set; }
    public string supervisor_id { get; set; }
    public string capi_start_date { get; set; }
    public string cati_start_date { get; set; }
    public int skey { get; set; }
    public int response_code { get; set; }
    public string comments { get; set; }
    public int data_capture_code { get; set; }
    public string mseqnum { get; set; }
    public string capi_stop_date { get; set; }
    public bool phone_only_flag { get; set; }
    public string cati_stop_date { get; set; }
    public bool disconnect_flag { get; set; }
    public int subtract { get; set; }
    public bool phone_oth_cell_flag { get; set; }
    public bool started_flag { get; set; }
    public bool cawi_flag { get; set; }
    public string op_place_name { get; set; }
    public int tract { get; set; }
    public int operid { get; set; }
    public string stratum { get; set; }
    public string county_id { get; set; }
    public int ruid { get; set; }
    public int op_dom_status_id { get; set; }
    public int state_id { get; set; }
    public string op_addr_other { get; set; }
    public string oper_name { get; set; }
    public int oy_dd { get; set; }
    public string phone_other { get; set; }
}