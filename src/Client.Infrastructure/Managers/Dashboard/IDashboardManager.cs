﻿using ProjectServices.Shared.Wrapper;
using System.Threading.Tasks;
using ProjectServices.Application.Features.Dashboards.Queries.GetData;

namespace ProjectServices.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}