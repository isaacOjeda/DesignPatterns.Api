using DesignPatterns.Api.Application.Common.Interfaces;
using System;

namespace DesignPatterns.Api.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
