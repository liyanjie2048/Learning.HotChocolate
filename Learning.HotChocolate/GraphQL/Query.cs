using GreenDonut.Data;

using HotChocolate.Types.Pagination;

using Learning.HotChocolate.Models;

namespace Learning.HotChocolate.GraphQL;

[QueryType]
public static partial class Query
{
    [UsePaging(IncludeTotalCount = true)]
    [UseFiltering]
    [UseSorting]
    public static ValueTask<Connection<User>> Users(
        QueryContext<User> queryContext,
        PagingArguments pagingArguments,
        CancellationToken cancellationToken)
    {
        return Array.Empty<User>().AsQueryable()
            .With(queryContext)
            .ToPageAsync(pagingArguments, cancellationToken)
            .ToConnectionAsync();
    }
}
