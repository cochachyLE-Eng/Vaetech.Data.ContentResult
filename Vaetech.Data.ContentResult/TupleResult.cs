using System.Runtime.Serialization;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!
* Owners: Liiksoft
* Create by Luis Eduardo Cochachi Chamorro
* License: MIT or Apache-2.0
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!*/
namespace Vaetech.Data.ContentResult
{
    [DataContract]
    public partial class TupleResult
    {
        #region Message Error, Alert, Information
        [DataMember]
        public bool IbException { get; set; }
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string[] Causes { get; set; }
        #endregion      
        public TupleResult() { }
        public TupleResult(bool ibExeption, string message)
        {
            IbException = ibExeption;
            Message = message;
        }
        public virtual void SetMessage(int code, string message, string[] causes = null) 
        {
            Code = code;
            Message = message;
            Causes = causes;
        }
    }    
    public class TupleResult<T1>: TupleResult
    {
        public T1 Item1 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, bool ibExeption = false, string message = null) : base(ibExeption, message) => Item1 = item1;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }

    }
    public class TupleResult<T1, T2> : TupleResult<T1>
    {        
        public T2 Item2 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, bool ibExeption = false, string message = null) : base(item1, ibExeption, message) => Item2 = item2;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
    }
    public class TupleResult<T1, T2, T3> : TupleResult<T1, T2>
    {
        public T3 Item3 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, bool ibExeption = false, string message = null) : base(item1, item2, ibExeption, message) => Item3 = item3;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
    }
    public class TupleResult<T1, T2, T3, T4> : TupleResult<T1, T2, T3>
    {
        public T4 Item4 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, bool ibExeption = false, string message = null) : base(item1, item2, item3, ibExeption, message) => Item4 = item4;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
    }
    public class TupleResult<T1, T2, T3, T4, T5> : TupleResult<T1, T2, T3, T4>
    {
        public T5 Item5 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, bool ibExeption = false, string message = null) : base(item1, item2, item3, item4, ibExeption, message) => Item5 = item5;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
    }
    public class TupleResult<T1, T2, T3, T4, T5, T6> : TupleResult<T1, T2, T3, T4, T5>
    {
        public T6 Item6 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, bool ibExeption = false, string message = null) : base(item1, item2, item3, item4, item5, ibExeption, message) => Item6 = item6;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
    }
    public class TupleResult<T1, T2, T3, T4, T5, T6, T7> : TupleResult<T1, T2, T3, T4, T5, T6>
    {
        public T7 Item7 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, bool ibExeption = false, string message = null) : base(item1, item2, item3, item4, item5, item6, ibExeption, message) => Item7 = item7;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
    }
    public static class TupleResultEx
    {
        public static ActionResult ToActionResult(this TupleResult dynamicResult)
            => new ActionResult(dynamicResult.IbException, dynamicResult.Message);
        public static ActionResult<T1> ToActionResult<T1>(this TupleResult<T1> dynamicResult)
            => new ActionResult<T1>(dynamicResult.Item1, dynamicResult.IbException, dynamicResult.Message);
        public static ActionResult<T1, T2> ToActionResult<T1, T2>(this TupleResult<T1, T2> dynamicResult)
            => new ActionResult<T1, T2>(
                new ActionResult<T1>(dynamicResult.Item1, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T2>(dynamicResult.Item2, dynamicResult.IbException, dynamicResult.Message));        
        public static ActionResult<T1, T2, T3> ToActionResult<T1, T2, T3>(this TupleResult<T1, T2, T3> dynamicResult)
            => new ActionResult<T1, T2, T3>(
                new ActionResult<T1>(dynamicResult.Item1, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T2>(dynamicResult.Item2, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T3>(dynamicResult.Item3, dynamicResult.IbException, dynamicResult.Message));
        public static ActionResult<T1, T2, T3, T4> ToActionResult<T1, T2, T3, T4>(this TupleResult<T1, T2, T3, T4> dynamicResult)
            => new ActionResult<T1, T2, T3, T4>(
                new ActionResult<T1>(dynamicResult.Item1, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T2>(dynamicResult.Item2, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T3>(dynamicResult.Item3, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T4>(dynamicResult.Item4, dynamicResult.IbException, dynamicResult.Message));
        public static ActionResult<T1, T2, T3, T4, T5> ToActionResult<T1, T2, T3, T4, T5>(this TupleResult<T1, T2, T3, T4, T5> dynamicResult)
            => new ActionResult<T1, T2, T3, T4, T5>(
                new ActionResult<T1>(dynamicResult.Item1, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T2>(dynamicResult.Item2, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T3>(dynamicResult.Item3, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T4>(dynamicResult.Item4, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T5>(dynamicResult.Item5, dynamicResult.IbException, dynamicResult.Message));
        public static ActionResult<T1, T2, T3, T4, T5, T6> ToActionResult<T1, T2, T3, T4, T5, T6>(this TupleResult<T1, T2, T3, T4, T5, T6> dynamicResult)
            => new ActionResult<T1, T2, T3, T4, T5, T6>(
                new ActionResult<T1>(dynamicResult.Item1, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T2>(dynamicResult.Item2, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T3>(dynamicResult.Item3, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T4>(dynamicResult.Item4, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T5>(dynamicResult.Item5, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T6>(dynamicResult.Item6, dynamicResult.IbException, dynamicResult.Message));
        public static ActionResult<T1, T2, T3, T4, T5, T6, T7> ToActionResult<T1, T2, T3, T4, T5, T6, T7>(this TupleResult<T1, T2, T3, T4, T5, T6, T7> dynamicResult)
            => new ActionResult<T1, T2, T3, T4, T5, T6, T7>(
                new ActionResult<T1>(dynamicResult.Item1, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T2>(dynamicResult.Item2, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T3>(dynamicResult.Item3, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T4>(dynamicResult.Item4, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T5>(dynamicResult.Item5, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T6>(dynamicResult.Item6, dynamicResult.IbException, dynamicResult.Message),
                new ActionResult<T7>(dynamicResult.Item7, dynamicResult.IbException, dynamicResult.Message));
    }
}
