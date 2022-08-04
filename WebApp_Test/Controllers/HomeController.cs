using Microsoft.AspNetCore.Mvc;
using WebApp_Test.Models;

namespace WebApp_Test.Controllers
{
    public class HomeController : Controller
    {        
        public IRepository<Message> InboxRepo = Inbox.SharedInbox;
        public IActionResult Index()
        {
            return View(InboxRepo.Items);
        }
        [HttpPost]
        public void DeleteMessages([FromBody] IEnumerable<int> MessagesIds)
        {
            foreach (var id in MessagesIds)
            {
                InboxRepo.DeleteById(id);
            }
        }
    }
}
