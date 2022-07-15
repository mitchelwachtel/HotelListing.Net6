﻿using System;
using HotelListing.API.Data;

namespace HotelListing.API.Contracts
{
    public interface IHotelsRepository : IGenericRepository<Hotel>
    {
        Task<Hotel> GetDetails(int id);
    }
}


