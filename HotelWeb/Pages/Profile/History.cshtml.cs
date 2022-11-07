using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObject.Model;
using DataAccess.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelWeb.Pages.Profile
{
    public class HistoryModel : PageModel
    {
      
      
        public IList<BookRoom> BookRoom { get; set; }
        public IList<RoomInBooking> RoomInBookings { get; set; }
        public IList<Room> Room { get; set; }
        public IActionResult OnGet()
        {
            try
            {
                if (HttpContext.Session.GetString("ROLE") != "Customer")
                {
                    return RedirectToPage("./Login");
                }
            
            }
            catch
            {

            }
            return Page();
        }
        public IActionResult OnPostCancel(int id)
        {
            try
            {
                TempData["Message"] = "Cancel Finsish";
                return RedirectToPage("./History");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                return RedirectToPage("./History");
            }
        }
    }
}
