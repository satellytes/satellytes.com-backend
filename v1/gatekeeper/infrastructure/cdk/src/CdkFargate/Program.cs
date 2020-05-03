using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CdkFargate
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CdkFargateStack(app, "CdkSatellytesBackend");
            app.Synth();
        }
    }
}
