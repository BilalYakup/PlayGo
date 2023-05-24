using PlayGo.Models.Concrete;
using Microsoft.AspNetCore.Identity;

namespace PlayGo.Areas.Admin.Models.RoleDTO
{
    public class AssignedDTO
    {
        public IdentityRole Role { get; set; }

        public IEnumerable<AppUser> HasRole { get; set; }
        public IEnumerable<AppUser> HasNotRole { get; set; }

        public string RoleName { get; set; }

        public string[] AddIds { get; set; }
        public string[] DeleteIds { get; set; }
    }
}
