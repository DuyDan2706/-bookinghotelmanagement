using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject.Model;
using DataAccess.Repository;

namespace HotelWeb.Pages
{
    public class IndexModel : PageModel
    {
      
     
        [BindProperty]
        public Room Room { get; set; }
        public IList<Room> RoomList { get; set; }
        public IList<RoomType> RoomTypeList { get; set; }
        public IActionResult OnGet()
        {           
            try
            {
              
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
            }

            return Page();
        }
    }
}
