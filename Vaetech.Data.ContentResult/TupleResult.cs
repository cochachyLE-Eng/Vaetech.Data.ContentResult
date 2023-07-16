using System.Text.Json.Serialization;
using Vaetech.Data.ContentResult.Enums;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!
* Owners: Liiksoft
* Create by Luis Eduardo Cochachi Chamorro
* License: MIT or Apache-2.0
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!*/
namespace Vaetech.Data.ContentResult
{    
    public partial class BaseResult
    {
        #region Message Error, Alert, Information
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IbException { get; set; } = false;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Code { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Message { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string[] Causes { get; set; }
        #endregion      
        public BaseResult() { }
        public BaseResult(bool ibException, string message)
        {
            IbException = ibException;
            Message = message;
        }        
        public virtual void SetMessage(int code, bool ibException, string message, string[] causes = null) => (Code, IbException, Message, Causes) = (code, ibException, message, causes);
        public static BaseResult Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public static BaseResult Fail(int code, string message, params string[] causes) => new BaseResult{ Code = code, IbException = true, Message = message, Causes = causes };        
        public static BaseResult Success(StatusCode code, string message) => Success((int)code, message);
        public static BaseResult Success(int code, string message) => new BaseResult{ Code = code, IbException = false, Message = message };        
    }
    public class TupleResult<T1> : BaseResult
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T1 Item1 { get; set; }        
        public TupleResult() { }
        public TupleResult(T1 item1, bool ibExeption = false, string message = null) : base(ibExeption, message) => Item1 = item1;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static TupleResult<T1> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static TupleResult<T1> Fail(int code, string message, params string[] causes) => new TupleResult<T1> { Code = code, IbException = true, Message = message, Causes = causes };
        public new static TupleResult<T1> Success(StatusCode code, string message) => Success((int)code, message);
        public new static TupleResult<T1> Success(int code, string message) => new TupleResult<T1> { Code = code, IbException = false, Message = message };
    }
    public class TupleResult<T1, T2> : TupleResult<T1>
    {        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T2 Item2 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, bool ibExeption = false, string message = null) : base(item1,ibExeption, message) => Item2 = item2;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static TupleResult<T1, T2> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static TupleResult<T1, T2> Fail(int code, string message, params string[] causes) => new TupleResult<T1, T2> { Code = code, IbException = true, Message = message, Causes = causes };
        public new static TupleResult<T1, T2> Success(StatusCode code, string message) => Success((int)code, message);
        public new static TupleResult<T1, T2> Success(int code, string message) => new TupleResult<T1, T2> { Code = code, IbException = false, Message = message };
    }
    public class TupleResult<T1, T2, T3> : TupleResult<T1, T2>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T3 Item3 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, bool ibExeption = false, string message = null) : base(item1, item2, ibExeption, message) => Item3 = item3;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static TupleResult<T1, T2, T3> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static TupleResult<T1, T2, T3> Fail(int code, string message, params string[] causes) => new TupleResult<T1, T2, T3> { Code = code, IbException = true, Message = message, Causes = causes };
        public new static TupleResult<T1, T2, T3> Success(StatusCode code, string message) => Success((int)code, message);
        public new static TupleResult<T1, T2, T3> Success(int code, string message) => new TupleResult<T1, T2, T3> { Code = code, IbException = false, Message = message };
    }
    public class TupleResult<T1, T2, T3, T4> : TupleResult<T1, T2, T3>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T4 Item4 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, bool ibExeption = false, string message = null) : base(item1, item2, item3, ibExeption, message) => Item4 = item4;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static TupleResult<T1, T2, T3, T4> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static TupleResult<T1, T2, T3, T4> Fail(int code, string message, params string[] causes) => new TupleResult<T1, T2, T3, T4> { Code = code, IbException = true, Message = message, Causes = causes };
        public new static TupleResult<T1, T2, T3, T4> Success(StatusCode code, string message) => Success((int)code, message);
        public new static TupleResult<T1, T2, T3, T4> Success(int code, string message) => new TupleResult<T1, T2, T3, T4> { Code = code, IbException = false, Message = message };
    }
    public class TupleResult<T1, T2, T3, T4, T5> : TupleResult<T1, T2, T3, T4>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T5 Item5 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, bool ibExeption = false, string message = null) : base(item1, item2, item3, item4, ibExeption, message) => Item5 = item5;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static TupleResult<T1, T2, T3, T4, T5> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static TupleResult<T1, T2, T3, T4, T5> Fail(int code, string message, params string[] causes) => new TupleResult<T1, T2, T3, T4, T5> { Code = code, IbException = true, Message = message, Causes = causes };
        public new static TupleResult<T1, T2, T3, T4, T5> Success(StatusCode code, string message) => Success((int)code, message);
        public new static TupleResult<T1, T2, T3, T4, T5> Success(int code, string message) => new TupleResult<T1, T2, T3, T4, T5> { Code = code, IbException = false, Message = message };
    }
    public class TupleResult<T1, T2, T3, T4, T5, T6> : TupleResult<T1, T2, T3, T4, T5>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T6 Item6 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, bool ibExeption = false, string message = null) : base(item1, item2, item3, item4, item5, ibExeption, message) => Item6 = item6;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static TupleResult<T1, T2, T3, T4, T5, T6> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static TupleResult<T1, T2, T3, T4, T5, T6> Fail(int code, string message, params string[] causes) => new TupleResult<T1, T2, T3, T4, T5, T6> { Code = code, IbException = true, Message = message, Causes = causes };
        public new static TupleResult<T1, T2, T3, T4, T5, T6> Success(StatusCode code, string message) => Success((int)code, message);
        public new static TupleResult<T1, T2, T3, T4, T5, T6> Success(int code, string message) => new TupleResult<T1, T2, T3, T4, T5, T6> { Code = code, IbException = false, Message = message };
    }
    public class TupleResult<T1, T2, T3, T4, T5, T6, T7> : TupleResult<T1, T2, T3, T4, T5, T6>
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public T7 Item7 { get; set; }
        public TupleResult() { }
        public TupleResult(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, bool ibExeption = false, string message = null) : base(item1, item2, item3, item4, item5, item6, ibExeption, message) => Item7 = item7;
        public TupleResult(bool ibExeption, string message) : base(ibExeption, message) { }
        public new static TupleResult<T1, T2, T3, T4, T5, T6, T7> Fail(StatusCode code, string message, params string[] causes) => Fail((int)code, message, causes);
        public new static TupleResult<T1, T2, T3, T4, T5, T6, T7> Fail(int code, string message, params string[] causes) => new TupleResult<T1, T2, T3, T4, T5, T6, T7> { Code = code, IbException = true, Message = message, Causes = causes };
        public new static TupleResult<T1, T2, T3, T4, T5, T6, T7> Success(StatusCode code, string message) => Success((int)code, message);
        public new static TupleResult<T1, T2, T3, T4, T5, T6, T7> Success(int code, string message) => new TupleResult<T1, T2, T3, T4, T5, T6, T7> { Code = code, IbException = false, Message = message };
    }    
}
