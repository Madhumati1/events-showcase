using System;

namespace EventsShowcase.Models
{
    public class ErrorViewModel
    {
        public string RequestId {
            get;
            set;
        }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}