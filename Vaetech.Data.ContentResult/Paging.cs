using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vaetech.Data.ContentResult
{
    [DataContract]
    public class Paging
    {
        [DataMember]
        public Page Page { get; set; }
        [DataMember]
        public Page First { get; set; }
        [DataMember]
        public Page Previous { get; set; }
        [DataMember]
        public List<Page> Pages { get; set; }
        [DataMember]
        public Page Next { get; set; }
        [DataMember]
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
        [DataMember]
        public string Route { get; set; }
        [DataMember]
        public int Value { get; set; }
        [DataMember]
        public int Rows { get; set; } = 0;
        
        public event EventHandler Handler;
    }
}
