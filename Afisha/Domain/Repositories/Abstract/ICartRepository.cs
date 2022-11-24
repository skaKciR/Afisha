﻿using Afisha.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Afisha.Domain.Repositories.Abstract
{
    public interface ICartRepository
    {
        public IQueryable<Cart> GetEventItems();

        public void SaveCartItem(Cart entity);

        public IQueryable<Event> GetCartByName(string name);
        public void DeleteFromCartById(Guid eventId, string userName);
    }
}
