﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ON.Authentication;
using ON.Content.SimpleStats.Service.Data;
using ON.Content.SimpleStats.Service.Helper;
using ON.Content.SimpleStats.Service.Models;
using ON.Content.SimpleStats.Service.Services;
using ON.Content.SimpleStats.Service.Subscriptions;

namespace ON.Content.SimpleStats.Service
{
    public class Startup
    {
        private static byte[] PONG_RESPONSE = { (byte)'p', (byte)'o', (byte)'n', (byte)'g' };

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc(options =>
            {
                // options.EnableDetailedErrors = true;
                options.MaxReceiveMessageSize = null;
                options.MaxSendMessageSize = null;
            });

            services.AddGrpcHttpApi();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("stats", new OpenApiInfo { Title = "SimpleStats API" });
            });
            services.AddGrpcSwagger();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddSingleton<ILikeDataProvider, EventDdLikeDataProvider>();
            services.AddSingleton<IProgressDataProvider, EventDdProgressDataProvider>();
            services.AddSingleton<ISaveDataProvider, EventDdSaveDataProvider>();
            services.AddSingleton<IShareDataProvider, EventDdShareDataProvider>();
            services.AddSingleton<IViewDataProvider, EventDdViewDataProvider>();

            services.AddSingleton<IStatsContentPublicDataProvider, FileSystemStatsContentPublicDataProvider>();
            services.AddSingleton<IStatsContentPrivateDataProvider, FileSystemStatsContentPrivateDataProvider>();
            services.AddSingleton<IStatsUserPublicDataProvider, FileSystemStatsUserPublicDataProvider>();
            services.AddSingleton<IStatsUserPrivateDataProvider, FileSystemStatsUserPrivateDataProvider>();

            services.AddSingleton<EventDBHelper>();
            services.AddSingleton<ContentSubscription>();
            services.AddSingleton<UserSubscription>();

            services.AddJwtAuthentication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.LaunchSubscriptionServices();

            app.Map("/ping", (app1) => app1.Run(async context => {
                await context.Response.BodyWriter.WriteAsync(PONG_RESPONSE);
            }));

            app.UseSwagger(c =>
            {
                c.RouteTemplate = "api/{documentName}/swagger.json";
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/api/stats/swagger.json", "SimpleStats API");
                c.RoutePrefix = "api/stats";
            });

            app.UseRouting();

            app.UseJwtApiAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<LikeService>();
                endpoints.MapGrpcService<ProgressService>();
                endpoints.MapGrpcService<SaveService>();
                endpoints.MapGrpcService<ShareService>();
                endpoints.MapGrpcService<ViewService>();

                endpoints.MapGrpcService<QueryService>();

                endpoints.MapGrpcService<ServiceOpsService>();
            });
        }
    }
}
