using Microsoft.AspNetCore.Mvc;

namespace mvcdemo10.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        /// <summary>
        /// 儀表板首頁
        /// </summary>
        [Login()]
        public IActionResult Index()
        {
            ActionService.SetPrgInfo("Dashboard", "首頁儀表板");
            ActionService.SetActionName();
            ActionService.SetSubActionName();
            ActionService.SetActionCardSize(enCardSize.Max);
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        public IActionResult NotFinish()
        {
            TempData["ErrorMessage"] = "此功能尚未完成，敬請期待！";
            return RedirectToAction(ActionService.Index, ActionService.Controller, new { area = ActionService.Area });
        }
    }
}