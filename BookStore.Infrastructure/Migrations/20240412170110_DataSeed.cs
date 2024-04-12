using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Infrastructure.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "f9d7a8ed-2513-414a-9b16-aefd735cc53a", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMINISTRATORA", "AQAAAAEAACcQAAAAEMI3mkiGRJ6HTam5rO/X7AwJ5P4WC7lL4kIgxft8q4BHi/7Ax+0zEe7D5FvI8Z6OoQ==", null, false, "50b1f5e6-f749-4472-bfda-67c3f7fffa83", false, "AdministratorA" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Mystery" },
                    { 3, "Narrative" },
                    { 4, "Novel" },
                    { 5, "Science Fiction" },
                    { 6, "Non-Fiction" },
                    { 7, "Historical Fiction" },
                    { 8, "Romance Novel" },
                    { 9, "Memoir" },
                    { 10, "Children's Literature" },
                    { 11, "Thriller" },
                    { 12, "Graphic Novel" },
                    { 13, "Horror" },
                    { 14, "Fantasy Fiction" },
                    { 15, "History" },
                    { 16, "Literary Fiction" },
                    { 17, "Short Story" },
                    { 18, "Historical Fantasy" },
                    { 19, "Fantasy" },
                    { 20, "Poetry" },
                    { 21, "Biography" },
                    { 22, "Essay" },
                    { 23, "Autobiography" },
                    { 24, "Humour" },
                    { 25, "Science" },
                    { 26, "Drama" },
                    { 27, "Philosophy" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "ClientId", "Description", "GenreId", "ImageUrl", "InStock", "Price", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", 1, "A novel by F. Scott Fitzgerald, set in the Jazz Age on Long Island \r\n    and New York City. The story depicts the mysterious millionaire Jay Gatsby and \r\n    his passionate pursuit of the elusive Daisy Buchanan. Through themes of love, \r\n    wealth, and the American Dream, Fitzgerald explores the emptiness and moral decay \r\n    lurking beneath the surface of the Roaring Twenties.", 16, "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg/220px-The_Great_Gatsby_Cover_1925_Retouched.jpg", true, 12.99m, 4, "The Great Gatsby" },
                    { 2, "George Orwell", 1, "A dystopian novel by George Orwell, set in a totalitarian regime \r\n    where individuality and freedom are suppressed by omnipresent government surveillance. \r\n    The story follows Winston Smith as he rebels against the oppressive Party led by Big Brother, \r\n    questioning reality and seeking personal freedom in a world dominated by propaganda and thought control.", 5, "https://m.media-amazon.com/images/I/61ZewDE3beL._AC_UF894,1000_QL80_.jpg", true, 10.49m, 4, "Nineteen Eighty-Four" },
                    { 3, "Jane Austen", 1, "A novel by Jane Austen, one of the most beloved works of English literature. \r\n    The story follows the romantic entanglements of the Bennet sisters, particularly the headstrong \r\n    Elizabeth Bennet and the aloof Mr. Darcy. Through wit, satire, and social commentary, Austen \r\n    explores themes of love, class, and the constraints of societal expectations in early 19th-century England.", 8, "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781524861759/pride-and-prejudice-9781524861759_hr.jpg", true, 9.99m, 5, "Pride and Prejudice" },
                    { 4, "Charlotte Brontë", 1, "A novel by Charlotte Brontë, a classic of English literature. \r\n    The story follows the titular character, an orphaned governess, as she navigates \r\n    the challenges of love, morality, and independence in 19th-century England. Brontë's \r\n    exploration of social class, gender roles, and the pursuit of self-respect continues \r\n    to captivate readers with its timeless themes.", 16, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1692725440i/197321006.jpg", true, 8.99m, 4, "Jane Eyre" },
                    { 5, "Patrick Rothfuss", 1, "A fantasy novel by Patrick Rothfuss, the first book in the \r\n    Kingkiller Chronicle series. The story is framed as a retrospective narrative \r\n    of the legendary hero Kvothe, recounting his early life and adventures. Rothfuss \r\n    weaves a rich tapestry of magic, music, and intrigue, drawing readers into a \r\n    world of wonder and danger.", 14, "https://www.gollancz.co.uk/wp-content/uploads/2018/07/hbg-title-9781473224087-159.jpg", true, 13.99m, 4, "The Name of the Wind" },
                    { 6, "Patrick Rothfuss", 1, "The second book in the Kingkiller Chronicle series by Patrick Rothfuss. \r\n    Continuing Kvothe's journey, the story delves deeper into his adventures across the \r\n    magical and treacherous world of Temerant. Rothfuss masterfully blends elements of \r\n    epic fantasy, adventure, and mystery to create a captivating narrative that keeps \r\n    readers eagerly turning pages.", 14, "https://m.media-amazon.com/images/I/81Ctt30rgxS._AC_UF1000,1000_QL80_.jpg", true, 14.49m, 4, "The Wise Man's Fear" },
                    { 7, "Anne Frank", 1, "The diary of Anne Frank, a Jewish teenager who hid from \r\n    the Nazis during World War II. Anne's poignant and insightful entries \r\n    provide a firsthand account of the hardships, fears, and hopes of those \r\n    living in hiding. Her story serves as a powerful reminder of the human \r\n    spirit's resilience and the enduring importance of bearing witness to history.", 9, "https://m.media-amazon.com/images/I/51Eyjz65gyL._AC_UF1000,1000_QL80_.jpg", true, 9.99m, 5, "The Diary of a Young Girl" },
                    { 8, "David Grann", 1, "A non-fiction book by David Grann, investigating the murders of \r\n    Osage Indians in Oklahoma during the 1920s. Grann explores the conspiracy and \r\n    corruption surrounding the killings, revealing a chilling tale of greed, racism, \r\n    and injustice. His meticulous research and gripping storytelling shed light on \r\n    a dark chapter of American history.", 6, "https://images.macrumors.com/t/HY9LeIGBDDKDrTF3if3D6Pnrxic=/1200x1200/smart/article-new/2020/05/killersoftheflowermoon.jpg", true, 13.99m, 4, "Killers of the Flower Moon" },
                    { 9, "James Clear", 1, "A self-help book by James Clear, offering practical strategies \r\n    for building good habits and breaking bad ones. Clear draws on scientific research \r\n    and real-life examples to provide actionable advice on how to make small changes \r\n    that yield remarkable results. Atomic Habits empowers readers to take control of \r\n    their behavior and create lasting positive change.", 6, "https://m.media-amazon.com/images/I/81YkqyaFVEL._AC_UF1000,1000_QL80_.jpg", true, 14.49m, 4, "Atomic Habits" },
                    { 10, "Frank Herbert", 1, "A science fiction novel by Frank Herbert, set in a distant \r\n    future where noble houses vie for control of the desert planet Arrakis. \r\n    The story follows Paul Atreides as he becomes embroiled in political intrigue, \r\n    religious prophecy, and the struggle for survival in a harsh and unforgiving landscape.", 5, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1555447414i/44767458.jpg", true, 11.99m, 5, "Dune" },
                    { 11, "Douglas Adams", 1, "A comedic science fiction series by Douglas Adams, following \r\n    the misadventures of Arthur Dent after Earth's destruction to make way for \r\n    a hyperspace bypass. With the help of his alien friend Ford Prefect, Arthur \r\n    embarks on a journey through space filled with absurdity, satire, and philosophical musings.", 5, "https://cdn.waterstones.com/bookjackets/large/9781/5290/9781529034523.jpg", true, 9.99m, 5, "The Hitchhiker's Guide to the Galaxy" },
                    { 12, "Mary Shelley", 1, "A gothic science fiction novel by Mary Shelley, exploring \r\n    themes of creation, ambition, and the consequences of playing god. The story \r\n    follows Victor Frankenstein and his creation, often referred to as Frankenstein's \r\n    monster, as they grapple with their own identities and the moral implications of \r\n    their actions.", 5, "https://m.media-amazon.com/images/I/81z7E0uWdtL._AC_UF1000,1000_QL80_.jpg", true, 8.99m, 4, "Frankenstein" },
                    { 13, "Stanisław Lem", 1, "A philosophical science fiction novel by Stanisław Lem, \r\n    exploring the nature of consciousness, communication, and the unknown. \r\n    Set on the mysterious planet Solaris, the story follows psychologist Kris \r\n    Kelvin as he grapples with strange phenomena and confronts his own inner demons.", 5, "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1498631519l/95558.jpg", true, 10.49m, 4, "Solaris" },
                    { 14, "Dan Brown", 1, "A mystery thriller novel by Dan Brown, following symbologist \r\n    Robert Langdon as he investigates a murder in the Louvre Museum. Langdon \r\n    uncovers a series of cryptic clues leading to a centuries-old secret that \r\n    could shake the foundations of Christianity.", 2, "https://m.media-amazon.com/images/I/815WORuYMML._AC_UF1000,1000_QL80_.jpg", true, 11.99m, 4, "The Da Vinci Code" },
                    { 15, "Thomas Harris", 1, "A psychological horror novel by Thomas Harris, introducing \r\n    FBI trainee Clarice Starling and incarcerated cannibalistic serial killer Dr. \r\n    Hannibal Lecter. Starling seeks Lecter's insights into the mind of another \r\n    serial killer, Buffalo Bill, leading to a gripping cat-and-mouse game between \r\n    law enforcement and the criminally insane.", 11, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1647930822i/23807.jpg", true, 10.99m, 5, "The Silence of the Lambs" },
                    { 16, "Stephen King", 1, "A horror novel by Stephen King, set in the remote Overlook \r\n    Hotel during the winter season. As the hotel's isolation takes its toll on \r\n    the Torrance family, the young Danny Torrance discovers supernatural abilities \r\n    and the sinister history of the hotel. King's tale of terror explores themes \r\n    of addiction, madness, and the darkness lurking within.", 13, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1353277730i/11588.jpg", true, 9.49m, 5, "The Shining" },
                    { 17, "Stephen King", 1, "A horror novel by Stephen King, spanning multiple timelines \r\n    as a group of friends confronts an ancient evil lurking beneath the town \r\n    of Derry, Maine. King weaves together themes of friendship, trauma, and the \r\n    power of memory in a chilling narrative that explores the resilience of the \r\n    human spirit in the face of unimaginable horror.", 13, "https://i.ebayimg.com/images/g/rgkAAOSw969f~26A/s-l600.jpg", true, 12.99m, 5, "It" },
                    { 18, "H.P. Lovecraft", 1, "A horror short story by H.P. Lovecraft, introducing the \r\n    cosmic entity Cthulhu and the Cthulhu Mythos. The story follows a series of \r\n    interconnected narratives uncovering the existence of ancient beings beyond \r\n    human comprehension, and the cults that worship them.", 13, "https://cdn.kobo.com/book-images/828f93f3-99af-4795-afc8-f3a517a21f7b/1200/1200/False/the-call-of-cthulhu-46.jpg", true, 7.99m, 4, "The Call of Cthulhu" },
                    { 19, "H.P. Lovecraft", 1, "A fictional grimoire by H.P. Lovecraft, often cited in \r\n    Lovecraft's mythos as a tome of forbidden knowledge and occult rituals. \r\n    While the Necronomicon is a creation of Lovecraft's imagination, it has \r\n    since become a cultural icon associated with cosmic horror and eldritch lore.", 13, "https://m.media-amazon.com/images/M/MV5BNTdhNDQ2NWItYThjOC00ODU2LWIzNTMtY2ZhMTMwOWE5NjM2XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg", true, 15.99m, 4, "Necronomicon" },
                    { 20, "H.P. Lovecraft", 1, "A cosmic horror short story by H.P. Lovecraft, depicting \r\n    the blind and mindless entity Azathoth at the center of the universe, \r\n    surrounded by the Outer Gods and other eldritch entities. Lovecraft's \r\n    portrayal of Azathoth as the ultimate chaos and entropy embodies the \r\n    existential dread inherent in cosmic horror.", 13, "https://cdn.kobo.com/book-images/b332f191-3dab-4016-b050-65ec6edaf8d7/1200/1200/False/azathoth-7.jpg", true, 8.49m, 4, "Azathoth" },
                    { 21, "Arnold Schwarzenegger", 1, "An autobiography by Arnold Schwarzenegger, detailing his \r\n    journey from a small town in Austria to becoming a bodybuilding champion, \r\n    Hollywood actor, and eventually Governor of California. Schwarzenegger's \r\n    candid account offers insights into his successes, setbacks, and the \r\n    principles that guided his remarkable career.", 23, "https://m.media-amazon.com/images/I/71rL8t6PgqL._AC_UF1000,1000_QL80_.jpg", true, 13.99m, 4, "Total Recall" },
                    { 22, "Michelle Obama", 1, "An autobiographical memoir by Michelle Obama, chronicling \r\n    her life from childhood to her tenure as First Lady of the United States. \r\n    With candor and grace, Obama shares her personal journey, reflecting on \r\n    family, identity, and the power of resilience in the face of adversity.", 23, "https://m.media-amazon.com/images/I/81cJTmFpG-L._AC_UF1000,1000_QL80_.jpg", true, 14.49m, 5, "Becoming" },
                    { 23, "Terry Pratchett and Neil Gaiman", 1, "A fantasy novel by Terry Pratchett and Neil Gaiman, \r\n    blending humor, satire, and supernatural elements. The story follows an \r\n    angel and a demon who team up to prevent the apocalypse, leading to \r\n    hilarious and unexpected consequences. Pratchett and Gaiman's collaboration \r\n    is a delightful romp through the end of the world.", 14, "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1615552073l/12067.jpg", true, 11.99m, 5, "Good Omens" },
                    { 24, "Marcus Aurelius", 1, "A series of personal writings by the Roman Emperor \r\n    Marcus Aurelius, offering reflections on Stoic philosophy and principles \r\n    for living a virtuous life. Written as a series of notes to himself, \r\n    Meditations provides timeless wisdom on resilience, self-discipline, \r\n    and the pursuit of inner peace.", 27, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFNQLrDdV96Lxaj5n51b9ylGOUoTmews-Uo8edDGkkpA&s", true, 9.99m, 5, "Meditations" },
                    { 25, "Laozi", 1, "An ancient Chinese philosophical text attributed to \r\n    the sage Laozi, offering insights into Taoist philosophy and the \r\n    nature of existence. The Tao Te Ching explores concepts such as \r\n    balance, harmony, and the principle of wu wei (effortless action), \r\n    guiding readers on a journey of self-discovery and spiritual growth.", 27, "https://m.media-amazon.com/images/I/61hIkVIW9fL._AC_UF894,1000_QL80_.jpg", true, 8.99m, 4, "Tao Te Ching" },
                    { 26, "Aristotle", 1, "A treatise by the ancient Greek philosopher Aristotle, \r\n    exploring the nature of virtue, happiness, and the good life. Drawing \r\n    on practical wisdom and moral philosophy, Aristotle offers a systematic \r\n    examination of ethical principles and their application to human conduct.", 27, "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781625582089/the-nicomachean-ethics-9781625582089_hr.jpg", true, 10.99m, 5, "Nicomachean Ethics" },
                    { 27, "Seneca the Younger", 1, "A collection of letters by the Roman Stoic philosopher \r\n    Seneca, addressing topics such as virtue, wisdom, and the art of living \r\n    a meaningful life. Seneca's epistles offer timeless advice and insights \r\n    into Stoic principles, providing readers with practical wisdom for navigating \r\n    the challenges of existence.", 27, "https://m.media-amazon.com/images/I/71CH1raWZ8L._AC_UF1000,1000_QL80_.jpg", true, 9.49m, 5, "Epistulae Morales ad Lucilium" },
                    { 28, "René Descartes", 1, "A philosophical work by René Descartes, laying the \r\n    groundwork for modern Western philosophy. In Meditations, Descartes \r\n    employs methodical doubt to arrive at foundational truths, famously \r\n    asserting \"Cogito, ergo sum\" (\"I think, therefore I am\"). His \r\n    exploration of skepticism, knowledge, and the existence of God \r\n    continues to influence philosophical discourse to this day.", 27, "https://m.media-amazon.com/images/I/61ZsD7TuuvL._AC_UF1000,1000_QL80_.jpg", true, 11.99m, 4, "Meditations on First Philosophy" },
                    { 29, "Friedrich Nietzsche", 1, "A philosophical novel by Friedrich Nietzsche, \r\n    presenting the ideas of the Übermensch (Overman) and the eternal \r\n    recurrence. Through the character of Zarathustra, Nietzsche explores \r\n    themes of individualism, morality, and the search for meaning in \r\n    a world without divine guidance. This seminal work challenges \r\n    traditional values and calls for the reevaluation of human existence.", 27, "https://m.media-amazon.com/images/I/613ZVoVVeXL._AC_UF350,350_QL50_.jpg", true, 10.49m, 4, "Thus Spoke Zarathustra" },
                    { 30, "Immanuel Kant", 1, "A philosophical work by Immanuel Kant, laying the \r\n    groundwork for his transcendental idealism and epistemology. In \r\n    Critique of Pure Reason, Kant explores the nature of human knowledge, \r\n    distinguishing between phenomena (objects as they appear to us) and \r\n    noumena (things as they are in themselves). His critique of reason \r\n    revolutionized modern philosophy and continues to influence \r\n    metaphysical and epistemological debates.", 27, "https://rowman.com/L/08/797/9780879755966.jpg", true, 12.99m, 4, "Critique of Pure Reason" },
                    { 31, "Sun Tzu", 1, "A treatise on military strategy attributed to the \r\n    ancient Chinese military strategist Sun Tzu. The Art of War offers \r\n    timeless insights into tactics, leadership, and the nature of conflict. \r\n    Its teachings on deception, maneuvering, and the importance of knowing \r\n    oneself and one's enemy have found applications beyond the battlefield \r\n    in areas such as business, politics, and personal development.", 27, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkauDL9kU-dnyrZpeWTY8SYegQ6h_4BYKtFtxTGWEs7Q&s", true, 8.99m, 5, "The Art of War" },
                    { 32, "William Shakespeare", 1, "A tragedy by William Shakespeare, considered one of \r\n    the greatest works in the English language. The play follows Prince Hamlet \r\n    of Denmark as he grapples with revenge, madness, and existential angst \r\n    after his father's murder. Shakespeare's exploration of moral ambiguity, \r\n    deception, and the human condition continues to captivate audiences \r\n    and scholars alike.", 26, "https://m.media-amazon.com/images/I/51cjtXsg1eL._AC_UF1000,1000_QL80_.jpg", true, 7.99m, 5, "Hamlet" },
                    { 33, "Louisa May Alcott", 1, "A novel by Louisa May Alcott, following the lives \r\n    of the March sisters—Meg, Jo, Beth, and Amy—as they come of age during \r\n    the Civil War era. Little Women explores themes of family, sisterhood, \r\n    love, and the pursuit of personal aspirations against societal expectations. \r\n    Alcott's heartfelt storytelling and memorable characters have made \r\n    the novel a timeless classic.", 16, "https://cdn.kobo.com/book-images/f7c39f83-b19a-4566-88cb-c13236e6178e/1200/1200/False/little-women-159.jpg", true, 9.49m, 5, "Little Women" },
                    { 34, "William Shakespeare", 1, "A play by William Shakespeare, often considered \r\n    his final masterpiece. The Tempest tells the story of Prospero, \r\n    a sorcerer and the rightful Duke of Milan, who conjures a storm \r\n    to shipwreck his enemies on a remote island. Themes of power, \r\n    forgiveness, and the complexity of human nature abound in this \r\n    magical and thought-provoking work.", 26, "https://ik.imagekit.io/panmac/tr:di-placeholder_portrait_aMjPtD9YZ.jpg,tr:w-350,f-jpg,pr-true/edition/9781509889761.jpg", true, 7.99m, 4, "The Tempest" },
                    { 35, "Mario Puzo", 1, "A crime novel by Mario Puzo, depicting the Corleone \r\n    family's rise to power in the world of organized crime. The Godfather \r\n    explores themes of loyalty, betrayal, and the American Dream, offering \r\n    a gripping portrayal of the Mafia underworld and the complexities \r\n    of family ties. Puzo's iconic novel has left an indelible mark \r\n    on popular culture.", 4, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1394988109i/22034.jpg", true, 10.99m, 5, "The Godfather" },
                    { 36, "Emily Dickinson", 1, "Emily Dickinson's 'Poems' is a collection of profound and evocative verses exploring themes of nature, love, and mortality. \r\n	With her unique style and insightful imagery,\r\n	Dickinson invites readers to contemplate the mysteries of life and the human experience.", 20, "https://m.media-amazon.com/images/I/81rFA+FDcVL._AC_UF1000,1000_QL80_.jpg", true, 8.49m, 5, "Poems" },
                    { 37, "Len Pennie", 1, "A collection of poems by Scottish writer Len Pennie.", 20, "https://m.media-amazon.com/images/I/716tBkcqt8L._AC_UF1000,1000_QL80_.jpg", true, 7.99m, 4, "Poyums" },
                    { 38, "Homer", 1, "An ancient Greek epic poem attributed to Homer, \r\n    chronicling the events of the Trojan War. The Iliad centers on the \r\n    wrath of Achilles and its devastating consequences, exploring themes \r\n    of honor, glory, fate, and the human condition. Regarded as one \r\n    of the greatest works of Western literature, the Iliad continues \r\n    to influence storytelling and cultural imagination.", 20, "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1681797700l/77265004.jpg", true, 9.99m, 5, "Iliad" },
                    { 39, "Homer", 1, "An ancient Greek epic poem attributed to Homer, \r\n    depicting the journey of the hero Odysseus as he seeks to return \r\n    home after the fall of Troy. The Odyssey is a timeless tale of \r\n    adventure, perseverance, and the triumph of the human spirit over \r\n    adversity. Homer's epic continues to captivate readers with its \r\n    vivid imagery and profound exploration of the human condition.", 20, "https://images.booksense.com/images/607/473/9798679473607.jpg", true, 10.49m, 5, "Odyssey" },
                    { 40, "William L. Shirer", 1, "A historical work by William L. Shirer, chronicling \r\n    the history of Nazi Germany from its inception to its collapse \r\n    at the end of World War II. Drawing on extensive research and \r\n    firsthand accounts, Shirer provides a comprehensive analysis \r\n    of Hitler's regime, its ideology, and the events that led to \r\n    its downfall. The Rise and Fall of the Third Reich remains \r\n    a definitive work on one of the darkest chapters in human history.", 15, "https://covers.storytel.com/jpg-640/9780795317002.7b3303b8-d0b9-4a55-82cf-9330a224e0d1?optimize=high&quality=70", true, 14.99m, 5, "The Rise and the Fall of the Third Reich" },
                    { 41, "A. A. Milne", 1, "A children's book by A.A. Milne, featuring the \r\n    adventures of Winnie the Pooh and his friends in the Hundred \r\n    Acre Wood. Filled with whimsy, humor, and gentle life lessons, \r\n    Winnie the Pooh has captured the hearts of readers of all ages \r\n    for generations. Milne's beloved characters continue to enchant \r\n    and inspire readers around the world.", 10, "https://m.media-amazon.com/images/I/71Joy8rn38L._AC_UF1000,1000_QL80_.jpg", true, 7.99m, 5, "Winnie the Pooh" },
                    { 42, "J. R. R. Tolkien", 1, "A fantasy novel by J.R.R. Tolkien, following \r\n    the journey of Bilbo Baggins as he embarks on an adventure \r\n    to reclaim the lost kingdom of Erebor from the dragon Smaug. \r\n    Along the way, Bilbo encounters trolls, elves, goblins, and \r\n    the enigmatic creature Gollum, setting the stage for the \r\n    epic events of The Lord of the Rings. Tolkien's enchanting \r\n    tale of courage, friendship, and heroism has captivated \r\n    readers of all ages for decades.", 14, "https://m.media-amazon.com/images/I/71jD4jMityL._AC_UF1000,1000_QL80_.jpg", true, 11.49m, 5, "The Hobbit" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "ClientId", "Description", "GenreId", "ImageUrl", "InStock", "Price", "Rating", "Title" },
                values: new object[,]
                {
                    { 43, "Antoine de Saint-Exupéry", 1, "A novella by Antoine de Saint-Exupéry, \r\n    telling the story of a young prince who travels from \r\n    planet to planet, encountering various characters \r\n    and learning profound lessons about love, friendship, \r\n    and the meaning of life. The Little Prince is a \r\n    timeless fable cherished by readers of all ages for \r\n    its simplicity, wisdom, and poignant insights into \r\n    the human condition.", 10, "https://m.media-amazon.com/images/I/71OZY035QKL._AC_UF1000,1000_QL80_.jpg", true, 8.99m, 5, "The Little Prince" },
                    { 44, "Stephen Hawking", 1, "A popular science book by Stephen Hawking, \r\n    offering an accessible overview of modern cosmology and \r\n    the nature of the universe. Hawking discusses complex \r\n    topics such as the Big Bang, black holes, and the quest \r\n    for a unified theory of physics in a clear and engaging \r\n    manner, making scientific concepts accessible to \r\n    general readers.", 25, "https://cdn.ozone.bg/media/catalog/product/cache/1/image/400x498/a4e40ebdc3e371adff845072e1c73f37/a/-/40c2f1fdc2ad8ffebaf55f314ce64a5a/a-brief-history-of-time-31.jpg", true, 10.99m, 5, "A Brief History of Time" },
                    { 45, "Carl Sagan", 1, "A science book by Carl Sagan, accompanying \r\n    the acclaimed television series of the same name. Cosmos \r\n    explores the universe from the smallest subatomic particles \r\n    to the largest galaxies, weaving together scientific knowledge, \r\n    philosophy, and storytelling to convey the wonder and \r\n    majesty of the cosmos. Sagan's passion for science and \r\n    exploration shines through in every page, inspiring readers \r\n    to contemplate their place in the universe.", 25, "https://m.media-amazon.com/images/I/91Cnrbd3JwL._AC_UF1000,1000_QL80_.jpg", true, 12.49m, 5, "Cosmos" },
                    { 46, "Neil deGrasse Tyson", 1, "A popular science book by Neil deGrasse Tyson, \r\n    offering a concise and accessible overview of astrophysics \r\n    for readers with limited time. Tyson covers topics such as \r\n    the origin of the universe, the nature of dark matter and \r\n    dark energy, and the search for extraterrestrial life in \r\n    a manner that is both informative and engaging, making \r\n    complex scientific concepts understandable to the layperson.", 25, "https://m.media-amazon.com/images/I/81G4WoQ9t8L._AC_UF1000,1000_QL80_.jpg", true, 9.99m, 5, "Astrophysics for People in a Hurry" },
                    { 47, "Stan Lee and Steve Ditko", 1, "A superhero comic book series featuring the iconic \r\n    character Spider-Man, created by writer Stan Lee and artist Steve Ditko. \r\n    The series follows the adventures of Peter Parker, a high school student \r\n    who gains spider-like abilities after being bitten by a radioactive spider. \r\n    Spider-Man battles villains while navigating the complexities of his dual \r\n    identity as a superhero and a young man dealing with personal struggles \r\n    and responsibilities.", 12, "https://images.penguinrandomhouse.com/cover/9781302931391", true, 9.99m, 5, "The Amazing Spider-Man" },
                    { 48, "Alan Moore and David Lloyd", 1, "A dystopian graphic novel by Alan Moore and David Lloyd, \r\n    set in a totalitarian Britain ruled by a fascist regime. The story follows \r\n    V, an anarchist revolutionary wearing a Guy Fawkes mask, as he orchestrates \r\n    a campaign of subversion and rebellion against the oppressive government. \r\n    V for Vendetta explores themes of freedom, identity, and the power of \r\n    resistance in the face of tyranny.", 12, "https://upload.wikimedia.org/wikipedia/en/c/c0/V_for_vendettax.jpg", true, 11.49m, 5, "V for Vendetta" },
                    { 49, "Alan Moore and Brian Bolland", 1, "A graphic novel by Alan Moore and Brian Bolland, \r\n    presenting an origin story for the Joker and exploring the complex \r\n    dynamic between the Joker and Batman. The Killing Joke delves into \r\n    themes of madness, morality, and the blurred line between hero and \r\n    villain in the dark and gritty world of Gotham City.", 12, "https://m.media-amazon.com/images/I/91OjBx3hSNL._AC_UF1000,1000_QL80_.jpg", true, 10.99m, 5, "Batman: The Killing Joke" },
                    { 50, "Arthur Conan Doyle", 1, "A mystery novel by Sir Arthur Conan Doyle, featuring \r\n    the detective Sherlock Holmes and his loyal companion Dr. John Watson. \r\n    The Hound of the Baskervilles follows Holmes and Watson as they investigate \r\n    the mysterious death of Sir Charles Baskerville and the legend of a demonic \r\n    hound haunting the Baskerville family. Doyle's masterful storytelling \r\n    and intricate plotting make this one of the most beloved Sherlock Holmes \r\n    mysteries.", 2, "https://cdn.penguin.co.uk/dam-assets/books/9780141329390/9780141329390-jacket-large.jpg", true, 8.99m, 5, "The Hound of the Baskervilles" },
                    { 51, "Agatha Christie", 1, "A mystery novel by Agatha Christie, featuring her \r\n    famous detective Hercule Poirot. The Murder of Roger Ackroyd is \r\n    known for its twist ending, considered one of the greatest in \r\n    detective fiction. The story follows Poirot as he investigates \r\n    the murder of Roger Ackroyd in a small English village, unraveling \r\n    a web of secrets and deception along the way.", 2, "https://m.media-amazon.com/images/I/51fzBbKwlsL.jpg", true, 9.49m, 5, "The Murder of Roger Ackroyd" },
                    { 52, "E. L. James", 1, "An erotic romance novel by E.L. James, the first \r\n    installment in the Fifty Shades trilogy. The story follows the \r\n    relationship between Anastasia Steele, a college graduate, and \r\n    Christian Grey, a wealthy entrepreneur with particular sexual \r\n    tastes. Fifty Shades of Grey explores themes of desire, power, \r\n    and the complexities of intimacy.", 8, "https://m.media-amazon.com/images/I/810BkqRP+iL._AC_UF894,1000_QL80_.jpg", true, 12.99m, 3, "Fifty Shades of Grey" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
