﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookStoreRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
