using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BookRepository : EfRepositoryBase<Book, Guid, BaseDbContext>, IBookRepository
{
    public BookRepository(BaseDbContext context) : base(context)
    {
    }

    private DbSet<Book> Books => Context.Set<Book>(); // DbSet eri�imi

    public IQueryable<Book> Table => Books.AsQueryable(); // IQueryable eri�imi
}