using System;
namespace CSModule4
{
    public class SetupWorkflow : WorkItemBase { }
    public class StartWorkflow : WorkItemBase { }
    public class StopWorkflow { }

    public abstract class WorkItemBase { }

    public class Workflow
    {
        public void Process<T>(T s) where T : WorkItemBase
        { 
        
        }
    }
}
