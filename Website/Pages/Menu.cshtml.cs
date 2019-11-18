using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Variable for holding the menu
        /// </summary>
        public Menu menu { get; } = new Menu();

        public void OnGet()
        {

        }
    }
}