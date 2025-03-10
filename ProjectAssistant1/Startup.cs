﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectAssistant1.Areas.Identity;
using ProjectAssistant1.Data;
using ProjectAssistant1.Models;
using ProjectAssistant1.Models.Models;
using ProjectAssistant1.Models.Models.ListModel;
using ProjectAssistant1.Models.Models.UserWorkModel;
using ProjectAssistant1.Models.Models.WorkspaceUserModel;
using ProjectAssistant1.Models.Models.WorkspaceWorkModel;
using ProjectAssistant1.Models.UserModel;
using ProjectAssistant1.Models.UserWorkspacesModel;
using ProjectAssistant1.Models.WorkspaceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ProjectAssistant1.Hubs;
using Microsoft.AspNetCore.ResponseCompression;
using ProjectAssistant1.Models.Models.ChatRoomModel;
using ProjectAssistant1.Models.Models.ChatModel;
using System.Text.Json.Serialization;
using ProjectAssistant1.Models.Models.VotModel;
using ProjectAssistant1.Models.Models.VotesModel;
using ProjectAssistant1.Models.Models.PersonalScheduleModel;
using MudBlazor.Services;

namespace ProjectAssistant1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();

            services.AddControllersWithViews().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });

            // Blazor Bootstrap 추가
            services.AddBlazorBootstrap();

            // MudBlazor 추가
            services.AddMudServices();

            // new DbContext
            services.AddEntityFrameworkSqlServer()
            .AddDbContext<ProjectAssistantDbContext>(options =>
                options.UseLazyLoadingProxies() // Lazy Loading Proxies 활성화
                       .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // DI Container
            services.AddTransient<IWorkspaceRepositoryAsync, WorkspaceRepository>();
            services.AddTransient<IUserWorkspaceRepositoryAsync, UserWorkspaceRepository>();
            services.AddTransient<IUserRepositoryAsync, UserRepository>();
            services.AddTransient<IWorkspaceUserRepository, WorkspaceUserRepository>();
            services.AddTransient<IWorkRepository, WorkRepository>();
            services.AddTransient<IListWorkspaceRepository, ListWorkspaceRepository>();
            services.AddTransient<IUserWorkRepository, UserWorkRepository>();
            services.AddTransient<IWorkListRepository,  WorkListRepository>();
            services.AddTransient<IWorkspaceWorkRepository, WorkspaceWorkRepository>();
            services.AddTransient<IChatRoomRepository, ChatRoomRepository>();
            services.AddTransient<IChatRepository, ChatRepository>();
            services.AddTransient<IVotRepository, VotRepository>();
            services.AddTransient<IVotesRepository, VotesRepository>();
            services.AddTransient<IPersonalScheduleRepository, PersonalScheduleRepository>();

            // SignalR and Response Compression
            services.AddSignalR();
            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            // SignalR
            app.UseResponseCompression();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/ChatHub");
            });


        }
    }
}
