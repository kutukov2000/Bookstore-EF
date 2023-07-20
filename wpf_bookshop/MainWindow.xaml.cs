using exam_entity;
using exam_entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_bookshop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel model = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = model.Authors;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = model.Books;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = model.Countries;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = model.Genres;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = model.BooksInStore;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if(checkIsReadOnly.IsChecked != true)
            {
            model.DeleteSelectedBooks(datagrid.SelectedItems.Cast<Book>().ToList());
            
            }
            datagrid.ItemsSource = model.Books;
        }

        private void datagrid_LostFocus(object sender, RoutedEventArgs e)
        {
            model.SaveChanges();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AddBook addBook = new AddBook();
            if (addBook.ShowDialog() == true)
            {
                model.AddBook(addBook.Book);
            }
            datagrid.ItemsSource = model.Books;
        }
    }
    class ViewModel
    {
        private BookShopDbContext context = new BookShopDbContext();

        public ICollection<Book> Books => context.Books.ToList();
        public ICollection<Author> Authors => context.Authors.ToList();
        public ICollection<Genre> Genres => context.Genres.ToList();
        public ICollection<Country> Countries => context.Countries.ToList();
        public ICollection<BookInStore> BooksInStore => context.BooksInStore.ToList();
        public ViewModel() { }
        public void DeleteSelectedBooks(ICollection<Book> booksToDelete)
        {
            foreach (Book book in booksToDelete)
            {
                context.Books.Remove(book);
            }

            SaveChanges();
        }
        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception) { }
        }
        public void AddBook(Book newBook)
        {
            context.Books.Add(newBook);
            SaveChanges();
        }
    }
}
