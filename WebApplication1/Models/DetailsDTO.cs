using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    [DataContract(IsReference = true)]

    public class DetailsDTO
    {
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]


        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public string Locatie { get; set; }
        [DataMember]
        public string Anotimp { get; set; }
        [DataMember]
        public string Data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [DataMember]
        public string People { get; set; }

        [DataMember]
        public int Count { get; set; }
    }
}
