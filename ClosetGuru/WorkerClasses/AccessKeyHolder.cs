using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClosetInventory.WorkerClasses
{
    public class AccessKeyHolder
    {
        private string accessKey = "AKIAJ3HAD7WFOAKEB4MQ";
        private string secretKey = "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";

        public string GetAccessKey()
        {
            return accessKey;
        }

        public string GetSecretKey()
        {
            return secretKey;
        }
    }
}