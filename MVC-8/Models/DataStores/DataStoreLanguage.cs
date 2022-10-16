﻿using Microsoft.EntityFrameworkCore;
using MVC_8.Data;

namespace MVC_8.Models.Home {
    public class DataStoreLanguage: DataStoreItem<Language> {
        public DataStoreLanguage(ApplicationDbContext db, DbSet<Language> ds) : base(db, ds) { }

        override public void DeleteItem(int id) {
            Language? item = DbSet.Include("People").FirstOrDefault(item => item.Id == id);
            if (item == null) throw new ItemNotFoundException();
            // Language item = GetItemById(id);
            item.People.Clear();
            Db.SaveChanges();
            DbSet.Remove(item);
            Db.SaveChanges();
        }
    }
}