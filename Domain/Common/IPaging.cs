namespace Abc.Domain
{
    public interface IPaging
    {
        int PageSize { get; set; }
        int TotalPages { get; }
        int PageIndex { get; set; }
        bool HasNextPage { get; }
        bool HasPreviousPage { get; }
    }
}
