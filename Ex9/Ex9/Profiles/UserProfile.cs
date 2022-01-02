using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ex9.Entities;
using Ex9.Models;

namespace Ex9.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto >()
                .ForMember(d => d.FullName, o => o.MapFrom(s => $"{s.FirstName} {s.MiddleName} {s.LastName}"))
                .ForMember(d=>d.Birthdate, o=>o.MapFrom(s=>s.Birthday.ToString("dddd, dd MMMM yyy HH':'mm'' ")))
                .ForMember(d=>d.IsEmailInCorrectFormat, o=>o.MapFrom(s=>(s.Email.Contains("@")&& s.Email.Contains(".")) ? true: false))
                .ForMember(d => d.NormalizedEmail, o => o.MapFrom(s=>s.Email.ToUpper()))
                .ForMember(d => d.NormalizedEmail, o => o.NullSubstitute("?"))
                //.ForMember(d => d.NormalizedEmail, o => o.MapFrom(s => s.Email))
                .ForMember(d=>d.PhoneNumber, o=>o.MapFrom(s=>$"+{s.PhoneCountryCode}{s.PhoneNumber}"))
                .ForMember(d=>d.IdNumber, o=>o.MapFrom(s=>s.Identification.Count))  //Identification.Value
                .ForMember(d=>d.Details, o=>o.Ignore()).ReverseMap();
        }
    }
}
