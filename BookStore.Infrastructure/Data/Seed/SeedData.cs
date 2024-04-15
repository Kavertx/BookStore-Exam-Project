using BookStore.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Data.Seed
{
	internal class SeedData
	{
		public IdentityUser Admin {  get; set; }
		public Client Test {  get; set; }
        public Genre Fiction { get; set; }
		public Genre Mystery { get; set; }
		public Genre Narrative { get; set; }
		public Genre Novel { get; set; }
		public Genre ScienceFiction { get; set; }
		public Genre NonFiction { get; set; }
		public Genre HistoricalFiction { get; set; }
		public Genre RomanceNovel { get; set; }
		public Genre Memoir { get; set; }
		public Genre ChildrenLiterature { get; set; }
		public Genre Thriller { get; set; }
		public Genre GraphicNovel { get; set; }
		public Genre Horror { get; set; }
		public Genre FantasyFiction { get; set; }
		public Genre History { get; set; }
		public Genre LiteraryFiction { get; set; }
		public Genre ShortStory { get; set; }
		public Genre HistoricalFantasy { get; set; }
		public Genre Fantasy { get; set; }
		public Genre Poetry { get; set; }
		public Genre Biography { get; set; }
		public Genre Essay { get; set; }
		public Genre Autobiography { get; set; }
		public Genre Humour { get; set; }
		public Genre Science { get; set; }
		public Genre Drama { get; set; }
		public Genre Philosophy { get; set; }

		public Book TheGreatGatsby { get; set; }
		public Book NineteenEightyFour { get; set; }
		public Book PrideAndPrejudice { get; set; }
		public Book JaneEyre { get; set; }
		public Book TheNameOfTheWind { get; set; }
		public Book WiseMansFear { get; set; }
		public Book TheDiaryOfaYoungGirl { get; set; }
		public Book KillersOfTheFlowerMoon { get; set; }
		public Book AtomicHabits { get; set; }
		public Book Dune { get; set; }
		public Book TheHitchhikersGuideToTheGalaxy { get; set; }
		public Book Frankenstein { get; set; }
		public Book Solaris { get; set; }
		public Book TheDaVinciCode { get; set; }
		public Book TheSilenceOfTheLambs { get; set; }
		public Book TheShining { get; set; }
		public Book It { get; set; }
		public Book TheCallOfCthulhu { get; set; }
		public Book Necronomicon { get; set; }
		public Book Azathoth { get; set; }
		public Book TotalRecall { get; set; }
		public Book Becoming { get; set; }
		public Book GoodOmens { get; set; }
		public Book Meditations { get; set; }
		public Book TaoTeChing { get; set; }
		public Book NicomacheanEthics { get; set; }
		public Book EpistulaeMoralesadLucilium { get; set; }
		public Book MeditationsOnFirstPhilosophy { get; set; }
		public Book ThusSpokeZarathustra { get; set; }
		public Book CritiqueOfPureReason { get; set; }
		public Book TheArtOfWar { get; set; }
		public Book Hamlet { get; set; }
		public Book LittleWomen { get; set; }
		public Book TheTempest { get; set; }
		public Book TheGodfather { get; set; }
		public Book Poems { get; set; }
		public Book Poyums { get; set; }
		public Book Iliad { get; set; }
		public Book Odyssey { get; set; }
		public Book TheRiseAndTheFallOfTheThirdReich { get; set; }
		public Book WinnieThePooh { get; set; }
		public Book TheHobbit { get; set; }
		public Book TheLittlePrince { get; set; }
		public Book ABriefHistoryOfTime { get; set; }
		public Book Cosmos { get; set; }
		public Book AstrophysicsForPeopleInAHurry { get; set; }
		public Book TheAmazingSpiderMan { get; set; }
		public Book VForVendetta { get; set; }
		public Book BatmanTheKillingJoke { get; set; }
		public Book TheHoundOfTheBaskervilles { get; set; }
		public Book TheMurderOfRogerAckroyd { get; set; }
		public Book FiftyShadesOfGrey { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public SeedData() 
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			SeedGenres();
			SeedBooks();
			SeedUsers();
		}

		private void SeedGenres()
		{
			Fiction = new Genre()
			{
				Id = 1,
				Name = "Fiction"
			};

			Mystery = new Genre()
			{
				Id = 2,
				Name = "Mystery"
			};

			Narrative = new Genre()
			{
				Id = 3,
				Name = "Narrative"
			};

			Novel = new Genre()
			{
				Id = 4,
				Name = "Novel"
			};

			ScienceFiction = new Genre()
			{
				Id = 5,
				Name = "Science Fiction"
			};

			NonFiction = new Genre()
			{
				Id = 6,
				Name = "Non-Fiction"
			};

			HistoricalFiction = new Genre()
			{
				Id = 7,
				Name = "Historical Fiction"
			};

			RomanceNovel = new Genre()
			{
				Id = 8,
				Name = "Romance Novel"
			};

			Memoir = new Genre()
			{
				Id = 9,
				Name = "Memoir"
			};

			ChildrenLiterature = new Genre()
			{
				Id = 10,
				Name = "Children's Literature"
			};

			Thriller = new Genre()
			{
				Id = 11,
				Name = "Thriller"
			};

			GraphicNovel = new Genre()
			{
				Id = 12,
				Name = "Graphic Novel"
			};

			Horror = new Genre()
			{
				Id = 13,
				Name = "Horror"
			};

			FantasyFiction = new Genre()
			{
				Id = 14,
				Name = "Fantasy Fiction"
			};

			History = new Genre()
			{
				Id = 15,
				Name = "History"
			};

			LiteraryFiction = new Genre()
			{
				Id = 16,
				Name = "Literary Fiction"
			};

			ShortStory = new Genre()
			{
				Id = 17,
				Name = "Short Story"
			};

			HistoricalFantasy = new Genre()
			{
				Id = 18,
				Name = "Historical Fantasy"
			};

			Fantasy = new Genre()
			{
				Id = 19,
				Name = "Fantasy"
			};

			Poetry = new Genre()
			{
				Id = 20,
				Name = "Poetry"
			};

			Biography = new Genre()
			{
				Id = 21,
				Name = "Biography"
			};

			Essay = new Genre()
			{
				Id = 22,
				Name = "Essay"
			};

			Autobiography = new Genre()
			{
				Id = 23,
				Name = "Autobiography"
			};

			Humour = new Genre()
			{
				Id = 24,
				Name = "Humour"
			};

			Science = new Genre()
			{
				Id = 25,
				Name = "Science"
			};

			Drama = new Genre()
			{
				Id = 26,
				Name = "Drama"
			};

			Philosophy = new Genre()
			{
				Id = 27,
				Name = "Philosophy"
			};



		}
		private void SeedClients()
		{
			Test = new Client()
			{
				Id = 1,
				MyBooks = new List<Book>() { },
				Orders = new List<Order>() { },
				UserId = "e43ce836-997d-4927-ac59-74e8c41bbfd3",
				UserName = "AdministratorA",
			};
		}

		private void SeedUsers()
		{
            var hasher = new PasswordHasher<IdentityUser>();

            Admin = new IdentityUser()
            {
                Id = "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM"
            };

            Admin.PasswordHash =hasher.HashPassword(Admin, "admin123");
        }

		private void SeedBooks()
		{
			TheGreatGatsby = new Book()
			{
				Id = 1,
				Title = "The Great Gatsby",
				Description = @"A novel by F. Scott Fitzgerald, set in the Jazz Age on Long Island 
    and New York City. The story depicts the mysterious millionaire Jay Gatsby and 
    his passionate pursuit of the elusive Daisy Buchanan. Through themes of love, 
    wealth, and the American Dream, Fitzgerald explores the emptiness and moral decay 
    lurking beneath the surface of the Roaring Twenties.",
				Price = 12.99m,
				AuthorName = "F. Scott Fitzgerald",
				GenreId = LiteraryFiction.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg/220px-The_Great_Gatsby_Cover_1925_Retouched.jpg"
			};

			NineteenEightyFour = new Book()
			{
				Id = 2,
				Title = "Nineteen Eighty-Four",
				Description =@"A dystopian novel by George Orwell, set in a totalitarian regime 
    where individuality and freedom are suppressed by omnipresent government surveillance. 
    The story follows Winston Smith as he rebels against the oppressive Party led by Big Brother, 
    questioning reality and seeking personal freedom in a world dominated by propaganda and thought control.",
				Price = 10.49m,
				AuthorName = "George Orwell",
				GenreId = ScienceFiction.Id, 
				InStock = true,
				Rating = 4, 
				ImageUrl = "https://m.media-amazon.com/images/I/61ZewDE3beL._AC_UF894,1000_QL80_.jpg"
			};

			PrideAndPrejudice = new Book()
			{
				Id = 3,
				Title = "Pride and Prejudice",
				Description = @"A novel by Jane Austen, one of the most beloved works of English literature. 
    The story follows the romantic entanglements of the Bennet sisters, particularly the headstrong 
    Elizabeth Bennet and the aloof Mr. Darcy. Through wit, satire, and social commentary, Austen 
    explores themes of love, class, and the constraints of societal expectations in early 19th-century England.",
				Price = 9.99m,
				AuthorName = "Jane Austen",
				GenreId = RomanceNovel.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781524861759/pride-and-prejudice-9781524861759_hr.jpg"
			};
			JaneEyre = new Book()
			{
				Id = 4,
				Title = "Jane Eyre",
				Description = @"A novel by Charlotte Brontë, a classic of English literature. 
    The story follows the titular character, an orphaned governess, as she navigates 
    the challenges of love, morality, and independence in 19th-century England. Brontë's 
    exploration of social class, gender roles, and the pursuit of self-respect continues 
    to captivate readers with its timeless themes.",
				Price = 8.99m,
				AuthorName = "Charlotte Brontë",
				GenreId = LiteraryFiction.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1692725440i/197321006.jpg"
			};

			TheNameOfTheWind = new Book()
			{
				Id = 5,
				Title = "The Name of the Wind",
				Description = @"A fantasy novel by Patrick Rothfuss, the first book in the 
    Kingkiller Chronicle series. The story is framed as a retrospective narrative 
    of the legendary hero Kvothe, recounting his early life and adventures. Rothfuss 
    weaves a rich tapestry of magic, music, and intrigue, drawing readers into a 
    world of wonder and danger.",
				Price = 13.99m,
				AuthorName = "Patrick Rothfuss",
				GenreId = FantasyFiction.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://www.gollancz.co.uk/wp-content/uploads/2018/07/hbg-title-9781473224087-159.jpg"
			};

			WiseMansFear = new Book()
			{
				Id = 6,
				Title = "The Wise Man's Fear",
				Description = @"The second book in the Kingkiller Chronicle series by Patrick Rothfuss. 
    Continuing Kvothe's journey, the story delves deeper into his adventures across the 
    magical and treacherous world of Temerant. Rothfuss masterfully blends elements of 
    epic fantasy, adventure, and mystery to create a captivating narrative that keeps 
    readers eagerly turning pages.",
				Price = 14.49m,
				AuthorName = "Patrick Rothfuss",
				GenreId = FantasyFiction.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/81Ctt30rgxS._AC_UF1000,1000_QL80_.jpg"
			};

			TheDiaryOfaYoungGirl = new Book()
			{
				Id = 7,
				Title = "The Diary of a Young Girl",
				Description = @"The diary of Anne Frank, a Jewish teenager who hid from 
    the Nazis during World War II. Anne's poignant and insightful entries 
    provide a firsthand account of the hardships, fears, and hopes of those 
    living in hiding. Her story serves as a powerful reminder of the human 
    spirit's resilience and the enduring importance of bearing witness to history.",
				Price = 9.99m,
				AuthorName = "Anne Frank",
				GenreId = Memoir.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/51Eyjz65gyL._AC_UF1000,1000_QL80_.jpg"
			};

			KillersOfTheFlowerMoon = new Book()
			{
				Id = 8,
				Title = "Killers of the Flower Moon",
				Description = @"A non-fiction book by David Grann, investigating the murders of 
    Osage Indians in Oklahoma during the 1920s. Grann explores the conspiracy and 
    corruption surrounding the killings, revealing a chilling tale of greed, racism, 
    and injustice. His meticulous research and gripping storytelling shed light on 
    a dark chapter of American history.",
				Price = 13.99m,
				AuthorName = "David Grann",
				GenreId = NonFiction.Id,
				InStock = true,
				Rating = 4,
				ImageUrl = "https://images.macrumors.com/t/HY9LeIGBDDKDrTF3if3D6Pnrxic=/1200x1200/smart/article-new/2020/05/killersoftheflowermoon.jpg"
			};

			AtomicHabits = new Book()
			{
				Id = 9,
				Title = "Atomic Habits",
				Description = @"A self-help book by James Clear, offering practical strategies 
    for building good habits and breaking bad ones. Clear draws on scientific research 
    and real-life examples to provide actionable advice on how to make small changes 
    that yield remarkable results. Atomic Habits empowers readers to take control of 
    their behavior and create lasting positive change.",
				Price = 14.49m,
				AuthorName = "James Clear",
				GenreId = NonFiction.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/81YkqyaFVEL._AC_UF1000,1000_QL80_.jpg"
			};

			Dune = new Book()
			{
				Id = 10,
				Title = "Dune",
				Description = @"A science fiction novel by Frank Herbert, set in a distant 
    future where noble houses vie for control of the desert planet Arrakis. 
    The story follows Paul Atreides as he becomes embroiled in political intrigue, 
    religious prophecy, and the struggle for survival in a harsh and unforgiving landscape.",
				Price = 11.99m,
				AuthorName = "Frank Herbert",
				GenreId = ScienceFiction.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1555447414i/44767458.jpg"
			};

			TheHitchhikersGuideToTheGalaxy = new Book()
			{
				Id = 11,
				Title = "The Hitchhiker's Guide to the Galaxy",
				Description = @"A comedic science fiction series by Douglas Adams, following 
    the misadventures of Arthur Dent after Earth's destruction to make way for 
    a hyperspace bypass. With the help of his alien friend Ford Prefect, Arthur 
    embarks on a journey through space filled with absurdity, satire, and philosophical musings.",
				Price = 9.99m,
				AuthorName = "Douglas Adams",
				GenreId = ScienceFiction.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://cdn.waterstones.com/bookjackets/large/9781/5290/9781529034523.jpg"
			};

			Frankenstein = new Book()
			{
				Id = 12,
				Title = "Frankenstein",
				Description = @"A gothic science fiction novel by Mary Shelley, exploring 
    themes of creation, ambition, and the consequences of playing god. The story 
    follows Victor Frankenstein and his creation, often referred to as Frankenstein's 
    monster, as they grapple with their own identities and the moral implications of 
    their actions.",
				Price = 8.99m,
				AuthorName = "Mary Shelley",
				GenreId = ScienceFiction.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/81z7E0uWdtL._AC_UF1000,1000_QL80_.jpg"
			};

			Solaris = new Book()
			{
				Id = 13,
				Title = "Solaris",
				Description = @"A philosophical science fiction novel by Stanisław Lem, 
    exploring the nature of consciousness, communication, and the unknown. 
    Set on the mysterious planet Solaris, the story follows psychologist Kris 
    Kelvin as he grapples with strange phenomena and confronts his own inner demons.",
				Price = 10.49m,
				AuthorName = "Stanisław Lem",
				GenreId = ScienceFiction.Id,
				InStock = true,
				Rating = 4,
				ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1498631519l/95558.jpg"
			};

			TheDaVinciCode = new Book()
			{
				Id = 14,
				Title = "The Da Vinci Code",
				Description = @"A mystery thriller novel by Dan Brown, following symbologist 
    Robert Langdon as he investigates a murder in the Louvre Museum. Langdon 
    uncovers a series of cryptic clues leading to a centuries-old secret that 
    could shake the foundations of Christianity.",
				Price = 11.99m,
				AuthorName = "Dan Brown",
				GenreId = Mystery.Id,
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/815WORuYMML._AC_UF1000,1000_QL80_.jpg"
			};

			TheSilenceOfTheLambs = new Book()
			{
				Id = 15,
				Title = "The Silence of the Lambs",
				Description = @"A psychological horror novel by Thomas Harris, introducing 
    FBI trainee Clarice Starling and incarcerated cannibalistic serial killer Dr. 
    Hannibal Lecter. Starling seeks Lecter's insights into the mind of another 
    serial killer, Buffalo Bill, leading to a gripping cat-and-mouse game between 
    law enforcement and the criminally insane.",
				Price = 10.99m,
				AuthorName = "Thomas Harris",
				GenreId = Thriller.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1647930822i/23807.jpg"
			};

			TheShining = new Book()
			{
				Id = 16,
				Title = "The Shining",
				Description = @"A horror novel by Stephen King, set in the remote Overlook 
    Hotel during the winter season. As the hotel's isolation takes its toll on 
    the Torrance family, the young Danny Torrance discovers supernatural abilities 
    and the sinister history of the hotel. King's tale of terror explores themes 
    of addiction, madness, and the darkness lurking within.",
				Price = 9.49m,
				AuthorName = "Stephen King",
				GenreId = Horror.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1353277730i/11588.jpg"
			};

			It = new Book()
			{
				Id = 17,
				Title = "It",
				Description = @"A horror novel by Stephen King, spanning multiple timelines 
    as a group of friends confronts an ancient evil lurking beneath the town 
    of Derry, Maine. King weaves together themes of friendship, trauma, and the 
    power of memory in a chilling narrative that explores the resilience of the 
    human spirit in the face of unimaginable horror.",
				Price = 12.99m,
				AuthorName = "Stephen King",
				GenreId = Horror.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://i.ebayimg.com/images/g/rgkAAOSw969f~26A/s-l600.jpg"
			};

			TheCallOfCthulhu = new Book()
			{
				Id = 18,
				Title = "The Call of Cthulhu",
				Description = @"A horror short story by H.P. Lovecraft, introducing the 
    cosmic entity Cthulhu and the Cthulhu Mythos. The story follows a series of 
    interconnected narratives uncovering the existence of ancient beings beyond 
    human comprehension, and the cults that worship them.",
				Price = 7.99m,
				AuthorName = "H.P. Lovecraft",
				GenreId = Horror.Id,
				InStock = true,
				Rating = 4,
				ImageUrl = "https://cdn.kobo.com/book-images/828f93f3-99af-4795-afc8-f3a517a21f7b/1200/1200/False/the-call-of-cthulhu-46.jpg"
			};

			Necronomicon = new Book()
			{
				Id = 19,
				Title = "Necronomicon",
				Description = @"A fictional grimoire by H.P. Lovecraft, often cited in 
    Lovecraft's mythos as a tome of forbidden knowledge and occult rituals. 
    While the Necronomicon is a creation of Lovecraft's imagination, it has 
    since become a cultural icon associated with cosmic horror and eldritch lore.",
				Price = 15.99m,
				AuthorName = "H.P. Lovecraft",
				GenreId = Horror.Id,
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTdhNDQ2NWItYThjOC00ODU2LWIzNTMtY2ZhMTMwOWE5NjM2XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg"
			};

			Azathoth = new Book()
			{
				Id = 20,
				Title = "Azathoth",
				Description = @"A cosmic horror short story by H.P. Lovecraft, depicting 
    the blind and mindless entity Azathoth at the center of the universe, 
    surrounded by the Outer Gods and other eldritch entities. Lovecraft's 
    portrayal of Azathoth as the ultimate chaos and entropy embodies the 
    existential dread inherent in cosmic horror.",
				Price = 8.49m,
				AuthorName = "H.P. Lovecraft",
				GenreId = Horror.Id,
				InStock = true,
				Rating = 4,
				ImageUrl = "https://cdn.kobo.com/book-images/b332f191-3dab-4016-b050-65ec6edaf8d7/1200/1200/False/azathoth-7.jpg"
			};

			TotalRecall = new Book()
			{
				Id = 21,
				Title = "Total Recall",
				Description = @"An autobiography by Arnold Schwarzenegger, detailing his 
    journey from a small town in Austria to becoming a bodybuilding champion, 
    Hollywood actor, and eventually Governor of California. Schwarzenegger's 
    candid account offers insights into his successes, setbacks, and the 
    principles that guided his remarkable career.",
				Price = 13.99m,
				AuthorName = "Arnold Schwarzenegger",
				GenreId = Autobiography.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/71rL8t6PgqL._AC_UF1000,1000_QL80_.jpg"
			};
			Becoming = new Book()
			{
				Id = 22,
				Title = "Becoming",
				Description = @"An autobiographical memoir by Michelle Obama, chronicling 
    her life from childhood to her tenure as First Lady of the United States. 
    With candor and grace, Obama shares her personal journey, reflecting on 
    family, identity, and the power of resilience in the face of adversity.",
				Price = 14.49m,
				AuthorName = "Michelle Obama",
				GenreId = Autobiography.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/81cJTmFpG-L._AC_UF1000,1000_QL80_.jpg"
			};

			GoodOmens = new Book()
			{
				Id = 23,
				Title = "Good Omens",
				Description = @"A fantasy novel by Terry Pratchett and Neil Gaiman, 
    blending humor, satire, and supernatural elements. The story follows an 
    angel and a demon who team up to prevent the apocalypse, leading to 
    hilarious and unexpected consequences. Pratchett and Gaiman's collaboration 
    is a delightful romp through the end of the world.",
				Price = 11.99m,
				AuthorName = "Terry Pratchett and Neil Gaiman",
				GenreId = FantasyFiction.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1615552073l/12067.jpg"
			};

			Meditations = new Book()
			{
				Id = 24,
				Title = "Meditations",
				Description = @"A series of personal writings by the Roman Emperor 
    Marcus Aurelius, offering reflections on Stoic philosophy and principles 
    for living a virtuous life. Written as a series of notes to himself, 
    Meditations provides timeless wisdom on resilience, self-discipline, 
    and the pursuit of inner peace.",
				Price = 9.99m,
				AuthorName = "Marcus Aurelius",
				GenreId = Philosophy.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFNQLrDdV96Lxaj5n51b9ylGOUoTmews-Uo8edDGkkpA&s"
			};

			TaoTeChing = new Book()
			{
				Id = 25,
				Title = "Tao Te Ching",
				Description = @"An ancient Chinese philosophical text attributed to 
    the sage Laozi, offering insights into Taoist philosophy and the 
    nature of existence. The Tao Te Ching explores concepts such as 
    balance, harmony, and the principle of wu wei (effortless action), 
    guiding readers on a journey of self-discovery and spiritual growth.",
				Price = 8.99m,
				AuthorName = "Laozi",
				GenreId = Philosophy.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/61hIkVIW9fL._AC_UF894,1000_QL80_.jpg"
			};

			NicomacheanEthics = new Book()
			{
				Id = 26,
				Title = "Nicomachean Ethics",
				Description = @"A treatise by the ancient Greek philosopher Aristotle, 
    exploring the nature of virtue, happiness, and the good life. Drawing 
    on practical wisdom and moral philosophy, Aristotle offers a systematic 
    examination of ethical principles and their application to human conduct.",
				Price = 10.99m,
				AuthorName = "Aristotle",
				GenreId = Philosophy.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781625582089/the-nicomachean-ethics-9781625582089_hr.jpg"
			};

			EpistulaeMoralesadLucilium = new Book()
			{
				Id = 27,
				Title = "Epistulae Morales ad Lucilium",
				Description = @"A collection of letters by the Roman Stoic philosopher 
    Seneca, addressing topics such as virtue, wisdom, and the art of living 
    a meaningful life. Seneca's epistles offer timeless advice and insights 
    into Stoic principles, providing readers with practical wisdom for navigating 
    the challenges of existence.",
				Price = 9.49m,
				AuthorName = "Seneca the Younger",
				GenreId = 27, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/71CH1raWZ8L._AC_UF1000,1000_QL80_.jpg"
			};

			MeditationsOnFirstPhilosophy = new Book()
			{
				Id = 28,
				Title = "Meditations on First Philosophy",
				Description = @"A philosophical work by René Descartes, laying the 
    groundwork for modern Western philosophy. In Meditations, Descartes 
    employs methodical doubt to arrive at foundational truths, famously 
    asserting ""Cogito, ergo sum"" (""I think, therefore I am""). His 
    exploration of skepticism, knowledge, and the existence of God 
    continues to influence philosophical discourse to this day.",
				Price = 11.99m,
				AuthorName = "René Descartes",
				GenreId = Philosophy.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/61ZsD7TuuvL._AC_UF1000,1000_QL80_.jpg"
			};

			ThusSpokeZarathustra = new Book()
			{
				Id = 29,
				Title = "Thus Spoke Zarathustra",
				Description = @"A philosophical novel by Friedrich Nietzsche, 
    presenting the ideas of the Übermensch (Overman) and the eternal 
    recurrence. Through the character of Zarathustra, Nietzsche explores 
    themes of individualism, morality, and the search for meaning in 
    a world without divine guidance. This seminal work challenges 
    traditional values and calls for the reevaluation of human existence.",
				Price = 10.49m,
				AuthorName = "Friedrich Nietzsche",
				GenreId = Philosophy.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/613ZVoVVeXL._AC_UF350,350_QL50_.jpg"
			};

			CritiqueOfPureReason = new Book()
			{
				Id = 30,
				Title = "Critique of Pure Reason",
				Description = @"A philosophical work by Immanuel Kant, laying the 
    groundwork for his transcendental idealism and epistemology. In 
    Critique of Pure Reason, Kant explores the nature of human knowledge, 
    distinguishing between phenomena (objects as they appear to us) and 
    noumena (things as they are in themselves). His critique of reason 
    revolutionized modern philosophy and continues to influence 
    metaphysical and epistemological debates.",
				Price = 12.99m,
				AuthorName = "Immanuel Kant",
				GenreId = Philosophy.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://rowman.com/L/08/797/9780879755966.jpg"
			};

			TheArtOfWar = new Book()
			{
				Id = 31,
				Title = "The Art of War",
				Description = @"A treatise on military strategy attributed to the 
    ancient Chinese military strategist Sun Tzu. The Art of War offers 
    timeless insights into tactics, leadership, and the nature of conflict. 
    Its teachings on deception, maneuvering, and the importance of knowing 
    oneself and one's enemy have found applications beyond the battlefield 
    in areas such as business, politics, and personal development.",
				Price = 8.99m,
				AuthorName = "Sun Tzu",
				GenreId = Philosophy.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkauDL9kU-dnyrZpeWTY8SYegQ6h_4BYKtFtxTGWEs7Q&s"
			};

			Hamlet = new Book()
			{
				Id = 32,
				Title = "Hamlet",
				Description = @"A tragedy by William Shakespeare, considered one of 
    the greatest works in the English language. The play follows Prince Hamlet 
    of Denmark as he grapples with revenge, madness, and existential angst 
    after his father's murder. Shakespeare's exploration of moral ambiguity, 
    deception, and the human condition continues to captivate audiences 
    and scholars alike.",
				Price = 7.99m,
				AuthorName = "William Shakespeare",
				GenreId = Drama.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/51cjtXsg1eL._AC_UF1000,1000_QL80_.jpg"
			};

			LittleWomen = new Book()
			{
				Id = 33,
				Title = "Little Women",
				Description = @"A novel by Louisa May Alcott, following the lives 
    of the March sisters—Meg, Jo, Beth, and Amy—as they come of age during 
    the Civil War era. Little Women explores themes of family, sisterhood, 
    love, and the pursuit of personal aspirations against societal expectations. 
    Alcott's heartfelt storytelling and memorable characters have made 
    the novel a timeless classic.",
				Price = 9.49m,
				AuthorName = "Louisa May Alcott",
				GenreId = LiteraryFiction.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://cdn.kobo.com/book-images/f7c39f83-b19a-4566-88cb-c13236e6178e/1200/1200/False/little-women-159.jpg"
			};

			TheTempest = new Book()
			{
				Id = 34,
				Title = "The Tempest",
				Description = @"A play by William Shakespeare, often considered 
    his final masterpiece. The Tempest tells the story of Prospero, 
    a sorcerer and the rightful Duke of Milan, who conjures a storm 
    to shipwreck his enemies on a remote island. Themes of power, 
    forgiveness, and the complexity of human nature abound in this 
    magical and thought-provoking work.",
				Price = 7.99m,
				AuthorName = "William Shakespeare",
				GenreId = Drama.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://ik.imagekit.io/panmac/tr:di-placeholder_portrait_aMjPtD9YZ.jpg,tr:w-350,f-jpg,pr-true/edition/9781509889761.jpg"
			};

			TheGodfather = new Book()
			{
				Id = 35,
				Title = "The Godfather",
				Description = @"A crime novel by Mario Puzo, depicting the Corleone 
    family's rise to power in the world of organized crime. The Godfather 
    explores themes of loyalty, betrayal, and the American Dream, offering 
    a gripping portrayal of the Mafia underworld and the complexities 
    of family ties. Puzo's iconic novel has left an indelible mark 
    on popular culture.",
				Price = 10.99m,
				AuthorName = "Mario Puzo",
				GenreId = Novel.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1394988109i/22034.jpg"
			};

			Poems = new Book()
			{
				Id = 36,
				Title = "Poems",
				Description = @"Emily Dickinson's 'Poems' is a collection of profound and evocative verses exploring themes of nature, love, and mortality. 
	With her unique style and insightful imagery,
	Dickinson invites readers to contemplate the mysteries of life and the human experience.",
				Price = 8.49m,
				AuthorName = "Emily Dickinson",
				GenreId = Poetry.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/81rFA+FDcVL._AC_UF1000,1000_QL80_.jpg"
			};

			Poyums = new Book()
			{
				Id = 37,
				Title = "Poyums",
				Description = "A collection of poems by Scottish writer Len Pennie.",
				Price = 7.99m,
				AuthorName = "Len Pennie",
				GenreId = Poetry.Id, 
				InStock = true,
				Rating = 4,
				ImageUrl = "https://m.media-amazon.com/images/I/716tBkcqt8L._AC_UF1000,1000_QL80_.jpg"
			};

			Iliad = new Book()
			{
				Id = 38,
				Title = "Iliad",
				Description = @"An ancient Greek epic poem attributed to Homer, 
    chronicling the events of the Trojan War. The Iliad centers on the 
    wrath of Achilles and its devastating consequences, exploring themes 
    of honor, glory, fate, and the human condition. Regarded as one 
    of the greatest works of Western literature, the Iliad continues 
    to influence storytelling and cultural imagination.",
				Price = 9.99m,
				AuthorName = "Homer",
				GenreId = Poetry.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1681797700l/77265004.jpg"
			};

			Odyssey = new Book()
			{
				Id = 39,
				Title = "Odyssey",
				Description = @"An ancient Greek epic poem attributed to Homer, 
    depicting the journey of the hero Odysseus as he seeks to return 
    home after the fall of Troy. The Odyssey is a timeless tale of 
    adventure, perseverance, and the triumph of the human spirit over 
    adversity. Homer's epic continues to captivate readers with its 
    vivid imagery and profound exploration of the human condition.",
				Price = 10.49m,
				AuthorName = "Homer",
				GenreId = Poetry.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://images.booksense.com/images/607/473/9798679473607.jpg"
			};
			TheRiseAndTheFallOfTheThirdReich = new Book()
			{
				Id = 40,
				Title = "The Rise and the Fall of the Third Reich",
				Description = @"A historical work by William L. Shirer, chronicling 
    the history of Nazi Germany from its inception to its collapse 
    at the end of World War II. Drawing on extensive research and 
    firsthand accounts, Shirer provides a comprehensive analysis 
    of Hitler's regime, its ideology, and the events that led to 
    its downfall. The Rise and Fall of the Third Reich remains 
    a definitive work on one of the darkest chapters in human history.",
				Price = 14.99m,
				AuthorName = "William L. Shirer",
				GenreId = History.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://covers.storytel.com/jpg-640/9780795317002.7b3303b8-d0b9-4a55-82cf-9330a224e0d1?optimize=high&quality=70"
			};

			WinnieThePooh = new Book()
			{
				Id = 41,
				Title = "Winnie the Pooh",
				Description = @"A children's book by A.A. Milne, featuring the 
    adventures of Winnie the Pooh and his friends in the Hundred 
    Acre Wood. Filled with whimsy, humor, and gentle life lessons, 
    Winnie the Pooh has captured the hearts of readers of all ages 
    for generations. Milne's beloved characters continue to enchant 
    and inspire readers around the world.",
				Price = 7.99m,
				AuthorName = "A. A. Milne",
				GenreId = ChildrenLiterature.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/71Joy8rn38L._AC_UF1000,1000_QL80_.jpg"
			};

			TheHobbit = new Book()
			{
				Id = 42,
				Title = "The Hobbit",
				Description = @"A fantasy novel by J.R.R. Tolkien, following 
    the journey of Bilbo Baggins as he embarks on an adventure 
    to reclaim the lost kingdom of Erebor from the dragon Smaug. 
    Along the way, Bilbo encounters trolls, elves, goblins, and 
    the enigmatic creature Gollum, setting the stage for the 
    epic events of The Lord of the Rings. Tolkien's enchanting 
    tale of courage, friendship, and heroism has captivated 
    readers of all ages for decades.",
				Price = 11.49m,
				AuthorName = "J. R. R. Tolkien",
				GenreId = FantasyFiction.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/71jD4jMityL._AC_UF1000,1000_QL80_.jpg"
			};

			TheLittlePrince = new Book()
			{
				Id = 43,
				Title = "The Little Prince",
				Description = @"A novella by Antoine de Saint-Exupéry, 
    telling the story of a young prince who travels from 
    planet to planet, encountering various characters 
    and learning profound lessons about love, friendship, 
    and the meaning of life. The Little Prince is a 
    timeless fable cherished by readers of all ages for 
    its simplicity, wisdom, and poignant insights into 
    the human condition.",
				Price = 8.99m,
				AuthorName = "Antoine de Saint-Exupéry",
				GenreId = ChildrenLiterature.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/71OZY035QKL._AC_UF1000,1000_QL80_.jpg"
			};

			ABriefHistoryOfTime = new Book()
			{
				Id = 44,
				Title = "A Brief History of Time",
				Description = @"A popular science book by Stephen Hawking, 
    offering an accessible overview of modern cosmology and 
    the nature of the universe. Hawking discusses complex 
    topics such as the Big Bang, black holes, and the quest 
    for a unified theory of physics in a clear and engaging 
    manner, making scientific concepts accessible to 
    general readers.",
				Price = 10.99m,
				AuthorName = "Stephen Hawking",
				GenreId = Science.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/400x498/a4e40ebdc3e371adff845072e1c73f37/a/-/40c2f1fdc2ad8ffebaf55f314ce64a5a/a-brief-history-of-time-31.jpg"
			};

			Cosmos = new Book()
			{
				Id = 45,
				Title = "Cosmos",
				Description = @"A science book by Carl Sagan, accompanying 
    the acclaimed television series of the same name. Cosmos 
    explores the universe from the smallest subatomic particles 
    to the largest galaxies, weaving together scientific knowledge, 
    philosophy, and storytelling to convey the wonder and 
    majesty of the cosmos. Sagan's passion for science and 
    exploration shines through in every page, inspiring readers 
    to contemplate their place in the universe.",
				Price = 12.49m,
				AuthorName = "Carl Sagan",
				GenreId = Science.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/91Cnrbd3JwL._AC_UF1000,1000_QL80_.jpg"
			};

			AstrophysicsForPeopleInAHurry = new Book()
			{
				Id = 46,
				Title = "Astrophysics for People in a Hurry",
				Description = @"A popular science book by Neil deGrasse Tyson, 
    offering a concise and accessible overview of astrophysics 
    for readers with limited time. Tyson covers topics such as 
    the origin of the universe, the nature of dark matter and 
    dark energy, and the search for extraterrestrial life in 
    a manner that is both informative and engaging, making 
    complex scientific concepts understandable to the layperson.",
				Price = 9.99m,
				AuthorName = "Neil deGrasse Tyson",
				GenreId = Science.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/81G4WoQ9t8L._AC_UF1000,1000_QL80_.jpg"
			};

			TheAmazingSpiderMan = new Book()
			{
				Id = 47,
				Title = "The Amazing Spider-Man",
				Description = @"A superhero comic book series featuring the iconic 
    character Spider-Man, created by writer Stan Lee and artist Steve Ditko. 
    The series follows the adventures of Peter Parker, a high school student 
    who gains spider-like abilities after being bitten by a radioactive spider. 
    Spider-Man battles villains while navigating the complexities of his dual 
    identity as a superhero and a young man dealing with personal struggles 
    and responsibilities.",
				Price = 9.99m,
				AuthorName = "Stan Lee and Steve Ditko",
				GenreId = GraphicNovel.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://images.penguinrandomhouse.com/cover/9781302931391"
			};

			VForVendetta = new Book()
			{
				Id = 48,
				Title = "V for Vendetta",
				Description = @"A dystopian graphic novel by Alan Moore and David Lloyd, 
    set in a totalitarian Britain ruled by a fascist regime. The story follows 
    V, an anarchist revolutionary wearing a Guy Fawkes mask, as he orchestrates 
    a campaign of subversion and rebellion against the oppressive government. 
    V for Vendetta explores themes of freedom, identity, and the power of 
    resistance in the face of tyranny.",
				Price = 11.49m,
				AuthorName = "Alan Moore and David Lloyd",
				GenreId = GraphicNovel.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c0/V_for_vendettax.jpg"
			};

			BatmanTheKillingJoke = new Book()
			{
				Id = 49,
				Title = "Batman: The Killing Joke",
				Description = @"A graphic novel by Alan Moore and Brian Bolland, 
    presenting an origin story for the Joker and exploring the complex 
    dynamic between the Joker and Batman. The Killing Joke delves into 
    themes of madness, morality, and the blurred line between hero and 
    villain in the dark and gritty world of Gotham City.",
				Price = 10.99m,
				AuthorName = "Alan Moore and Brian Bolland",
				GenreId = GraphicNovel.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/91OjBx3hSNL._AC_UF1000,1000_QL80_.jpg"
			};

			TheHoundOfTheBaskervilles = new Book()
			{
				Id = 50,
				Title = "The Hound of the Baskervilles",
				Description = @"A mystery novel by Sir Arthur Conan Doyle, featuring 
    the detective Sherlock Holmes and his loyal companion Dr. John Watson. 
    The Hound of the Baskervilles follows Holmes and Watson as they investigate 
    the mysterious death of Sir Charles Baskerville and the legend of a demonic 
    hound haunting the Baskerville family. Doyle's masterful storytelling 
    and intricate plotting make this one of the most beloved Sherlock Holmes 
    mysteries.",
				Price = 8.99m,
				AuthorName = "Arthur Conan Doyle",
				GenreId = Mystery.Id,
				InStock = true,
				Rating = 5,
				ImageUrl = "https://cdn.penguin.co.uk/dam-assets/books/9780141329390/9780141329390-jacket-large.jpg"
			};

			TheMurderOfRogerAckroyd = new Book()
			{
				Id = 51,
				Title = "The Murder of Roger Ackroyd",
				Description = @"A mystery novel by Agatha Christie, featuring her 
    famous detective Hercule Poirot. The Murder of Roger Ackroyd is 
    known for its twist ending, considered one of the greatest in 
    detective fiction. The story follows Poirot as he investigates 
    the murder of Roger Ackroyd in a small English village, unraveling 
    a web of secrets and deception along the way.",
				Price = 9.49m,
				AuthorName = "Agatha Christie",
				GenreId = Mystery.Id, 
				InStock = true,
				Rating = 5,
				ImageUrl = "https://m.media-amazon.com/images/I/51fzBbKwlsL.jpg",
			};

			FiftyShadesOfGrey = new Book()
			{
				Id = 52,
				Title = "Fifty Shades of Grey",
				Description = @"An erotic romance novel by E.L. James, the first 
    installment in the Fifty Shades trilogy. The story follows the 
    relationship between Anastasia Steele, a college graduate, and 
    Christian Grey, a wealthy entrepreneur with particular sexual 
    tastes. Fifty Shades of Grey explores themes of desire, power, 
    and the complexities of intimacy.",
				Price = 12.99m,
				AuthorName = "E. L. James",
				GenreId = RomanceNovel.Id, 
				InStock = true,
				Rating = 3,
				ImageUrl = "https://m.media-amazon.com/images/I/810BkqRP+iL._AC_UF894,1000_QL80_.jpg"
			};
		}
	}
}
