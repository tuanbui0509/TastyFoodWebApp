using TastyFoodSolution.ViewModels.Common;

using System;
using System.Collections.Generic;
using System.Text;

namespace TastyFoodSolution.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}