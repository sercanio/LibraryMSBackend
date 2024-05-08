using NArchitecture.Core.Application.Responses;

namespace Application.Features.FeedBacks.Commands.Update;

public class UpdatedFeedBackResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}