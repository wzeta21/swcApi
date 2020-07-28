using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Database.Entity.Threats
{
    public class Threat
    {
        public Guid Identifier { get; set; }

        public string Name { get; set; }

        public string Referer { get; set; }

        public string Host { get; set; }

        public string UserAgent { get; set; }

        public string XForwardHost { get; set; }

        public string XForwardProto { get; set; }

        public string QueryString { get; set; }

        public string Protocol { get; set; }

        public int ThreatTypeId { get; set; }
        public int StatusId { get; set; }

        public virtual ThreatType ThreatType { get; set; }

        public virtual Status Status { get; set; }
    }
}