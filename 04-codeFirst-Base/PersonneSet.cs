namespace _04_codeFirst_Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonneSet")]
    public partial class PersonneSet
    {
        public int Id { get; set; }

        [Required]
        public string nom { get; set; }

        public int age { get; set; }
    }
}
