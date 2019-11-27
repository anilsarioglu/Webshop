﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.UI_MVC
{
    internal static class MapDTO
    {
        internal static T1 Map<T1, T2>(T2 e)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T2, T1>());
            var mapper = config.CreateMapper();
            mapper = new Mapper(config);
            T1 dto = mapper.Map<T1>(e);
            return dto;
        }
    }
}