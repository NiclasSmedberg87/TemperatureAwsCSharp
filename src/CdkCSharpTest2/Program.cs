using Amazon.CDK;
using Amazon.JSII.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CdkCSharpTest2
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();

           

            //var config = new ConfigService().GetConfig("config.json");


            new CdkCSharpTest2Stack(app, "CdkCSharpTest2Stack", new StackProps
            {
               Description = "Niclas Test stack",
               StackName = "TestN",
               Tags = new Dictionary<string, string>() { {"A","A" }, { "B", "B"} },
               Env = new Amazon.CDK.Environment
               {
                 Account = "145023139947",
                 Region = "eu-west-1",
                }
                
            });
            app.Synth();
           
        }
    }
}
