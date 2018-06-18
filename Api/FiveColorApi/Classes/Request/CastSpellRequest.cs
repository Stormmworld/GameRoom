using FiveColorApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiveColorApi.Classes.Request
{
    public class CastSpellRequest
    {
        public int CardId { get; set; }
        public string GameId { get; set; }
        public int PlayerId { get; set; }
        public List<Target> Targets { get; set; }
    }
}