namespace FIT5032_32747861.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Session { get; set; }

        [Required]
        public string DoctorName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Start { get; set; }
    }
}
