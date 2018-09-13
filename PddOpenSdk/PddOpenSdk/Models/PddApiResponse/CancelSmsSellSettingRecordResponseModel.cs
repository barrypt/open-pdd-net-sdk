using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class CancelSmsSellSettingRecordResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("sms_sell_setting_record_cancel_response")]
public object SmsSellSettingRecordCancelResponse {get;set;}
/// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool IsSuccess {get;set;}

    public partial class SmsSellSettingRecordCancelResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否成功
/// </summary>
[JsonProperty("is_success")]
public bool IsSuccess {get;set;}

}

}
}