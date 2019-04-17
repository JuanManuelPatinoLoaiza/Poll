
namespace Poll.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Survey
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
    }

}
