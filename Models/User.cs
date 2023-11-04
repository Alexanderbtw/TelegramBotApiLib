using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApiLib.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class User
    {
        public ulong id { get; set; }
        public bool is_bot { get; set; }
        public string first_name { get; set; }
        public string? last_name { get; set; }
        public string? username { get; set; }
        public string? language_code { get; set; }
        public bool? is_premium { get; set; }
        public bool? added_to_attachment_menu { get; set; }
        public bool? can_join_groups { get; set; }
        public bool? can_read_all_group_messages { get; set; }
        public bool? supports_inline_queries { get; set; }
    }
}
