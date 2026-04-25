using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Aritmica.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult SaveStudent()
        {
            try
            {

                return Accepted();
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}
