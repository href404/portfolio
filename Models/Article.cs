﻿namespace Portfolio.Models
{
    public class Article
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Title { get; init; }
        public bool IsWritten { get; set; }
    }
}