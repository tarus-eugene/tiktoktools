using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TikTokTools.Models
{
    [Table("AppConfig")]
    public class ApplicationConfig
    {
        [Key]
        public int Id { get;} = 1;
        public string TempFolderPath { get; set; }
        public string OutputFolderPath { get; set; }
        public string TikTokApiKey { get; set; }
        public string ElevenLabsApiKey { get; set; }
    }
}
