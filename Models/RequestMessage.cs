using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApiLib.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RequestMessage
    {
        public int chat_id { get; set; }
        public string? message_thread_id { get; set; }
        public string text { get; set; }
        public string? parse_mode { get; set; }
        //public MessageEntity[] entities { get; set; }
        public bool? disable_web_page_preview { get; set; }
        public bool? disable_notification { get; set; }
        public bool? protect_content { get; set; }
        public bool? reply_to_message_id { get; set; }
        public bool? allow_sending_without_reply { get; set; }
        //public ??? reply_markup { get; set; }


        public RequestMessage(int _chat_id, string _text)
        {
            chat_id = _chat_id;
            text = _text;
        }
    }
}
