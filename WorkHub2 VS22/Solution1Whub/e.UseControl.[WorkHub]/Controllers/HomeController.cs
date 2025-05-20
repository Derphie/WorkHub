public class HomeController : BaseController
{
    // GET: Home
    public ActionResult Index()
    {
        string role = SessionStatus();
        if (((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login"))
        {
            return View();
        }
        else
        {
            if (role == "Admin")
                return RedirectToAction("IndexAdmin", "Admin");
            else
                return RedirectToAction("IndexUserLogin", "UserLogin");
        }
    }
}