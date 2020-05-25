using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace JotexRepository.Repos.TagRepositories
{
	public interface ITagRepository
	{
		IEnumerable<Tag> GetTags();
	}
}
