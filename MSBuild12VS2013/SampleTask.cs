using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Build.Utilities;

namespace MSBuild12VS2013
{
    public class SampleTask : Task
    {
        public override bool Execute()
        {
            this.Log.LogMessage("Message from sample task.");

            return true;
        }
    }
}
