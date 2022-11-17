using System.Collections.Generic;
using Vaetech.Data.ContentResult.Events;
using Xunit;

namespace Vaetech.Data.ContentResult.XUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ActionResult<bool> result = new ActionResult<bool>();
            result.IbException = true;
            result.SetMessage(1, "message 1");

            List<int> data = new List<int>();
            ListEventArgs<int> e = new ListEventArgs<int>(data);
        }
    }
}