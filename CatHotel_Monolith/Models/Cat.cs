using CatHotel_Monolith.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatHotel_Monolith.Models
{

    public class Cat
    {
        public Guid ID { get; set; }
        public string TagID { get; set; }
        public bool Vaccination { get; set; }
        [Display(Name = "Date Of Last Vacc")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public virtual DateTime DateOfLastVac { get; set; }
        [Display(Name = "Meal Type")]
        public virtual MealType MealType { get; set; }
        [Display(Name = "Cat's Name")]
        public string CatName { get; set; }
        [Display(Name = "Cat's Litter")]
        public string CatLitter { get; set; }
        [Display(Name = "Cat's Chatacter")]
        public string CatCharacter { get; set; }
        [Display(Name = "Cat's Vet Name")]
        public string CatVetName { get; set; }
        [Display(Name = "Cat's Vet Address")]
        public string CatVetAddress1 { get; set; }
        [Display(Name = "Cat's Vet Address")]
        public string CatVetAddress2 { get; set; }
        [Display(Name = "Cat's Vet postcode")]
        public string CatVetPostCode { get; set; }
        [Display(Name = "Cat's Vet city")]
        public string CatVetCity { get; set; }
        [Display(Name = "Cat's Vet No.")]
        public string CatVetPhoneNo { get; set; }
        [Display(Name = "Cat's Medical Condition")]
        public string CatMedicalCondition { get; set; }
        public virtual Customer Customer { get; set; }

        public bool? ChekedIn { get; set; }
        public bool? ChekedOut { get; set; }
        public string UserId { get; set; }
    }
}
