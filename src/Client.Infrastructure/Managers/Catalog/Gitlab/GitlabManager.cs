using ProjectServices.Application.Features.Gitlab.Queries.GetAll;
using ProjectServices.Client.Infrastructure.Extensions;
using ProjectServices.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Client.Infrastructure.Managers.Catalog.Gitlab
{
    public class GitlabManager : IGitlabManager
    {
        private readonly HttpClient _httpClient;

        public GitlabManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<GetAllProjectsResponse>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync(Routes.GitlabEndpoints.GetAll);
            return await response.ToResult<GetAllProjectsResponse>();
        }
    }
}
