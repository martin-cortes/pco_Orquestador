using System;

namespace Helpers.Commons.Exceptions
{
    public class CoreException : Exception
    {
        /// <sumary>
        /// DynamicData
        /// </sumary>
        public dynamic DynamicData { get; set; }

        /// <summary>
        /// code
        /// </summary>
        public int Code { get; set; }

        /// <sumary>
        /// Constructor
        /// </sumary>
        public CoreException()
        { }

        /// <sumary>
        /// Constructor
        /// </sumary>
        /// <param name="message"></param>
        public CoreException(string message)
            : base(message) { }

        /// <sumary>
        /// Constructor
        /// </sumary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public CoreException(string message, Exception inner)
            : base(message, inner) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
        public CoreException(string message, int code) : base($"CoreException: {message}")
        {
            Code = code;
        }

        /// <sumary>
        /// Constructor
        /// </sumary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        public CoreException(string message, dynamic data) : base($"CoreException: {message}")
        {
            DynamicData = data;
        }
    }
}
