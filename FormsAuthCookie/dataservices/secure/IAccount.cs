namespace FormsAuthCookie.dataservices.secure
{
  using System.ServiceModel;
  using System.ServiceModel.Web;

  [ServiceContract]
  public interface IAccount
  {
    [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "Ping")]
    string Ping();

    [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Wrapped,
        UriTemplate = "getcustomer")]
    string GetCustomer();
  }
}
