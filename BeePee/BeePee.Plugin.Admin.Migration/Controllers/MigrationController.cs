using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Services.Configuration;
using Nop.Web.Framework.Controllers;

namespace BeePee.Plugin.Admin.Migration.Controllers
{
    public class MigrationController : BasePluginController 
    {
        private readonly ISettingService _settingService;

        public MigrationController(ISettingService settingService)
        {
            _settingService = settingService;
        }


    }
}
