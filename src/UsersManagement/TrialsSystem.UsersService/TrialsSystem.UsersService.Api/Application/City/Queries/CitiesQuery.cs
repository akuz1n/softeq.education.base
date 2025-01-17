﻿using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDtos;

namespace TrialsSystem.UsersService.Api.Application.City.Queries
{
    public class CitiesQuery : IRequest<IEnumerable<GetCityResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public CitiesQuery(int? skip, int? take)
        {
            Skip = skip;
            Take = take;
        }
    }
}
