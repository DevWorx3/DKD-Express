using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DKD_Express.Models
{
    public class EmailModel
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
    }
}