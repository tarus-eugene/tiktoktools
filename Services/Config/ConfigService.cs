using System;
using System.Collections.Generic;
using System.Text;
using TikTokTools.Data;
using TikTokTools.Models;
using TikTokTools.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace TikTokTools.Services.Config;

public class ConfigService : IConfigService
{
    private readonly Context _context;

    public ConfigService(Context context)
    {
        this._context = context;
    }

    public async Task<ApplicationConfig> GetConfig()
    {
        ApplicationConfig? config = await _context.AppConfig.FindAsync(1);
        
        if (config == null)
        {
            throw new NotFoundException("No Value found matching input id");
        }

        return config;
    }

    public async Task<ApplicationConfig> SaveConfig(ApplicationConfig newConfig)
    {
        var config = await GetConfig();
        var updatedConfig = UpdateConfig(newConfig, config);

        await _context.AppConfig.Where(e => e.Id == 1).ExecuteDeleteAsync();

        await _context.AppConfig.AddAsync(updatedConfig);

        _context.SaveChanges();

        return updatedConfig;
    }

    private ApplicationConfig UpdateConfig(ApplicationConfig source, ApplicationConfig target)
    {
        foreach (var property in typeof(ApplicationConfig).GetProperties())
        {
            if(property.Name != "Id")
            {
                var sourceVal = property.GetValue(source);
                var targetVal = property.GetValue(target);

                if (sourceVal != null && sourceVal != targetVal)
                {
                    property.SetValue(target, sourceVal);
                }
            }
        }

        return target;
    }
}
