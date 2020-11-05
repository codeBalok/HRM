using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyHRM.Core.Interfaces;
using EasyHRM.Core.Interfaces.PaySlip;
using EasyHRM.Data.HRMdbContext;
using EasyHRM.Data.Repository;
using EasyHRM.Data.Repository.Base;
using EasyHRM.Data.Repository.PaySlip;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotativa.AspNetCore;

namespace EasyHRM.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                      .AddCookie(options =>
                      {
                          options.LoginPath = "/Home/login/";
                          options.AccessDeniedPath = "/Home/Index";
                      });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

           
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));           
           

            services.AddTransient<IDashboardRepository, DashboardRepository>();
            services.AddTransient<IEmployeeDashboard, EmployeeDashboard>();

            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IDesignationRepository, DesignationRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IHolidayRepository, HolidayRepository>();
            services.AddTransient<IAwardRepository, AwardRepository>();
            services.AddTransient<INoticeRepository, NoticeRepository>();
            services.AddTransient<IAttendenceRepository, AttendenceRepository>();
            services.AddTransient<ILeaveGroupRepository, LeaveGroupRepository>();
            services.AddTransient<ILeaveEmployeeRepository, LeaveEmployeeRepository>();
            services.AddTransient<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddTransient<ILeaveApplicationRepository, LeaveApplicationRepository>();

            services.AddTransient<IAllowanceTypeRepository, AllowanceTypeRepository>();
            services.AddTransient<IAllowanceRepository, AllowanceRepository>();
            services.AddTransient<IAllowanceEmployee, AllowanceEmployeeRepository>();

            services.AddTransient<IPaySlipRepository, PaySlipRepository>();
            services.AddTransient<IEmployeePaySlipRepository, EmployeePaySlipRepository>();
            services.AddTransient<IPaySlipAllowanceRepository, PaySlipAllowanceRepository>();

            services.AddTransient<IUserRepository, UserRepository>();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .AllowCredentials()
                       .WithOrigins("http://localhost:4200", "http://54.79.150.98", "https://54.79.150.98", "http://www.edulication.com");
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //(app.UseExceptionHandler("/Home/Error");
                app.UseDeveloperExceptionPage();
            }
           
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseCors("MyPolicy");

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "api",
                    template: "api/{controller}/{action=Index}/{id?}");
            });

            RotativaConfiguration.Setup(env);
        }
    }
}
