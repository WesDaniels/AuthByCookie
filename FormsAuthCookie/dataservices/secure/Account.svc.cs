namespace FormsAuthCookie.dataservices.secure
{
  using System.ServiceModel.Activation;
  using System.Web;

  [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
  public class Account : IAccount
  {
    public string Ping()
    {
      return "Pong!";
    }

    public string GetCustomer()
    {
      var httpCookie = HttpContext.Current.Request.Cookies["USCookie"];
      if (httpCookie != null && httpCookie["UniqueId"] != null)
      {
        return httpCookie["UniqueId"];
      }
      return "not found";
    }
  }
}