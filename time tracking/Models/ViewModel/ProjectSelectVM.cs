using Microsoft.AspNetCore.Mvc.Rendering;

namespace time_tracking.Models.ViewModel
{
    public class ProjectSelectVM
    {
        public IEnumerable<SelectListItem> ProjectSelectList { get; set; }

    }
}
