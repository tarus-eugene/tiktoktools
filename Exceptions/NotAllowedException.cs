using System;
using System.Collections.Generic;
using System.Text;

namespace TikTokTools.Exceptions
{
    internal class NotAllowedException : Exception
    {
        public NotAllowedException() { }
        public NotAllowedException(string message) : base(message) { }
        public NotAllowedException(string message, Exception inner) : base(message, inner) { }
    }
}
