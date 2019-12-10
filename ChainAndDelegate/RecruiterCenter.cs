using System;
using System.Collections.Generic;
using System.Text;

namespace ChainAndDelegate
{
    public sealed class RecruiterCenter
    {
        public Recruiter Site { get; set; }
        public Recruiter ItRecruiter { get; set; }
        public Recruiter TeamLead { get; set; }

        public bool ViewResume(string resume)
        {
            return Site.ViewResume(resume);
        }
    }
}
