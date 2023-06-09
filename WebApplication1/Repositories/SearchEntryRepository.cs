﻿using WebApplication1.Data;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class SearchEntryRepository:IRepository
    {
        private readonly WebApplication1Context _context;
        public SearchEntryRepository(WebApplication1Context context)
        {
            _context = context;
        }
        public IQueryable<SearchEntry> GetAllSearchEntries()
        {
            return _context.SearchEntries;
        }
        public void postNewSearchEntry(SearchEntry entry)
        {
            _context.SearchEntries.Add(entry);
        }
        public void deleteEntry(SearchEntry entry)
        {
            _context.SearchEntries.Remove(entry);
        }
        public SearchEntry GetSearchEntryById(int id)
        {
            return _context.SearchEntries.Find(id);
        }
        public void saveChanges()
        {
            _context.SaveChanges();
        }
    }
}
