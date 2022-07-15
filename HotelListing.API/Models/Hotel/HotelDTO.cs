using System;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Models.Hotel
{
    public class HotelDTO : BaseHotelDTO
    {
        public int Id { get; set; }

        public GetCountryDTO Country { get; set; }
    }
}

