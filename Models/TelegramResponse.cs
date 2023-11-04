using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApiLib.Models
{
    public class TelegramResponse
    {
        public bool ok { get; set; }
        public User? result { get; set; }
    }
}
