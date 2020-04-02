using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatHotel_Monolith.Enum
{
    public enum MealType
    {
        [Display(Name = "Standard")]
        Standard = 1,
        [Display(Name = "Luxury")]
        Luxury = 2,
        [Display(Name = "Bring Your Own Food")]
        OwnFood = 3

    }
}
