using Fluxor;
using Microsoft.AspNetCore.Components;
using OneStream.Client.SharedUI;
using OneStream.Shared.Common;
using OneStream.Shared.Wcf;
using OneStreamWebUI.Mvvm.Toolkit;
using OneStreamWebUI.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneStreamWebUI.Client.Dashboards
{
    public class ComponentRefModel : ViewModelBase
    {
        private readonly IState<SessionInfoState> sessionInfoState;
        private readonly IState<UserPreferencesState> userPreferencesState;
        private readonly XFWebSpinnerService spinnerService;
        private readonly XFWebToastService toastService;
        private readonly NavigationManager navigationManager;

        [Parameter] public DashboardDisplayInfoEx DashboardDisplayInfoEx { get; set; }
        [Parameter] public XFWebDashboardsView WebDashboardsView { get; set; }
        [Parameter] public Dictionary<string, string> CustomSubstVars { get; set; }

        public XFWebSpinnerService SpinnerService => spinnerService;
        public SessionInfo? SI { get { return this.sessionInfoState?.Value?.SessionInfo; } }

        public ComponentRefModel(IState<SessionInfoState> SessionInfoState, IState<UserPreferencesState> UserPreferencesState, XFWebSpinnerService SpinnerService, XFWebToastService ToastService, NavigationManager NavigationManager, )
        {
            this.sessionInfoState = SessionInfoState;
            this.spinnerService = SpinnerService;
            this.toastService = ToastService;
            this.navigationManager = NavigationManager;
            this.userPreferencesState = UserPreferencesState;
            this.navigationManager = NavigationManager;
        }

        public override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
        }

        public override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        public override void OnInitialized()
        {
            base.OnInitialized();
        }

        public override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }
    }
}