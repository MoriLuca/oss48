//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oss48.DB.Cucina
{
    using System;
    using System.Collections.Generic;
    
    public partial class ricette
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<int> Difficolta { get; set; }
        public Nullable<int> TempoPreparazione { get; set; }
        public string Testo { get; set; }
    }
}
