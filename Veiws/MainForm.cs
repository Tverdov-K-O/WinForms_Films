using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Films.Data;
using WinForms_Films.Entities;

namespace WinForms_Films.Veiws
{
    public partial class MainForm : Form
    {
        private AppDbContext _db = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
            RefrashGenres();
            RefrashFilms();
            RefrashFilmsGenres();
        }
        #region Фильмы-Жанр
        private void RefrashFilmsGenres()
        {
            listBox1.Items.Clear();
            var tempList = _db.Films.Select(x => x.Genres.Select(c => new
            {
                 Film = x.Name,
                 Genre = c.Name,
                 
            }))
            .SelectMany(s => s)
            .Where(s=> s.Genre != null);
            listBox1.Items.AddRange(tempList.ToArray());

        }
        private void RefrashFilmsGenres2()
        {
            listBoxFilmsGenres2.Items.Clear();
            listBoxFilmsGenres2.Items.AddRange(selectedFilm.Genres.ToArray());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedFilm == null)
            {
                MessageBox.Show("Выберите фильм");
                return;
            }
            else if(selectedGenre == null)
            {
                MessageBox.Show("Выберите Жанр");
                return;
            }
            selectedFilm.Genres = selectedFilm.Genres ?? new List<Genre>();
            selectedFilm.Genres.Add(selectedGenre);
            _db.SaveChanges();
            RefrashFilmsGenres();
            RefrashFilmsGenres2();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(selectedFilm != null)
            {
                selectedFilm.Genres.Remove(listBoxFilmsGenres2.SelectedItem as Genre);
            }
            RefrashFilmsGenres();
            RefrashFilmsGenres2();
            _db.SaveChanges();
        }
        #endregion

        #region UserControlFilms

        Film selectedFilm = null;
        private void RefrashFilms()
        {
            userControl_ForEntitiesFilms._ListBox.Items.Clear();
            userControl_ForEntitiesFilms._ListBox.Items.AddRange(_db.Films.ToArray());
            userControl_ForEntitiesFilms.textBox.Text = "";
            selectedFilm = null;
        }
        private void userControl_ForEntities1_Load(object sender, EventArgs e)
        {
            userControl_ForEntitiesFilms._ButtonDelete.Click += _ButtonDelete_Click;
            userControl_ForEntitiesFilms._ButtonSave.Click += _ButtonSave_Click;
            userControl_ForEntitiesFilms._ListBox.SelectedIndexChanged += _ListBox_SelectedIndexChanged;
            userControl_ForEntitiesFilms._ListBox.DoubleClick += _ListBox_DoubleClick;
        }
        private void _ListBox_DoubleClick(object sender, EventArgs e)
        {
            userControl_ForEntitiesFilms._ListBox.ClearSelected();
            RefrashFilms();
            RefrashFilmsGenres();
        }
        private void _ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userControl_ForEntitiesFilms._ListBox.SelectedIndex != -1)
            {
                selectedFilm = userControl_ForEntitiesFilms.listBox.SelectedItem as Film;
                userControl_ForEntitiesFilms.textBox.Text = selectedFilm.Name;
            }
            listBoxFilmsGenres2.Items.Clear();
            if (userControl_ForEntitiesFilms.listBox.SelectedItem == null)
            {
                return;
            }
            selectedFilm = userControl_ForEntitiesFilms.listBox.SelectedItem as Film;
           userControl_ForEntitiesFilms._TextBox.Text = selectedFilm.Name;
            _db.Entry(selectedFilm)
                .Collection(f => f.Genres)
                .Load();
            RefrashFilmsGenres2();
            RefrashFilmsGenres();
        }
        private void _ButtonSave_Click(object sender, EventArgs e)
        {
            if (selectedFilm == null)
                _db.Add(new Film { Name = userControl_ForEntitiesFilms.textBox.Text });
            else
                selectedFilm.Name = userControl_ForEntitiesFilms.textBox.Text;
            _db.SaveChanges();
            RefrashFilms();
        }
        private void _ButtonDelete_Click(object sender, EventArgs e)
        {
            if (userControl_ForEntitiesFilms._ListBox.SelectedItem == null)
            {

                MessageBox.Show("Нет выделенного фильма!");
                return;
            }
            try
            {
                _db.Remove(userControl_ForEntitiesFilms._ListBox.SelectedItem as Film);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefrashFilms();
        }
        #endregion

        #region UserControlGenres

        Genre selectedGenre = null;
        private void RefrashGenres()
        {
            userControl_ForEntitiesGenres._ListBox.Items.Clear();
            userControl_ForEntitiesGenres._ListBox.Items.AddRange(_db.Genres.ToArray());
            userControl_ForEntitiesGenres._TextBox.Text = "";
            selectedGenre = null;
        }
        private void userControl_ForEntitiesGenres_Load(object sender, EventArgs e)
        {
            userControl_ForEntitiesGenres._ButtonDelete.Click += _ButtonDelete_Click1; ;
            userControl_ForEntitiesGenres._ButtonSave.Click += _ButtonSave_Click1; ;
            userControl_ForEntitiesGenres._ListBox.SelectedIndexChanged += _ListBox_SelectedIndexChanged1; ;
            userControl_ForEntitiesGenres._ListBox.DoubleClick += _ListBox_DoubleClick1; ;
        }
        private void _ListBox_SelectedIndexChanged1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (userControl_ForEntitiesGenres._ListBox.SelectedItem == null)
            {
                return;
            }
            selectedGenre = userControl_ForEntitiesGenres._ListBox.SelectedItem as Genre;
            userControl_ForEntitiesGenres._TextBox.Text = selectedGenre.Name;
            RefrashFilmsGenres();
        }
        private void _ListBox_DoubleClick1(object sender, EventArgs e)
        {
            userControl_ForEntitiesGenres._ListBox.ClearSelected();
            RefrashGenres();
            RefrashFilmsGenres();
        }
        private void _ButtonSave_Click1(object sender, EventArgs e)
        {
            if (selectedGenre == null)
                _db.Add(new Genre { Name = userControl_ForEntitiesGenres._TextBox.Text });
            else
                selectedGenre.Name = userControl_ForEntitiesGenres._TextBox.Text;
            _db.SaveChanges();
            RefrashGenres();
        }
        private void _ButtonDelete_Click1(object sender, EventArgs e)
        {
            if (userControl_ForEntitiesGenres._ListBox.SelectedItem == null)
            {
                MessageBox.Show("Нет выделенного жанра!");
                return;
            }
            try
            {
                _db.Remove(userControl_ForEntitiesGenres._ListBox.SelectedItem as Genre);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefrashGenres();
        }

        #endregion

        
    }
}
