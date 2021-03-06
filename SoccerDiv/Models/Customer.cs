//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoccerDiv.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.News = new HashSet<News>();
        }
    
        public int Customer_ID { get; set; }

        [Required(ErrorMessage = "Choose your favourite team!!")]
        [Display(Name = "Team Name")]
        public int Team_ID { get; set; }

        [Required(ErrorMessage = "Enter your name!!")]
        [Display(Name = "Customer Name")]
        [StringLength(25, ErrorMessage = "Maximum 25 character")]
        public string Customer_Name { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Customer_Email { get; set; }

        [Required(ErrorMessage = "Enter your Phone no")]
        [Phone]
        [Display(Name = "Phone No")]
        public string Customer_PhoneNO { get; set; }

        [Required(ErrorMessage = "Enter your Address")]
        [Display(Name = "Address")]
        public string Customer_Address { get; set; }

        [Required(ErrorMessage = "Enter your Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters allowed")]
        [MinLength(6, ErrorMessage = "Atleast 6 character required")]
        public string Customer_Password { get; set; }

        [Display(Name = "Profile Pic")]
        public string Customer_Image { get; set; }

        public HttpPostedFileBase CustomerImageFile { get; set; }

        public virtual Team Team { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }
    }
}
