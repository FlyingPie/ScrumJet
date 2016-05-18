using Microsoft.TeamFoundation.WorkItemTracking.Client;
using System.Collections.Generic;
using System.Linq;

namespace ScrumJet
{
    public class ViewModel
    {
        public List<WorkItemVM> WorkItems { get; set; }

        public void Initialize(List<WorkItem> workItems)
        {
            WorkItems = workItems
               .Select(wi =>
               {
                   // Parent id
                   int parentId = 0;

                   foreach (var link in wi.Links)
                   {
                       var relatedLink = link as Microsoft.TeamFoundation.WorkItemTracking.Client.RelatedLink;

                       if (relatedLink != null && relatedLink.LinkTypeEnd != null && relatedLink.LinkTypeEnd.Name == "Parent")
                       {
                           parentId = relatedLink.RelatedWorkItemId;
                           break;
                       }
                   }

                   // Effort
                   int effort = 0;
                   if (wi.Fields.Contains("Effort"))
                   {
                       var val = wi.Fields["Effort"].Value;
                       if (val != null)
                       {
                           int.TryParse(val.ToString(), out effort);
                       }
                   }

                   var result = new ViewModel.WorkItemVM()
                   {
                       Id = wi.Id,
                       ParentId = parentId,
                       Type = wi.Type.Name,
                       Activity = wi.Fields.Contains("Activity") ? wi.Fields["Activity"].Value.ToString() : string.Empty,
                       Name = wi.Title,
                       Effort = effort,
                       Description = wi.Description
                   };

                   return result;
               })
               .ToList();
        }

        public class WorkItemVM
        {
            public int Id { get; set; }

            public int ParentId { get; set; }

            public string Type { get; set; }

            public string Activity { get; set; }

            public string Name { get; set; }

            public int Effort { get; set; }

            public string Description { get; set; }
        }
    }
}