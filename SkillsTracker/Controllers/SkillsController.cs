using System;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult ProgammingLanguages()
        {
            string html = "<h1>" + "Skills Tracker" + "</h1>"
                + "<h2>" + "Coding skills to learn:" + "</h2>" +
                "<ol>" + "<li>" + "C#" + "</li>" + "<li>" + "JavaScript" + "</li>" + "<li>" + "Python" + "</li>" + "</ol>";
            return Content(html, "text/html");
        }

        [HttpGet]
        [Route("/skills/form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/form'>" +
                "<p><label for='start'> Date:</label>" +
                "<input type'date' id='start' name='date' value='' min='2020-01-01' max=2020-12-31'</p>" +
                "<p><label for='start'>C#:</label>" +
"<select id = 'python_skill' name = 'python_skill' > " +
"<option value='Just Learning'>Just Learning</option>" +
"<option value='Making Basic Apps'>Basic</option>" +
"<option value='Pro'>I got this</option>" +
"</select></p>" +
                "<p><label for='start'>JavaScript:</label>" +
"<select id = 'python_skill' name = 'python_skill' > " +
"<option value='Just Learning'>Just Learning</option>" +
"<option value='Making Basic Apps'>Basic</option>" +
"<option value='Pro'>I got this</option>" +
"</select></p>" +
      "<p><label for='start'>Python:</label>" +
"<select id = 'python_skill' name = 'python_skill' > " +
"<option value='Just Learning'>Just Learning</option>" +
"<option value='Making Basic Apps'>Basic</option>" +
"<option value='Pro'>I got this</option>" +
"</select></p>" +
"<input type='submit' value='Submit' />" +
"</form>";
            return Content(html, "text/html"); 
        }
    }
}
