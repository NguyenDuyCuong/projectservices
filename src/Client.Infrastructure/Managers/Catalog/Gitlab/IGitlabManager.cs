using ProjectServices.Application.Features.Gitlab.Queries.GetAll;
using ProjectServices.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Client.Infrastructure.Managers.Catalog.Gitlab
{
    public interface IGitlabManager : IManager
    {
        Task<IResult<GetAllProjectsResponse>> GetProductsAsync();
    }
}
