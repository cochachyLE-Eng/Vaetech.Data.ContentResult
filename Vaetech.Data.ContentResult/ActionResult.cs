using System.Collections.Generic;
using System.Runtime.Serialization;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!
* Owners: Liiksoft
* Create by Luis Eduardo Cochachi Chamorro
* License: MIT or Apache-2.0
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!*/
namespace Vaetech.Data.ContentResult
{
    [DataContract]
    public partial class ActionResult
    {
        [DataMember]
        public dynamic Data { get; set; }

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

        public ActionResult() { }
        public ActionResult(dynamic data) => Data = data;
        public ActionResult(bool ibExeption, string message)
        {
            IbException = ibExeption;
            Message = message;
        }        
        protected ActionResult Copy() => this.MemberwiseClone() as ActionResult;        
    }
    [DataContract]
    public partial class ActionResult<T> : ActionResult
    {
        [DataMember]
        public T Value { get; set; }
        [DataMember]
        public IEnumerable<T> List { get; set; }       
        public ActionResult() { }
        public ActionResult(T value, bool ibExeption = false, string message = null) : base(ibExeption, message) => Value = value;        
        public ActionResult(IEnumerable<T> list, bool ibExeption = false, string message = null) : base(ibExeption, message) => List = list;        
        public ActionResult(dynamic data) => base.Data = data;
        public ActionResult(bool ibExeption, string message) : base(ibExeption, message) { }
    }
    [DataContract]
    public class ActionResult<T1, T2> : ActionResult
    {
        [DataMember]
        public ActionResult<T1> Result1 { get; set; }
        [DataMember]
        public ActionResult<T2> Result2 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2) 
        {
            Result1 = result1;
            Result2 = result2;            
        }
    }
    [DataContract]
    public class ActionResult<T1, T2, T3> : ActionResult<T1, T2>
    {
        [DataMember]
        public ActionResult<T3> Result3 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3)
            : base(result1, result2) => Result3 = result3;        
    }
    [DataContract]
    public class ActionResult<T1, T2, T3, T4> : ActionResult<T1, T2, T3>
    {
        [DataMember]
        public ActionResult<T4> Result4 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4)
            : base(result1, result2, result3) => Result4 = result4;
    }
    [DataContract]
    public class ActionResult<T1, T2, T3, T4, T5> : ActionResult<T1, T2, T3, T4>
    {
        [DataMember]
        public ActionResult<T5> Result5 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4, ActionResult<T5> result5)
            : base(result1, result2, result3, result4) => Result5 = result5;
    }
    [DataContract]
    public class ActionResult<T1, T2, T3, T4, T5, T6> : ActionResult<T1, T2, T3, T4, T5>
    {
        [DataMember]
        public ActionResult<T6> Result6 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4, ActionResult<T5> result5, ActionResult<T6> result6)
            : base(result1, result2, result3, result4, result5) => Result6 = result6;
    }
    [DataContract]
    public class ActionResult<T1, T2, T3, T4, T5, T6, T7> : ActionResult<T1, T2, T3, T4, T5, T6>
    {
        [DataMember]
        public ActionResult<T7> Result7 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4, ActionResult<T5> result5, ActionResult<T6> result6, ActionResult<T7> result7)
            : base(result1, result2, result3, result4, result5, result6) => Result7 = result7;
    }
}
