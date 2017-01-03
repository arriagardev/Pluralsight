using System;

namespace Generics
{
    //public class SetupWorkflow : IDisposable, IComparable
    //{
    //    public int CompareTo(object obj)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class SetupWorkflow : WorkItemBase { }
    public class StartWorkflow : WorkItemBase { }
    public class StopWorkflow { }

    public abstract class WorkItemBase { }


    //public class Workflow<T> where T : class, IDisposable, IComparable, new()
    //{
        
    //}
    public class Workflow
    {
        public void Process<T>(T s) where T : WorkItemBase
        {

        }
    }
}
