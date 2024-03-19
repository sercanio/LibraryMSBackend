using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Books.Queries.GetById;

public class GetByIdBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public BookStatus Status { get; set; }
    public Guid PublisherId { get; set; }
    public int CategoryId { get; set; }
    public Guid LocationId { get; set; }
}