﻿/*
* Copyright (c) Akveo 2019. All Rights Reserved.
* Licensed under the Single Application / Multi Application License.
* See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the ‘docs’ folder for license information on type of purchased license.
*/

using Common.WebApiCore.Identity;
using Common.DIContainerCore;
using Common.Entities;
using Common.Services.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Common.WebApiCore.Setup
{
    public class DependenciesConfig
    {
        public static void ConfigureDependencies(IServiceCollection services, string connectionString)
        {
            services.AddHttpContextAccessor();

            services.AddScoped<ICurrentContextProvider, CurrentContextProvider>();

            services.AddSingleton<JwtManager>();

            ContainerExtension.Initialize(services, connectionString);

            services.AddTransient<IAuthenticationService, AuthenticationService<User>>();
        }
    }
}
