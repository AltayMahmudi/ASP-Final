using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using JotexRepository.InsuranceRepositories;
using JotexRepository.Data;
using Microsoft.EntityFrameworkCore;
using JotexRepository.TestimonialRepositories;
using JotexRepository.Repos.SubscriptionRepositories;
using JotexRepository.Repos.TagRepositories;
using JotexRepository.Repos.CaseStudiesRepositories;
using JotexRepository.Repos.Blogs;

namespace Jotex
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
			services.AddControllersWithViews();

			services.AddAutoMapper(typeof(Startup));

			services.AddDbContext<JotexDbContext>(options =>
				   options.UseSqlServer(Configuration.GetConnectionString("Default"),
				   x => x.MigrationsAssembly("JotexRepository")));

			services.AddTransient<ITestimonialRepository, TestimonialRepository>();
			services.AddTransient<IServiceRepository, ServiceRepository>();
			services.AddTransient<ISubscriptionRepository, SubscriptionRepository>();
			services.AddTransient<ITagRepository, TagRepository>();
			services.AddTransient<ICaseStudiesRepository, CaseStudiesRepository>();
			services.AddTransient<IBlogRepository, BlogRepository>();




		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
