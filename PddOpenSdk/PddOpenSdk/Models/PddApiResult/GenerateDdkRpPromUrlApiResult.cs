namespace PddOpenSdk.Models.PddApiResult
{
    
public class UrlList
{
    public string url { get; set; }
    public string short_url { get; set; }
    public string mobile_url { get; set; }
    public string mobile_short_url { get; set; }
    public string multi_group_url { get; set; }
    public string multi_group_short_url { get; set; }
    public string multi_group_mobile_url { get; set; }
    public string multi_group_mobile_short_url { get; set; }
}


public class RpPromotionUrlGenerateResponse
{
    public List<UrlList> url_list { get; set; }
}


public class GenerateDdkRpPromUrlApiResult
{
    public RpPromotionUrlGenerateResponse rp_promotion_url_generate_response { get; set; }
}

}