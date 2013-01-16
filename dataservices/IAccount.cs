namespace FormsAuthCookie.dataservices
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
            UriTemplate = "Login/{name}")]
    string Login(string name);
  }
}
