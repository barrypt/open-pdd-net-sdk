using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class UploadGoodsImageResponseModel : PddResponseModel
    {
        /// <summary>
/// 商品图片上传响应对象
/// </summary>
[JsonProperty("goods_image_upload_response")]
public object GoodsImageUploadResponse {get;set;}
/// <summary>
/// 返回图片url
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}

    public partial class GoodsImageUploadResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回图片url
/// </summary>
[JsonProperty("image_url")]
public object ImageUrl {get;set;}

}

}
}