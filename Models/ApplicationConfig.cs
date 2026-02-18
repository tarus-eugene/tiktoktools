using System;
using System.Collections.Generic;
using System.Text;

namespace TikTokTools.Models
{
    internal class ApplicationConfig
    {
        public int Id { get; } = 1;
        public string TempFolderPath { get; set; }
        public string OutputFolderPath { get; set; }
        public string TikTokApiKey { get; set; }
        public string ElevenLabsApiKey { get; set; }
    }
}
