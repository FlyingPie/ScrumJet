using Newtonsoft.Json;
using RazorEngine;
using RazorEngine.Templating;
using System;
using System.IO;
using System.Linq;

namespace ScrumJet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var configFile = "config.json";

            if (!File.Exists(configFile))
            {
                Console.WriteLine("Missing configuration file named 'config.json'.");
                return;
            }

            var configContent = File.ReadAllText(configFile);
            var config = JsonConvert.DeserializeObject<Configuration>(configContent);

            var workItems = TfsQuery.GetWorkItems(config.Server, config.ProjectCollection, config.AreaPath, config.IterationPath);

            //var fields = workItems[0].Fields.Cast<Microsoft.TeamFoundation.WorkItemTracking.Client.Field>().Select(f => new { f.Name, f.Value }).ToList();

            var vm = new ViewModel();
            vm.Initialize(workItems);

            //var vm = TestViewModel.GetTestViewModel();

            vm.WorkItems = vm.WorkItems
                .OrderBy(wi => wi.ParentId != 0 ? wi.ParentId : wi.Id)
                .ToList();

            // Razor stuff
            var template = File.ReadAllText(@"Template.cshtml");

            var r = Engine.Razor.RunCompile(template, "templateKey", typeof(ViewModel), vm);

            File.WriteAllText(@"Output\index.html", r);
        }
    }
}