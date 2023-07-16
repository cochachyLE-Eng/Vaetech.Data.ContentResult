using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Vaetech.Data.ContentResult
{
    [DataContract]
    public class Paging
    {
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Page Page { get; set; }
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Page First { get; set; }
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Page Previous { get; set; }
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Page> Pages { get; set; }
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Page Next { get; set; }
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Page Last { get; set; }
        public Paging() {
            Page = new Page();
            First = new Page();
            Previous = new Page();
            Pages = new List<Page>();
            Next = new Page();
            Last = new Page();
        }
    }

    [DataContract]
    public partial class Page
    {
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Route { get; set; }
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int Value { get; set; }
        [DataMember, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int Rows { get; set; } = 0;
        
        public event EventHandler Handler;
    }
}
