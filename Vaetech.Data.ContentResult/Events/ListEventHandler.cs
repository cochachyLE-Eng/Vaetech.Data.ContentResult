using System;
using System.Collections.Generic;

namespace Vaetech.Data.ContentResult.Events
{
    public delegate void ListEventHandler<T>(object sender, ListEventArgs<T> e);
    public class ListEventArgs<T> : EventArgs
    {
        public IEnumerable<T> List { get; set; }
        public (int container, int lot) Pack { get; set; } = (0, 0);
        public ListEventArgs(IEnumerable<T> list) => List = list;
        public ListEventArgs(IEnumerable<T> list, (int container, int lot) pack) => (List, Pack) = (list, pack);
    }
    public delegate void ListEventHandler<T, T1>(object sender, ListEventArgs<T, T1> e);
    public class ListEventArgs<T, T1> : ListEventArgs<T>
    {        
        public T1 Item1 { get; set; }
        public ListEventArgs(IEnumerable<T> list, T1 item1) : base(list) => Item1 = item1;
        public ListEventArgs(IEnumerable<T> list, T1 item1, (int container, int lot) pack) : base(list, pack) => Item1 = item1;
    }
    public delegate void ListEventHandler<T, T1, T2>(object sender, ListEventArgs<T, T1, T2> e);
    public class ListEventArgs<T, T1, T2> : ListEventArgs<T, T1>
    {
        public T2 Item2 { get; set; }
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2) : base(list, item1) => Item2 = item2;
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, (int container, int lot) pack) : base(list, item1, pack) => Item2 = item2;
    }
    public delegate void ListEventHandler<T, T1, T2, T3>(object sender, ListEventArgs<T, T1, T2, T3> e);
    public class ListEventArgs<T, T1, T2, T3> : ListEventArgs<T, T1, T2>
    {
        public T3 Item3 { get; set; }
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3) : base(list, item1, item2) => Item3 = item3;
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, (int container, int lot) pack) : base(list, item1, item2, pack) => Item3 = item3;
    }
    public delegate void ListEventHandler<T, T1, T2, T3, T4>(object sender, ListEventArgs<T, T1, T2, T3, T4> e);
    public class ListEventArgs<T, T1, T2, T3, T4> : ListEventArgs<T, T1, T2, T3>
    {
        public T4 Item4 { get; set; }
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4) : base(list, item1, item2, item3) => Item4 = item4;
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4, (int container, int lot) pack) : base(list, item1, item2, item3, pack) => Item4 = item4;
    }
    public delegate void ListEventHandler<T, T1, T2, T3, T4, T5>(object sender, ListEventArgs<T, T1, T2, T3, T4, T5> e);
    public class ListEventArgs<T, T1, T2, T3, T4, T5> : ListEventArgs<T, T1, T2, T3, T4>
    {
        public T5 Item5 { get; set; }
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) : base(list, item1, item2, item3, item4) => Item5 = item5;
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, (int container, int lot) pack) : base(list, item1, item2, item3, item4, pack) => Item5 = item5;
    }
    public delegate void ListEventHandler<T, T1, T2, T3, T4, T5, T6>(object sender, ListEventArgs<T, T1, T2, T3, T4, T5, T6> e);
    public class ListEventArgs<T, T1, T2, T3, T4, T5, T6> : ListEventArgs<T, T1, T2, T3, T4, T5>
    {
        public T6 Item6 { get; set; }
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) : base(list, item1, item2, item3, item4, item5) => Item6 = item6;
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, (int container, int lot) pack) : base(list, item1, item2, item3, item4, item5, pack) => Item6 = item6;
    }
    public delegate void ListEventHandler<T, T1, T2, T3, T4, T5, T6, T7>(object sender, ListEventArgs<T, T1, T2, T3, T4, T5, T6, T7> e);
    public class ListEventArgs<T, T1, T2, T3, T4, T5, T6, T7> : ListEventArgs<T, T1, T2, T3, T4, T5, T6>
    {
        public T7 Item7 { get; set; }
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) : base(list, item1, item2, item3, item4, item5, item6) => Item7 = item7;
        public ListEventArgs(IEnumerable<T> list, T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, (int container, int lot) pack) : base(list, item1, item2, item3, item4, item5, item6, pack) => Item7 = item7;
    }
}