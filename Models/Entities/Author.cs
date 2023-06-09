﻿namespace BOOKSHOP.Models.Entities
{
    public class Author : BaseEntity
    {
        public string RefNo { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
