using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [DataContract(IsReference = true)]
    public class PeopleDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nume { get; set; }
        [DataMember]
        public int PhotosId { get; set; }
        [DataMember]
        public virtual DetailsDTO Details { get; set; }
    }
}
