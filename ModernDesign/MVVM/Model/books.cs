//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModernDesign.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public books()
        {
            this.examplar = new HashSet<examplar>();
        }
    
        public int id_book { get; set; }
        public string name { get; set; }
        public string fam_avtora { get; set; }
        public string mesto_izdaniya { get; set; }
        public string izdatelstvo { get; set; }
        public Nullable<int> god_izdaniya { get; set; }
        public Nullable<int> Kolvo_str { get; set; }
        public Nullable<decimal> stoimost { get; set; }
        public Nullable<int> kolvo_ekzemplyarov_knigi_v_biblioteke { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<examplar> examplar { get; set; }
    }
}