using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using ProjectServices.Client.Extensions;
using ProjectServices.Client.Infrastructure.Managers.Catalog.Gitlab;
using ProjectServices.Shared.Constants.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectServices.Client.Pages.Catalog
{
    public partial class Gitlab
    {
        [Inject] private IGitlabManager GitlabManager { get; set; }
        [CascadingParameter] private HubConnection HubConnection { get; set; }

        private ClaimsPrincipal _currentUser;
        private bool _canCreateProducts;
        private bool _canEditProducts;
        private bool _canDeleteProducts;
        private bool _canExportProducts;
        private bool _canSearchProducts;
        private bool _loaded;

        protected override async Task OnInitializedAsync()
        {
            _currentUser = await _authenticationManager.CurrentUser();
            _canCreateProducts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Gitlab.Create)).Succeeded;
            _canEditProducts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Gitlab.Edit)).Succeeded;
            _canDeleteProducts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Gitlab.Delete)).Succeeded;
            _canExportProducts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Gitlab.Export)).Succeeded;
            _canSearchProducts = (await _authorizationService.AuthorizeAsync(_currentUser, Permissions.Gitlab.Search)).Succeeded;

            _loaded = true;
            HubConnection = HubConnection.TryInitialize(_navigationManager, _localStorage);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }

        private async Task ServerReload()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var response = await GitlabManager.GetProductsAsync();
            if (response.Succeeded)
            {
                _totalItems = response.TotalCount;
                _currentPage = response.CurrentPage;
                _pagedData = response.Data;
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }
    }
}
