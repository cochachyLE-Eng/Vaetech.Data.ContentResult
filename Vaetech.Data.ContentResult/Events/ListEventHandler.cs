using System;
using System.Collections.Generic;

namespace Vaetech.Data.ContentResult.Events
{
    public delegate void ListEventHandler<T>(object sender, ListEventArgs<T> e);
    public class ListEventArgs<T> : EventArgs
    {
        public IEnumerable<T> List { get; set; }
        public ListEventArgs(IEnumerable<T> list) => List = list;
    }
}
