using System;
using Interloop.LoopQuality.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Interloop.LoopQuality.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = LoopQualityPermissions.Books.Default;
        GetListPolicyName = LoopQualityPermissions.Books.Default;
        CreatePolicyName = LoopQualityPermissions.Books.Create;
        UpdatePolicyName = LoopQualityPermissions.Books.Edit;
        DeletePolicyName = LoopQualityPermissions.Books.Delete;
    }
}