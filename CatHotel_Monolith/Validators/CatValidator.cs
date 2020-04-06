using CatHotel_Monolith.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CatHotel_Monolith.Managers
{
    public class CatValidator : AbstractValidator<Cat>
    {
        public CatValidator()
        {
            var telephoneRegex = new Regex(@"^\s*\(?(020[7,8]{1}\)?[ ]?[1-9]{1}[0-9{2}[ ]?[0-9]{4})|(0[1-8]{1}[0-9]{3}\)?[ ]?[1-9]{1}[0-9]{2}[ ]?[0-9]{3})\s*$");
            var postcodeRegex = new Regex(@"^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z]))))\s?[0-9][A-Za-z]{2})$");

            RuleFor(x => x.TagID).NotEmpty().Must(length => length.Trim().Length != 10 || length.Trim().Length != 15).WithMessage(cat => $"The Tag Id of {cat.TagID} must either be 10 or 15 digits long.");
            RuleFor(x => x.Vaccination).NotEmpty().WithMessage("Please Enter if the cat has recieved their vacination. Yes or No.");
            RuleFor(x => x.DateOfLastVac.ToString()).NotEmpty().WithMessage("Date Of the Last Vaccenation cant be empty.");
            //TODO: check validation rules for enum
            //RuleFor(x => x.MealType).NotEmpty().IsInEnum();
            RuleFor(x => x.CatName).NotEmpty().MaximumLength(50).MinimumLength(2).WithMessage(cat => $"The cats Name cant be empty, more than 50 character or less than 2 characters. {cat.CatName} is not valid.");
            RuleFor(x => x.CatLitter).NotEmpty().WithMessage("Cat Litter Cant be Left Empty. Please advise whcih type of cat litter will be needed.");
            RuleFor(x => x.CatCharacter).NotEmpty().WithMessage("The Cats character must be added.");
            RuleFor(x => x.CatVetName).NotEmpty().MaximumLength(50).MinimumLength(2).WithMessage(cat => $"The Vets Name cant be empty, more than 50 character or less than 2 characters. {cat.CatVetName} is not valid.");
            RuleFor(x => x.CatVetAddress1).NotEmpty().WithMessage(cat => $"The First Line Of the Address cant be empty {cat.CatVetAddress1}.");
            RuleFor(x => x.CatVetAddress2).NotEmpty().WithMessage(cat => $"The Second Line Of the Address cant be empty {cat.CatVetAddress2}.");
            RuleFor(x => x.CatVetPostCode).NotEmpty().Matches(postcodeRegex).WithMessage(cat => $"{cat.CatVetPostCode} is not a valid Postcode. Please enter a valid Postcode");
            RuleFor(x => x.CatVetCity).NotEmpty().MaximumLength(50).WithMessage(cat => $"{cat.CatVetCity} is more than 50 characters. Please enter correct UK town.");
            RuleFor(x => x.CatVetPhoneNo).NotEmpty().Matches(telephoneRegex).WithMessage(cat => $"{cat.CatVetPhoneNo} is not a valid UK landline number.");
            //RuleFor(x => x.User).NotEmpty().WithMessage("Users Details must be provided");
            RuleFor(x => x.Customer).NotEmpty().WithMessage("Cats owner must be added");
        }
    }
}
