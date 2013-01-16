namespace FormsAuthCookie
{
  using System;
  using System.ServiceModel.Activation;
  using System.Web;
  using System.Web.Routing;

  public class Global : HttpApplication
  {
    protected void Application_Start(object sender, EventArgs e)
    {
      RouteTable.Routes.Add(new ServiceRoute("data/secure/", new WebServiceHostFactory(), typeof(dataservices.secure.Account)));
      RouteTable.Routes.Add(new ServiceRoute("data/", new WebServiceHostFactory(), typeof(dataservices.Account)));
    }

    protected void Session_Start(object sender, EventArgs e)
    {
    }

    protected void Application_BeginRequest(object sender, EventArgs e)
    {
      if (HttpContext.Current.Request.Url.AbsolutePath.Contains("/secure/"))
      {
        if (HttpContext.Current.Request.Cookies["USCookie"] == null)
        {
          Response.StatusCode = 401;
          Response.End();
        }
      }
    }

    protected void Application_AuthenticateRequest(object sender, EventArgs e)
    {
    }

    protected void Application_Error(object sender, EventArgs e)
    {
    }

    protected void Session_End(object sender, EventArgs e)
    {
    }

    protected void Application_End(object sender, EventArgs e)
    {
    }
  }
}