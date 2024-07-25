﻿namespace DbOperationsWithEFCoreApp.Data
{
   
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NoOfPages { get; set; }
        public bool IsActive { get; set; }
        public bool CreatedOn { get; set; }
        public int LanguageId { get; set; }

        public Language Language { get; set; } //will as a foreighn key for language table (language class)




    }
}
