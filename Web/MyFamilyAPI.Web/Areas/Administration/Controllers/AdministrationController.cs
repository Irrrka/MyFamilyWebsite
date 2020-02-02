namespace MyFamilyAPI.Web.Areas.Administration.Controllers
{
    using MyFamilyAPI.Common;
    using MyFamilyAPI.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
