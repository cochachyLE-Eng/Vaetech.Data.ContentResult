using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vaetech.Data.ContentResult.Enums;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!
* Owners: Liiksoft
* Create by Luis Eduardo Cochachi Chamorro
* License: MIT or Apache-2.0
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!*/
namespace Vaetech.Data.ContentResult
{        
    public partial class ActionResult : BaseResult
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public dynamic Data { get; set; }

        public ActionResult() { }
        public ActionResult(dynamic data) => Data = data;
        public ActionResult(bool ibExeption, string message) => (IbException, Message) = (ibExeption, message);
        public new static ActionResult Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult Fail(int code, string message, params string[] causes) => new ActionResult { Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult Success(int code, string message) => new ActionResult { Code = code, IbException = false, Message = message };
        protected ActionResult Copy() => this.MemberwiseClone() as ActionResult;
    }
    public partial class ActionResult<T> : ActionResult
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T Value { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public IEnumerable<T> List { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Paging Paging { get; set; }
        public ActionResult() { }
        public ActionResult(T value, bool ibExeption = false, string message = null) : base(ibExeption, message) => Value = value;
        public ActionResult(IEnumerable<T> list, Paging paging) => (List, Paging) = (list, paging);
        public ActionResult(IEnumerable<T> list, bool ibExeption = false, string message = null) : base(ibExeption, message) => List = list;        
        public ActionResult(dynamic data) => Data = data;
        public ActionResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static ActionResult<T> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult<T> Fail(int code, string message, params string[] causes) => new ActionResult<T>{ Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult<T> Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult<T> Success(int code, string message) => new ActionResult<T>{ Code = code, IbException = false, Message = message };
    }    
    public class ActionResult<T1, T2> : ActionResult
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ActionResult<T1> Result1 { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ActionResult<T2> Result2 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2) 
        {
            Result1 = result1;
            Result2 = result2;            
        }
        public new static ActionResult<T1, T2> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult<T1, T2> Fail(int code, string message, params string[] causes) => new ActionResult<T1, T2>{ Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult<T1, T2> Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult<T1, T2> Success(int code, string message) => new ActionResult<T1, T2>{ Code = code, IbException = false, Message = message };
    }    
    public class ActionResult<T1, T2, T3> : ActionResult<T1, T2>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ActionResult<T3> Result3 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3)
            : base(result1, result2) => Result3 = result3;
        public new static ActionResult<T1, T2, T3> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult<T1, T2, T3> Fail(int code, string message, params string[] causes) => new ActionResult<T1, T2, T3>{ Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult<T1, T2, T3> Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult<T1, T2, T3> Success(int code, string message) => new ActionResult<T1, T2, T3>{ Code = code, IbException = false, Message = message };
    }    
    public class ActionResult<T1, T2, T3, T4> : ActionResult<T1, T2, T3>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ActionResult<T4> Result4 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4)
            : base(result1, result2, result3) => Result4 = result4;
        public new static ActionResult<T1, T2, T3, T4> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult<T1, T2, T3, T4> Fail(int code, string message, params string[] causes) => new ActionResult<T1, T2, T3, T4>{ Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult<T1, T2, T3, T4> Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult<T1, T2, T3, T4> Success(int code, string message) => new ActionResult<T1, T2, T3, T4>{ Code = code, IbException = false, Message = message };
    }    
    public class ActionResult<T1, T2, T3, T4, T5> : ActionResult<T1, T2, T3, T4>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ActionResult<T5> Result5 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4, ActionResult<T5> result5)
            : base(result1, result2, result3, result4) => Result5 = result5;
        public new static ActionResult<T1, T2, T3, T4, T5> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult<T1, T2, T3, T4, T5> Fail(int code, string message, params string[] causes) => new ActionResult<T1, T2, T3, T4, T5>{ Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult<T1, T2, T3, T4, T5> Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult<T1, T2, T3, T4, T5> Success(int code, string message) => new ActionResult<T1, T2, T3, T4, T5>{ Code = code, IbException = false, Message = message };
    }    
    public class ActionResult<T1, T2, T3, T4, T5, T6> : ActionResult<T1, T2, T3, T4, T5>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ActionResult<T6> Result6 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4, ActionResult<T5> result5, ActionResult<T6> result6)
            : base(result1, result2, result3, result4, result5) => Result6 = result6;
        public new static ActionResult<T1, T2, T3, T4, T5, T6> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult<T1, T2, T3, T4, T5, T6> Fail(int code, string message, params string[] causes) => new ActionResult<T1, T2, T3, T4, T5, T6>{ Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult<T1, T2, T3, T4, T5, T6> Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult<T1, T2, T3, T4, T5, T6> Success(int code, string message) => new ActionResult<T1, T2, T3, T4, T5, T6>{ Code = code, IbException = false, Message = message };
    }
    public class ActionResult<T1, T2, T3, T4, T5, T6, T7> : ActionResult<T1, T2, T3, T4, T5, T6>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public ActionResult<T7> Result7 { get; set; }
        public ActionResult() { }
        public ActionResult(ActionResult<T1> result1, ActionResult<T2> result2, ActionResult<T3> result3, ActionResult<T4> result4, ActionResult<T5> result5, ActionResult<T6> result6, ActionResult<T7> result7)
            : base(result1, result2, result3, result4, result5, result6) => Result7 = result7;
        public new static ActionResult<T1, T2, T3, T4, T5, T6, T7> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static ActionResult<T1, T2, T3, T4, T5, T6, T7> Fail(int code, string message, params string[] causes) => new ActionResult<T1, T2, T3, T4, T5, T6, T7>{ Code = code, IbException = true, Message = message, Causes = causes };
        public new static ActionResult<T1, T2, T3, T4, T5, T6, T7> Success(StatusCode code, string message) => Success((int)code, message);
        public new static ActionResult<T1, T2, T3, T4, T5, T6, T7> Success(int code, string message) => new ActionResult<T1, T2, T3, T4, T5, T6, T7>{ Code = code, IbException = false, Message = message };
    }    
}
