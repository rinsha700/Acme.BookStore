using Acme.BookStore.Books;
<<<<<<< HEAD
using Acme.BookStore.Departments;
using Acme.BookStore.Educamps;
=======
>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
using Acme.BookStore.Parties;
using Acme.BookStore.UserTypes;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

<<<<<<< HEAD
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();

            CreateMap<UserType, UserTypeDto>();
            CreateMap<CreateUpdateUserTypeDto, UserType>();

            CreateMap<Party, PartyDto>();
            CreateMap<CreateUpdatePartyDto, Party>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateUpdateDepartmentDto, Department>();

            CreateMap<Educamp, EducampDto>();
            CreateMap<CreateUpdateEducampDto, Educamp>();
=======

        CreateMap<Book, BookDto>().ReverseMap();    
       
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<UserType, UserTypeDto>().ReverseMap();
        CreateMap<CreateUpdateUserTypeDto, UserType>();


        CreateMap<Partie, PartieDto>().ReverseMap();
        CreateMap<CreateUpdatePartieDto, Partie>();

>>>>>>> ab7e28665a8817470cab72f508d91c6603497a96
    }


    }

