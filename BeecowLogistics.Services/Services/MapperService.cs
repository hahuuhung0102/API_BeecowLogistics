﻿using AutoMapper;
using BeecowLogistics.Services.Interfaces;

namespace BeecowLogistics.Services.Services
{
    public class MapperService : IMapperService
    {
        private readonly IMapper mapper;

        public MapperService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TDestination ConvertTo<TSource, TDestination>(TSource source)
        {
            var converted = mapper.Map<TDestination>(source);
            return converted;
        }
    }
}
