using exam_entity.Entities;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace wpf_bookshop
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public Book Book { get; set; }

        public AddBook()
        {
            InitializeComponent();
            Book = new Book();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Book.Pages = int.Parse(pages.Text);
            Book.AuthorId = int.Parse(author.Text);
            Book.GenreId = int.Parse(genre.Text);
            Book.Title = title.Text;
            Book.PublicationYear=int.Parse(year.Text);

            DialogResult = true;
            this.Close();
        }
    }
}
