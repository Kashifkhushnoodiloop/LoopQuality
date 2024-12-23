using AutoMapper;
using Interloop.LoopQuality.Books;

namespace Interloop.LoopQuality.Web;

public class LoopQualityWebAutoMapperProfile : Profile
{
    public LoopQualityWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
