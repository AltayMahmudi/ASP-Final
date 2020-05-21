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

		    public DbSet<Service>services  { get; set; }
	        public DbSet<Category>categories  { get; set; }
            public DbSet<BaseEntity>baseEntities  { get; set; }
			public DbSet<ServiceDetail>serviceDetails  { get; set; }
			public DbSet<ServiceFeature>ServiceFeatures  { get; set; }
			public DbSet<TAG>TAGs  { get; set; }
			public DbSet<Subscription>subscriptions  { get; set; }
			public DbSet<CaseStudies>caseStudies  { get; set; }
			public DbSet<CaseTabs>caseTabs  { get; set; }
		    public DbSet<MultiCase>multiCases  { get; set; }
	        public DbSet<Testimonial>testimonials  { get; set; }








}
}
