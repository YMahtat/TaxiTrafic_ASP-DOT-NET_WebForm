//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxiTrafic
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Taxis = new HashSet<Taxi>();
        }
    
        public int ID { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public int PROFIL { get; set; }
    
        public virtual ICollection<Taxi> Taxis { get; set; }
    }
}
