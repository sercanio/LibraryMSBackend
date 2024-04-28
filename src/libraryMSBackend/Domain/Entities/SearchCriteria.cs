﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class SearchCriteria:Entity<Guid>
{
  
  
    public string? BookTitle { get; set; } // Nullable
    public string? MagazineTitle { get; set; }
    public string? MaterialName { get; set; }
    public string? AuthorName { get; set; }
    public string? AuthorSurname { get; set; }
    public string? MagazineISSNCode { get; set; }
    public string? BookISBNCode { get; set; }
    public string? CategoryName { get; set; }
    public string? PublisherName { get; set; }
    public string? PublisherLanguage { get; set; }
    public string? LocationsName { get; set; }
    public string? LocationsShelfName { get; set; }
    public string? MembersEmail { get; set; }


}

