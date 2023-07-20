using exam_entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_entity.Helpers
{
    public static class DbInializer
    {
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country[]
            {
        new Country()
        {
            Id = 1,
            Name = "Ukraine"
        },
        new Country()
        {
            Id = 2,
            Name = "Poland"
        },
        new Country()
        {
            Id = 3,
            Name = "Germany"
        },
        new Country()
        {
            Id = 4,
            Name = "France"
        },
        new Country()
        {
            Id = 5,
            Name = "Spain"
        },
        new Country()
        {
            Id = 6,
            Name = "Italy"
        },
        new Country()
        {
            Id = 7,
            Name = "South Korea"
        },
        new Country()
        {
            Id = 8,
            Name = "Sweden"
        },
        new Country()
        {
            Id = 9,
            Name = "Norway"
        },
        new Country()
        {
            Id = 10,
            Name = "Finland"
        },
        new Country()
        {
            Id = 11,
            Name = "United Kingdom"
        },
        new Country()
        {
            Id = 12,
            Name = "United States"
        },
        new Country()
        {
            Id = 13,
            Name = "Canada"
        },
        new Country()
        {
            Id = 14,
            Name = "Mexico"
        },
        new Country()
        {
            Id = 15,
            Name = "Brazil"
        },
        new Country()
        {
            Id = 16,
            Name = "Argentina"
        },
        new Country()
        {
            Id = 17,
            Name = "Australia"
        },
        new Country()
        {
            Id = 18,
            Name = "New Zealand"
        },
        new Country()
        {
            Id = 19,
            Name = "China"
        },
        new Country()
        {
            Id = 20,
            Name = "Japan"
        }
            });
        }
        public static void SeedGenres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new Genre[]
            {
        new Genre()
        {
            Id = 1,
            Name = "Action"
        },
        new Genre()
        {
            Id = 2,
            Name = "Adventure"
        },
        new Genre()
        {
            Id = 3,
            Name = "Comedy"
        },
        new Genre()
        {
            Id = 4,
            Name = "Drama"
        },
        new Genre()
        {
            Id = 5,
            Name = "Horror"
        },
        new Genre()
        {
            Id = 6,
            Name = "Mystery"
        },
        new Genre()
        {
            Id = 7,
            Name = "Romance"
        },
        new Genre()
        {
            Id = 8,
            Name = "Science Fiction"
        },
        new Genre()
        {
            Id = 9,
            Name = "Thriller"
        },
        new Genre()
        {
            Id = 10,
            Name = "Western"
        },
        new Genre()
        {
            Id = 11,
            Name = "Biography"
        },
        new Genre()
        {
            Id = 12,
            Name = "Crime"
        },
        new Genre()
        {
            Id = 13,
            Name = "Fantasy"
        },
        new Genre()
        {
            Id = 14,
            Name = "Historical"
        },
        new Genre()
        {
            Id = 15,
            Name = "Music"
        },
        new Genre()
        {
            Id = 16,
            Name = "Psychological"
        },
        new Genre()
        {
            Id = 17,
            Name = "Sports"
        },
        new Genre()
        {
            Id = 18,
            Name = "War"
        },
        new Genre()
        {
            Id = 19,
            Name = "Political"
        },
        new Genre()
        {
            Id = 20,
            Name = "Documentary"
        }
            });
        }
        public static void SeedAuthors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
        new Author()
        {
            Id = 1,
            Name = "Ernest Hemingway",
            CountryId = 12 // United States
        },
        new Author()
        {
            Id = 2,
            Name = "F. Scott Fitzgerald",
            CountryId = 12 // United States
        },
        new Author()
        {
            Id = 3,
            Name = "Virginia Woolf",
            CountryId = 11 // United Kingdom
        },
        new Author()
        {
            Id = 4,
            Name = "George Orwell",
            CountryId = 11 // United Kingdom
        },
        new Author()
        {
            Id = 5,
            Name = "J.R.R. Tolkien",
            CountryId = 11 // United Kingdom
        },
        new Author()
        {
            Id = 6,
            Name = "Ivan Franko",
            CountryId = 1 // Ukraine
        },
        new Author()
        {
            Id = 7,
            Name = "Lesya Ukrainka",
            CountryId = 1 // Ukraine
        },
        new Author()
        {
            Id = 8,
            Name = "Nikolai Gogol",
            CountryId = 1 // Ukraine
        },
        new Author()
        {
            Id = 9,
            Name = "Taras Shevchenko",
            CountryId = 1 // Ukraine
        },
        new Author()
        {
            Id = 10,
            Name = "Franz Kafka",
            CountryId = 3 // Germany
        },
        new Author()
        {
            Id = 11,
            Name = "Thomas Mann",
            CountryId = 3 // Germany
        },
        new Author()
        {
            Id = 12,
            Name = "Hermann Hesse",
            CountryId = 3 // Germany
        },
        new Author()
        {
            Id = 13,
            Name = "Johann Wolfgang von Goethe",
            CountryId = 3 // Germany
        },
        new Author()
        {
            Id = 14,
            Name = "Gabriel Garcia Marquez",
            CountryId = 15 // Colombia
        },
        new Author()
        {
            Id = 15,
            Name = "Mario Vargas Llosa",
            CountryId = 19 // Peru
        },
        new Author()
        {
            Id = 16,
            Name = "Isabel Allende",
            CountryId = 19 // Chile
        },
        new Author()
        {
            Id = 17,
            Name = "Haruki Murakami",
            CountryId = 20 // Japan
        },
        new Author()
        {
            Id = 18,
            Name = "Yukio Mishima",
            CountryId = 20 // Japan
        },
        new Author()
        {
            Id = 19,
            Name = "Jhumpa Lahiri",
            CountryId = 12 // United States
        },
        new Author()
        {
            Id = 20,
            Name = "Toni Morrison",
            CountryId = 12 // United States
        }
            });
        }
        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book[]
            {
                new Book()
                {
                    Id = 1,
                    Title = "The Old Man and the Sea",
                    AuthorId = 1,
                    GenreId = 1,
                    PublicationYear = 1952,
                    Pages=128
                },
                new Book()
                {
                    Id = 2,
                    Title = "The Great Gatsby",
                    AuthorId = 2,
                    GenreId = 1,
                    PublicationYear = 1925,
                    Pages=180
                },
                new Book()
                {
                    Id = 3,
                    Title = "To the Lighthouse",
                    AuthorId = 3,
                    GenreId = 1,
                    PublicationYear = 1927,
                    Pages = 209
                },
                new Book()
                {
                    Id = 4,
                    Title = "1984",
                    AuthorId = 4,
                    GenreId = 2,
                    PublicationYear = 1949,
                    Pages=328
                },
                new Book()
                {
                    Id = 5,
                    Title = "The Lord of the Rings",
                    AuthorId = 5,
                    GenreId = 3,
                    PublicationYear = 1954,
                    Pages = 1178
                },
                new Book()
                {
                    Id = 6,
                    Title = "Zahar Berkut",
                    AuthorId = 6,
                    GenreId = 4,
                    PublicationYear = 1882,
                    Pages = 392
                },
                new Book()
                {
                    Id = 7,
                    Title = "Forest Song",
                    AuthorId = 7,
                    GenreId = 4,
                    PublicationYear = 1911,
                    Pages = 96
                },
                new Book()
                {
                    Id = 8,
                    Title = "Dead Souls",
                    AuthorId = 8,
                    GenreId = 4,
                    PublicationYear = 1842,
                    Pages = 432
                },
                new Book()
                {
                    Id = 9,
                    Title = "Kobzar",
                    AuthorId = 9,
                    GenreId = 4,
                    PublicationYear = 1840,
                    Pages = 352
                },
                new Book()
                {
                    Id = 10,
                    Title = "The Trial",
                    AuthorId = 10,
                    GenreId = 5,
                    PublicationYear = 1925,
                    Pages = 224
                },
                new Book()
                {
                    Id = 11,
                    Title = "The Magic Mountain",
                    AuthorId = 11,
                    GenreId = 5,
                    PublicationYear = 1924,
                    Pages = 720
                },
                new Book()
                {
                    Id = 12,
                    Title = "Siddhartha",
                    AuthorId = 12,
                    GenreId = 5,
                    PublicationYear = 1922,
                    Pages = 152
                },
                new Book()
                {
                    Id = 13,
                    Title = "Faust",
                    AuthorId = 13,
                    GenreId = 6,
                    PublicationYear = 1808,
                    Pages = 356
                },
                new Book()
                {
                    Id = 14,
                    Title = "Brave New World",
                    AuthorId = 14,
                    PublicationYear = 1932,
                    GenreId = 1,
                    Pages=288
                },
                new Book()
                {
                    Id = 15,
                    Title = "Crime and Punishment",
                    AuthorId = 15,
                    PublicationYear = 1866,
                    GenreId = 2,
                    Pages=544
                },
                new Book()
                {
                    Id = 16,
                    Title = "Pride and Prejudice",
                    AuthorId = 16,
                    PublicationYear = 1813,
                    GenreId = 3,
                    Pages=352
                },
                new Book()
                {
                    Id = 17,
                    Title = "Les Misérables",
                    AuthorId = 17,
                    PublicationYear = 1862,
                    GenreId = 4,
                    Pages=1232
                },
                new Book()
                {
                    Id = 18,
                    Title = "The Brothers Karamazov",
                    AuthorId = 18,
                    PublicationYear = 1880,
                    GenreId = 2,
                    Pages=824
                },
                new Book()
                {
                    Id = 19,
                    Title = "War and Peace",
                    AuthorId = 19,
                    PublicationYear = 1869,
                    GenreId = 4,
                    Pages=1440
                }
            });

        }
        public static void SeedBookInStore(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookInStore>().HasData(new BookInStore[]
    {
        new BookInStore
        {
            Id = 1,
            Cost = 10.99,
            Price = 19.99,
            Discount = 45,
            Quantity = 10,
             BookId = 1
        },
        new BookInStore
        {
            Id = 2,
            Cost = 15.99,
            Price = 24.99,
            Discount = 35,
            Quantity = 15,
            BookId = 2
        },
        new BookInStore
        {
            Id = 3,
            Cost = 8.99,
            Price = 14.99,
            Discount = 40,
            Quantity = 20,
            BookId = 3
        },
        new BookInStore
        {
            Id = 4,
            Cost = 5.99,
            Price = 9.99,
            Discount = 40,
            Quantity = 25,
            BookId = 4
        },
        new BookInStore
        {
            Id = 5,
            Cost = 18.99,
            Price = 29.99,
            Discount = 35,
            Quantity = 12,
            BookId = 5
        },
        new BookInStore
        {
            Id = 6,
            Cost = 7.99,
            Price = 12.99,
            Discount = 38,
            Quantity = 18,
            BookId = 6
        },
        new BookInStore
        {
            Id = 7,
            Cost = 12.99,
            Price = 21.99,
            Discount = 40,
            Quantity = 14,
            BookId = 7
        },
        new BookInStore
        {
            Id = 8,
            Cost = 11.99,
            Price = 19.99,
            Discount = 40,
            Quantity = 10,
            BookId = 8
        },
        new BookInStore
        {
            Id = 9,
            Cost = 9.99,
            Price = 16.99,
            Discount = 41,
            Quantity = 22,
            BookId = 9
        },
        new BookInStore
        {
            Id = 10,
            Cost = 13.99,
            Price = 23.99,
            Discount = 40,
            Quantity = 13,
            BookId = 10
        },
        new BookInStore
        {
            Id = 11,
            Cost = 16.99,
            Price = 27.99,
            Discount = 35,
            Quantity = 16,
                BookId = 11
        },
        new BookInStore
        {
            Id = 12,
            Cost = 14.99,
            Price = 24.99,
            Discount = 40,
            Quantity = 18,
            BookId = 12
        },
        new BookInStore
        {
            Id = 13,
            Cost = 20.99,
            Price = 32.99,
            Discount = 35,
            Quantity = 11,
            BookId = 13
        },
        new BookInStore
        {
            Id = 14,
            Cost = 6.99,
            Price = 10.99,
            Discount = 37,
            Quantity = 24,
            BookId = 14
        },
        new BookInStore
        {
            Id = 15,
            Cost = 17.99,
            Price = 28.99,
            Discount = 35,
            Quantity = 15,
            BookId = 15
        },
        new BookInStore
        {
            Id = 16,
            Cost = 10.99,
            Price = 17.99,
            Discount = 38,
            Quantity= 21,
            BookId = 16
},
new BookInStore
{
Id = 17,
Cost = 7.99,
Price = 12.99,
Discount = 38,
Quantity = 19,
BookId = 17
},
new BookInStore
{
Id = 18,
Cost = 9.99,
Price = 16.99,
Discount = 41,
Quantity = 23,
BookId = 18
},
new BookInStore
{
Id = 19,
Cost = 11.99,
Price = 19.99,
Discount = 40,
Quantity = 12,
BookId = 19
}
});
        }

    }
}
