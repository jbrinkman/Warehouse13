using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleRepository.Entities.DataObjects
{
    public class ErrorDetails
    {
        public string AssemblyVersion { get; set; }
        public int PortalId { get; set; }
        public string PortalName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int ActiveTabId { get; set; }
        public string ActiveTabName { get; set; }
        public string RawUrl { get; set; }
        public string AbsoluteUrl { get; set; }
        public string AbsoluteUrlReferrer { get; set; }
        public string UserAgent { get; set; }
        public string ExceptionGuid { get; set; }
        public string InnerException { get; set; }
        public string Message { get; set; }

    }
}
