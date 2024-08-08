namespace Movies.Contracts.Responses;

public class MovieResponse
{
    public required Guid Id { get; init; }
    public required string Title { get; init; }
    public required int ReleaseYear { get; init; }
    public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
    public required string Slug { get; init; }
}
