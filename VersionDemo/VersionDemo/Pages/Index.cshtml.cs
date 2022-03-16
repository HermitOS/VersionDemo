using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace VersionDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public HtmlString Version { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Version = new HtmlString(Assembly.GetExecutingAssembly().GetName().Version.ToString());
            
        }



        public void OnGet()
        {

        }
    }
}