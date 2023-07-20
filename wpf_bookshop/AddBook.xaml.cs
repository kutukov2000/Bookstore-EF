using exam_entity.Entities;
using System.Windows;

namespace wpf_bookshop
{
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
            Book.PublicationYear = int.Parse(year.Text);

            DialogResult = true;
            this.Close();
        }
    }
}
