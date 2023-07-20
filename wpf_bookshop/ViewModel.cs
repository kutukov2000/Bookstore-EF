using exam_entity;
using exam_entity.Entities;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;

namespace wpf_bookshop
{
    [AddINotifyPropertyChangedInterface]
    class ViewModel
    {
        private BookShopDbContext context = new BookShopDbContext();

        public object CurrentTable { get; set; }
        public Book SelectedBook { get; set; }

        public ICollection<Book> booksToDelete { get; set; }
        public ICollection<Book> Books => context.Books.ToList();
        public ICollection<Author> Authors => context.Authors.ToList();
        public ICollection<Genre> Genres => context.Genres.ToList();
        public ICollection<Country> Countries => context.Countries.ToList();
        public ICollection<BookInStore> BooksInStore => context.BooksInStore.ToList();

        public RelayCommand SaveChangesCommand { get; set; }
        public RelayCommand BooksTableCommand { get; set; }
        public RelayCommand AuthorsTableCommand { get; set; }
        public RelayCommand GenresTableCommand { get; set; }
        public RelayCommand CountriesTableCommand { get; set; }
        public RelayCommand BooksInStoreTableCommand { get; set; }
        public RelayCommand AddBookCommand { get; set; }
        public RelayCommand DeleteBookCommand { get; set; }
        public ViewModel()
        {
            CurrentTable = Books;

            SaveChangesCommand = new RelayCommand(o =>
            {
                SaveChanges();
            });

            BooksTableCommand = new RelayCommand(o =>
            {
                CurrentTable = Books;
            });

            AuthorsTableCommand = new RelayCommand(o =>
            {
                CurrentTable = Authors;
            });

            GenresTableCommand = new RelayCommand(o =>
            {
                CurrentTable = Genres;
            });

            CountriesTableCommand = new RelayCommand(o =>
            {
                CurrentTable = Countries;
            });

            BooksInStoreTableCommand = new RelayCommand(o =>
            {
                CurrentTable = BooksInStore;
            });

            AddBookCommand = new RelayCommand(o =>
            {
                AddBook addBook = new AddBook();

                if (addBook.ShowDialog() == true)
                {
                    context.Books.Add(addBook.Book);
                    SaveChanges();
                }
                CurrentTable = Books;
            });

            DeleteBookCommand = new RelayCommand(o =>
            {
                if (SelectedBook is not null)
                {
                    context.Books.Remove(SelectedBook);
                    SaveChanges();
                }
                CurrentTable = Books;
            });
        }
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception) { }
        }
    }
}
