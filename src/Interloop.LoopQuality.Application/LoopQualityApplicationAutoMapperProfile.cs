using AutoMapper;
using Interloop.LoopQuality.Books;

namespace Interloop.LoopQuality;

public class LoopQualityApplicationAutoMapperProfile : Profile
{
    public LoopQualityApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
