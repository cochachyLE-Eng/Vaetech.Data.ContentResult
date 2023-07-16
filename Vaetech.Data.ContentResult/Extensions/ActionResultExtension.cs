using System.Collections.Generic;

namespace Vaetech.Data.ContentResult.Extensions
{
    public static partial class ActionResultExtension {
        public static ActionResult<T> ToActionResult<T>(this T value)
            => new ActionResult<T>(value: value);
        public static ActionResult<T> ToActionResult<T>(this IEnumerable<T> list)
            => new ActionResult<T>(list: list);
    }    
}
