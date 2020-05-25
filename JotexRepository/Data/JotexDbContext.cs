using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using JotexRepository.Models;

namespace JotexRepository.Data
{
    public class JotexDbContext:DbContext
	{
		public JotexDbContext(DbContextOptions<JotexDbContext> options):base(options) { }


		//public DbSet<BaseEntity> BaseEntities { get; set; }
		    public DbSet<Service>Services  { get; set; }
			public DbSet<ServiceDetail>ServiceDetails  { get; set; }
			public DbSet<ServiceFeature>ServiceFeatures  { get; set; }
			public DbSet<Tag>Tags  { get; set; }
		public DbSet<Blog> Blogs { get; set; }



		public DbSet<Subscription>Subscriptions  { get; set; }
			public DbSet<CaseStudies>CaseStudies  { get; set; }
			public DbSet<CaseTabs>CaseTabs  { get; set; }
		    public DbSet<MultiCase>MultiCases  { get; set; }
	        public DbSet<Testimonial>Testimonials  { get; set; }








}
}
