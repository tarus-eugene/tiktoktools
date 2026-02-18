using System;
using System.Collections.Generic;
using System.Text;
using TikTokTools.Models;

namespace TikTokTools.Services.Config
{
    internal interface IConfigService
    {
        Task<ApplicationConfig> GetConfig();
        Task<ApplicationConfig> SaveConfig(ApplicationConfig newConfig);
    }
}
