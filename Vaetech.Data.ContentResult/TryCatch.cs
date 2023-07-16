using System;
using System.Threading.Tasks;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!
* Owners: Liiksoft
* Create by Luis Eduardo Cochachi Chamorro
* License: MIT or Apache-2.0
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!*/
namespace Vaetech.Data.ContentResult
{
    public class Try
    {
        public static TupleResult<T> Catch<T>(Func<T> action)
            => Catch<T, Exception>(action, out Exception exception);       
        public static TupleResult<T> Catch<T, TException>(Func<T> action, out TException exception) where TException : Exception
        {
            try
            {
                T value = action();
                return new TupleResult<T>(value, false, (exception = default(TException))?.Message);
            }
            catch (TException ex)
            {
                return new TupleResult<T>(default(T), true, (exception = ex).Message);
            }
        }
        public static async Task<TupleResult<T>> CatchAsync<T>(Func<Task<T>> action)
            => await CatchAsync<T, Exception>(action);
        public static async Task<TupleResult<T>> CatchAsync<T, TException>(Func<Task<T>> action, Action<TException> exception = null) where TException : Exception
        {            
            try
            {
                T value = await action();
                return new TupleResult<T>(value, false, default(TException)?.Message);
            }
            catch (TException ex)
            {
                exception?.Invoke(ex);
                return new TupleResult<T>(default(T), true, ex.Message);
            }
        }
    }
}
