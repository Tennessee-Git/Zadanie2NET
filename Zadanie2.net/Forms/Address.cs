using System;
using System.ComponentModel.DataAnnotations;

namespace Zadanie2.net.Forms
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string Street { get; set; }

        [Display(Name = "Kod pocztowy")]

        public string ZipCode { get; set; }

        [Display(Name = "Miasto")]

        public string City { get; set; }

        [Display(Name = "Numer")]
        public int Number { get; set; }

    }
}
