using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Framework.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrumJet
{
    public static class TfsQuery
    {
        public static List<Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem> GetWorkItems(string url, string projectCollection, string areaPath, string iterationPath)
        {
            var tfsUri = new Uri(url);
            var configurationServer = TfsConfigurationServerFactory.GetConfigurationServer(tfsUri);
            var teamProjects = configurationServer.CatalogNode.QueryChildren(new[] { CatalogResourceTypes.ProjectCollection }, false, CatalogQueryOptions.None);
            var teamProject = teamProjects.FirstOrDefault(c => c.Resource.DisplayName == projectCollection);

            var collectionId = new Guid(teamProject.Resource.Properties["InstanceId"]);
            var teamProjectCollection = configurationServer.GetTeamProjectCollection(collectionId);

            var workItemStore = (WorkItemStore)teamProjectCollection.GetService(typeof(WorkItemStore));

            var result = workItemStore
                .Query("select * from WorkItems where [Area Path] = '" + areaPath + "' and [Iteration Path] = '" + iterationPath + "'")
                .Cast<Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem>()
                .ToList();

            return result;
        }
    }
}