namespace FormsAuthCookie.dataservices
{
  using System;
  using System.ServiceModel.Activation;
  using System.Web;

  [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
  public class Account : IAccount
  {
    public string Ping()
    {
      return "Pong!";
    }

    public string Login(string name)
    {
      HttpCookie myCookie = new HttpCookie("USCookie");
      myCookie.HttpOnly = true;
      myCookie["UniqueId"] = "I'm Unique!";
      myCookie.Expires = DateTime.Now.AddDays(1d);
      HttpContext.Current.Response.Cookies.Add(myCookie);

      return name;
    }
  }
}
