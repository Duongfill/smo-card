﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmoCard.Core.Domain.Content;

namespace SmoCard.Core.Models.Content
{
    public class TagDto
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public required string Name { get; set; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<Tag, TagDto>();
            }
        }
    }
}
