using BookStore.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Data.Seed
{
	internal class BookConfig : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			var data = new SeedData();

			builder.HasData(new Book[]
			{
			data.TheGreatGatsby,
			data.NineteenEightyFour,
			data.PrideAndPrejudice,
			data.JaneEyre,
			data.TheNameOfTheWind,
			data.WiseMansFear,
			data.TheDiaryOfaYoungGirl,
			data.KillersOfTheFlowerMoon,
			data.AtomicHabits,
			data.Dune,
			data.TheHitchhikersGuideToTheGalaxy,
			data.Frankenstein,
			data.Solaris,
			data.TheDaVinciCode,
			data.TheSilenceOfTheLambs,
			data.TheShining,
			data.It,
			data.TheCallOfCthulhu,
			data.Necronomicon,
			data.Azathoth,
			data.TotalRecall,
			data.Becoming,
			data.GoodOmens,
			data.Meditations,
			data.TaoTeChing,
			data.NicomacheanEthics,
			data.EpistulaeMoralesadLucilium,
			data.MeditationsOnFirstPhilosophy,
			data.ThusSpokeZarathustra,
			data.CritiqueOfPureReason,
			data.TheArtOfWar,
			data.Hamlet,
			data.LittleWomen,
			data.TheTempest,
			data.TheGodfather,
			data.Poems,
			data.Poyums,
			data.Iliad,
			data.Odyssey,
			data.TheRiseAndTheFallOfTheThirdReich,
			data.WinnieThePooh,
			data.TheHobbit,
			data.TheLittlePrince,
			data.ABriefHistoryOfTime,
			data.Cosmos,
			data.AstrophysicsForPeopleInAHurry,
			data.TheAmazingSpiderMan,
			data.VForVendetta,
			data.BatmanTheKillingJoke,
			data.TheHoundOfTheBaskervilles,
			data.TheMurderOfRogerAckroyd,
			data.FiftyShadesOfGrey
			});
		}
	}
}
