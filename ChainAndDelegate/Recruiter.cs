using System;
using System.Collections.Generic;
using System.Text;

namespace ChainAndDelegate
{
    public sealed class Recruiter
    {
        private Recruiter _next;
        private Func<string, bool> _handelFunc;

        public Recruiter(Func<string, bool> handelFunc)
        {
            _handelFunc = handelFunc;
        }

        public void SetNextRecruiter(Recruiter recruiter)
        {
            _next = recruiter;
        }

        public bool ViewResume(string resume)
        {
            if (_handelFunc(resume))
            {
                if (_next != null)
                    return _next.ViewResume(resume);
                else
                    return true;
            }
            else
                return false;
        }
    }
}
