using Microsoft.AspNetCore.Mvc;

namespace GiveNTake.Controllers
{
    public class MessagesController : Controller
    {
        public string[] My()
        {
            return new[]
            {
                "Is the Microwave working?",
                "Where can i pick the washing machine from?",
            };
        }

        public string Details(int id)
        {
            return $"{id} - Is the Microwave working?";
        }
    }
}