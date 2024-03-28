using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Data.Seed
{
	internal class GenreConfig : IEntityTypeConfiguration<Genre>
	{
		public void Configure(EntityTypeBuilder<Genre> builder)
		{
			var data = new SeedData();
			builder.HasData(new Genre[]
		{
			data.Fiction,
			data.Mystery,
			data.Narrative,
			data.Novel,
			data.ScienceFiction,
			data.NonFiction,
			data.HistoricalFiction,
			data.RomanceNovel,
			data.Memoir,
			data.ChildrenLiterature,
			data.Thriller,
			data.GraphicNovel,
			data.Horror,
			data.FantasyFiction,
			data.History,
			data.LiteraryFiction,
			data.ShortStory,
			data.HistoricalFantasy,
			data.Fantasy,
			data.Poetry,
			data.Biography,
			data.Essay,
			data.Autobiography,
			data.Humour,
			data.Science,
			data.Drama,
			data.Philosophy
		});
		}
	}
}
