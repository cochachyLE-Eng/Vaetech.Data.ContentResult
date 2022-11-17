using System;

namespace Vaetech.Data.ContentResult.Events
{
    public delegate void TupleEventHandler<T>(object sender, TupleEventArgs<T> e);
    public class TupleEventArgs<T> : EventArgs
    {
        public T Item { get; set; }
        public TupleEventArgs(T item) => Item = item;
    }
    public delegate void TupleEventHandler<T1, T2>(object sender, TupleEventArgs<T1, T2> e);
    public class TupleEventArgs<T1, T2> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
    public delegate void TupleEventHandler<T1, T2, T3>(object sender, TupleEventArgs<T1, T2, T3> e);
    public class TupleEventArgs<T1, T2, T3> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
    public delegate void TupleEventHandler<T1, T2, T3, T4>(object sender, TupleEventArgs<T1, T2, T3, T4> e);
    public class TupleEventArgs<T1, T2, T3, T4> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }
    }
    public delegate void TupleEventHandler<T1, T2, T3, T4, T5>(object sender, TupleEventArgs<T1, T2, T3, T4, T5> e);
    public class TupleEventArgs<T1, T2, T3, T4, T5> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }
        public T5 Item5 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
        }
    }
    public delegate void TupleEventHandler<T1, T2, T3, T4, T5, T6>(object sender, TupleEventArgs<T1, T2, T3, T4, T5, T6> e);
    public class TupleEventArgs<T1, T2, T3, T4, T5, T6> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }
        public T5 Item5 { get; set; }
        public T6 Item6 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
        }
    }
    public delegate void TupleEventHandler<T1, T2, T3, T4, T5, T6, T7>(object sender, TupleEventArgs<T1, T2, T3, T4, T5, T6, T7> e);
    public class TupleEventArgs<T1, T2, T3, T4, T5, T6, T7> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }
        public T5 Item5 { get; set; }
        public T6 Item6 { get; set; }
        public T7 Item7 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
            Item7 = item7;
        }
    }
    public delegate void TupleEventHandler<T1, T2, T3, T4, T5, T6, T7, T8>(object sender, TupleEventArgs<T1, T2, T3, T4, T5, T6, T7, T8> e);
    public class TupleEventArgs<T1, T2, T3, T4, T5, T6, T7, T8> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }
        public T5 Item5 { get; set; }
        public T6 Item6 { get; set; }
        public T7 Item7 { get; set; }
        public T8 Item8 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
            Item7 = item7;
            Item8 = item8;
        }
    }
    public delegate void TupleEventHandler<T1, T2, T3, T4, T5, T6, T7, T8, T9>(object sender, TupleEventArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9> e);
    public class TupleEventArgs<T1, T2, T3, T4, T5, T6, T7, T8, T9> : EventArgs
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }
        public T5 Item5 { get; set; }
        public T6 Item6 { get; set; }
        public T7 Item7 { get; set; }
        public T8 Item8 { get; set; }
        public T9 Item9 { get; set; }
        public TupleEventArgs(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
            Item7 = item7;
            Item8 = item8;
            Item9 = item9;
        }
    }
}
