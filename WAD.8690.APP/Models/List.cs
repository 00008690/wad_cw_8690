using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WAD._8690.APP.Models
{
    public class List
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("List name")]
        public string ListName { get; set; }
        [Required]
        [DisplayName("Created date")]
        public DateTime CreatedDate { get; set; }

        //navigation properties

        public List<Task> Tasks { get; set; }
    }
}
