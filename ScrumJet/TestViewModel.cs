using System.Collections.Generic;

namespace ScrumJet
{
    public static class TestViewModel
    {
        public static ViewModel GetTestViewModel()
        {
            return new ViewModel()
            {
                WorkItems = new List<ViewModel.WorkItemVM>()
                {
                    new ViewModel.WorkItemVM()
                    {
                        Id = 101,
                        Type = "Product Backlog Item",
                        Activity = "",
                        Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Effort = 8,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },

                    new ViewModel.WorkItemVM()
                    {
                        Id = 999999,
                        ParentId = 999999,
                        Type = "Task",
                        Activity = "Development",
                        Name = "Development 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 43,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Testing",
                        Name = "Development 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 44,
                        ParentId = 101,
                        Activity = "",
                        Type = "Task",
                        Name = "Testing 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 45,
                        ParentId = 101,
                        Activity = "",
                        Type = "Bug",
                        Name = "Bug 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 101,
                        Type = "Product Backlog Item",
                        Activity = "",
                        Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Effort = 8,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },

                    new ViewModel.WorkItemVM()
                    {
                        Id = 42,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Development",
                        Name = "Development 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 43,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Testing",
                        Name = "Development 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 44,
                        ParentId = 101,
                        Activity = "",
                        Type = "Task",
                        Name = "Testing 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 45,
                        ParentId = 101,
                        Activity = "",
                        Type = "Bug",
                        Name = "Bug 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 101,
                        Type = "Product Backlog Item",
                        Activity = "",
                        Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Effort = 8,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },

                    new ViewModel.WorkItemVM()
                    {
                        Id = 42,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Development",
                        Name = "Development 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 43,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Testing",
                        Name = "Development 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 44,
                        ParentId = 101,
                        Activity = "",
                        Type = "Task",
                        Name = "Testing 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 45,
                        ParentId = 101,
                        Activity = "",
                        Type = "Bug",
                        Name = "Bug 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 101,
                        Type = "Product Backlog Item",
                        Activity = "",
                        Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Effort = 8,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },

                    new ViewModel.WorkItemVM()
                    {
                        Id = 42,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Development",
                        Name = "Development 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 43,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Testing",
                        Name = "Development 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 44,
                        ParentId = 101,
                        Activity = "",
                        Type = "Task",
                        Name = "Testing 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 45,
                        ParentId = 101,
                        Activity = "",
                        Type = "Bug",
                        Name = "Bug 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 101,
                        Type = "Product Backlog Item",
                        Activity = "",
                        Name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Effort = 8,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },

                    new ViewModel.WorkItemVM()
                    {
                        Id = 42,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Development",
                        Name = "Development 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 43,
                        ParentId = 101,
                        Type = "Task",
                        Activity = "Testing",
                        Name = "Development 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 44,
                        ParentId = 101,
                        Activity = "",
                        Type = "Task",
                        Name = "Testing 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                    new ViewModel.WorkItemVM()
                    {
                        Id = 45,
                        ParentId = 101,
                        Activity = "",
                        Type = "Bug",
                        Name = "Bug 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                    },
                }
            };
        }
    }
}