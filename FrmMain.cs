using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_MusicCollection_EDM
{
    public partial class FrmMain : Form
    {
        private List<Artists> artists;
        private List<Years> years;
        private List<Genres> genres;
        private List<Records> records;
        private List<Users> users;
        public Records SelectedRecord { get; set; }
        public Artists SelectedArtist { get; set; }
        public Genres SelectedGenre { get; set; }
        public Users SelectedUser { get; set; }


        public FrmMain(bool isAdmin)
        {
            InitializeComponent();
            artists = new List<Artists>();
            years = new List<Years>();
            genres = new List<Genres>();
            records = new List<Records>();
            users = new List<Users>();


            tbpUser.Visible = isAdmin;
            btnMod.Enabled = isAdmin;
            btnDel.Enabled = isAdmin;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            GetInfo();
        }
        private void GetInfo()
        {
            dgvMain.DataSource = null;
            cbbRecordGenre.DataSource = null;
            cbbRecordGroup.DataSource = null;

            artists.Clear();
            years.Clear();
            genres.Clear();
            records.Clear();
            users.Clear();

            tbRecordCost.Clear();
            tbRecordName.Clear();
            tbRecordPublisher.Clear();
            tbRecordSalePrice.Clear();
            tbRecordStockCount.Clear();
            tbRecordTrackCount.Clear();
            tbRecordYear.Clear();

            tbArtistName.Clear();

            tbGenreName.Clear();

            tbUserName.Clear();
            tbUserPassword.Clear();

            chkRecordOnSale.Checked = false;
            chkUserAdmin.Checked = false;
            



            using (var musicCollectionModel = new MusicCollectionModel())
            {
                artists = musicCollectionModel.Artists.ToList();
                cbbRecordGroup.DataSource = artists;
                cbbRecordGroup.DisplayMember = "Name";
                cbbRecordGroup.ValueMember = "ArtistID";

                genres = musicCollectionModel.Genres.ToList();
                cbbRecordGenre.DataSource = genres;
                cbbRecordGenre.DisplayMember = "GenreName";
                cbbRecordGenre.ValueMember = "GenreID";

                years = musicCollectionModel.Years.ToList();
                records = musicCollectionModel.Records.ToList();
                users = musicCollectionModel.Users.ToList();

                cbbRecordGroup.DataSource = artists;
                cbbRecordGenre.DataSource = genres;
                cbbRecordGenre.SelectedIndex = -1;
                cbbRecordGroup.SelectedIndex = -1;
                dgvMain.DataSource = records;
                tbpMain.SelectedTab = tbpRecord;
            }
        }

        private void tbpMain_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbpMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbpMain.SelectedTab == tbpRecord)
                    dgvMain.DataSource = records;
                else if (tbpMain.SelectedTab == tbpArtist)
                    dgvMain.DataSource = new List<ArtistsViewModel>(artists.Select(x => new ArtistsViewModel(x)));
                else if (tbpMain.SelectedTab == tbpGenre)
                    dgvMain.DataSource = new List<GenresViewModel>(genres.Select(x => new GenresViewModel(x)));
                else if (tbpMain.SelectedTab == tbpUser)
                    dgvMain.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0 && e.ColumnIndex >= 0))
                return;

            DataGridViewRow row = dgvMain.Rows[e.RowIndex];

            if (tbpMain.SelectedTab == tbpRecord)
                SelectRecord(row);
            else if (tbpMain.SelectedTab == tbpArtist)
                SelectArtist(row);
            else if (tbpMain.SelectedTab == tbpGenre)
                SelectGenre(row);
            else if (tbpMain.SelectedTab == tbpUser)
                SelectUser(row);

        }
        private void SelectRecord(DataGridViewRow row)
        {
            SelectedRecord = row.DataBoundItem as Records;
            tbRecordName.Text = SelectedRecord.Title;
            cbbRecordGroup.SelectedIndex = cbbRecordGroup.FindStringExact(SelectedRecord.Artists.Name);
            tbRecordPublisher.Text = SelectedRecord.Publisher;
            tbRecordTrackCount.Text = SelectedRecord.TracksCount.ToString();
            cbbRecordGenre.SelectedIndex = cbbRecordGenre.FindStringExact(SelectedRecord.Genres.GenreName);
            tbRecordYear.Text = SelectedRecord.Years.YearValue.ToString();
            tbRecordCost.Text = SelectedRecord.Cost.ToString();
            tbRecordSalePrice.Text = SelectedRecord.SalePrice.ToString();
            tbRecordStockCount.Text = SelectedRecord.StockCount.ToString();
            chkRecordOnSale.Checked = SelectedRecord.IsOnSale;


        }
        private void SelectArtist(DataGridViewRow row)
        {
            var SelectedAdtistVM = row.DataBoundItem as ArtistsViewModel;
            SelectedArtist = artists.FirstOrDefault(a => a.ArtistID == SelectedAdtistVM.ArtistID);
            tbArtistName.Text = SelectedArtist.Name;
        }
        private void SelectGenre(DataGridViewRow row)
        {
            var selectedGenreVM = row.DataBoundItem as GenresViewModel;
            SelectedGenre = genres.FirstOrDefault(a => a.GenreID == selectedGenreVM.GenreID);
            tbGenreName.Text = SelectedGenre.GenreName;
        }
        private void SelectUser(DataGridViewRow row)
        {
            SelectedUser = row.DataBoundItem as Users;
            tbUserName.Text = SelectedUser.Username;
            tbUserPassword.Text = SelectedUser.Password;
            chkUserAdmin.Checked = SelectedUser.AccessLevel > 0;
        }
        private void SQLInsertArtist(Artists artist)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Artists.Add(artist);
                context.SaveChanges();
                artists.Add(artist);
            }
        }

        private void SQLUpdateArtist(Artists artist)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Artists.AddOrUpdate(artist);
                context.SaveChanges();
            }
        }

        private void SQLDeleteArtist(int artistId)
        {
            using (var context = new MusicCollectionModel())
            {
                var artist = context.Artists.Include(a => a.Records).FirstOrDefault(a => a.ArtistID == artistId);

                if (artist != null)
                {
                    var recordsToDelete = artist.Records.ToList(); 
                    context.Records.RemoveRange(recordsToDelete); 
                    foreach (var record in recordsToDelete)                    
                        records.Remove(record);   

                    context.Artists.Remove(artist);
                    context.SaveChanges();
                    artists.Remove(artist);
                }
            }
        }

        private void SQLInsertGenre(Genres genre)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Genres.Add(genre);
                context.SaveChanges();
            }
        }

        private void SQLUpdateGenre(Genres genre)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Genres.AddOrUpdate(genre);
                context.SaveChanges();
            }
        }

        private void SQLDeleteGenre(int genreId)
        {
            using (var context = new MusicCollectionModel())
            {
                var genre = context.Genres.Include(g => g.Records).FirstOrDefault(a => a.GenreID == genreId);

                if (genre != null)
                {
                    var recordsToDelete = genre.Records.ToList();
                    context.Records.RemoveRange(recordsToDelete);
                    foreach (var record in recordsToDelete)
                        records.Remove(record);

                    context.Genres.Remove(genre);
                    context.SaveChanges();
                    genres.Remove(genre);
                }
            }
        }

        private void SQLInsertYear(Years year)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Years.Add(year);
                context.SaveChanges();
                years.Add(year);
            }
        }

        private void SQLUpdateYear(Years year)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Years.AddOrUpdate(year);
                context.SaveChanges();
            }
        }

        private void SQLDeleteYear(int yearId)
        {
            using (var context = new MusicCollectionModel())
            {
                var year = context.Years.Include(y => y.Records).FirstOrDefault(a => a.YearID == yearId);

                if (year != null)
                {
                    var recordsToDelete = year.Records.ToList();
                    context.Records.RemoveRange(recordsToDelete);
                    foreach (var record in recordsToDelete)
                        records.Remove(record);

                    context.Years.Remove(year);
                    context.SaveChanges();
                    years.Remove(year);
                }
            }
        }

        private void SQLInsertRecord(Records record)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Records.Add(record);
                context.SaveChanges();
                records.Add(record);
            }
        }

        private void SQLUpdateRecord(Records record)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Records.AddOrUpdate(record);
                context.SaveChanges();
            }
        }

        private void SQLDeleteRecord(int recordId)
        {
            using (var context = new MusicCollectionModel())
            {
                var record = context.Records.Find(recordId);
                if (record != null)
                {
                    context.Records.Remove(record);
                    context.SaveChanges();
                    records.Remove(record);
                }
            }
        }

        private void SQLInsertUser(Users user)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        private void SQLUpdateUser(Users user)
        {
            using (var context = new MusicCollectionModel())
            {
                context.Users.AddOrUpdate(user);
                context.SaveChanges();
                users.Add(user);
            }
        }

        private void SQLDeleteUser(int userId)
        {
            using (var context = new MusicCollectionModel())
            {
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                    users.Remove(user);
                }
            }
        }

        public Years findYear (string yearValue)
        {
            int.TryParse(yearValue, out int year);            

            using (var context = new MusicCollectionModel())
            {
                Years existingYear = context.Years.FirstOrDefault(y => y.YearValue == year);
                Years newYear;

                if (existingYear != null)
                    return existingYear;    

                newYear = new Years { YearValue = year };
                SQLInsertYear(newYear);
                return newYear;         
            }
            
        }
        public bool FillREcordFields(Records record)
        {
            try
            {
                record.Title = tbRecordName.Text;
                record.Artists = artists.FirstOrDefault(a => a.ArtistID == (int)cbbRecordGroup.SelectedValue);
                record.ArtistID = record.Artists.ArtistID;
                record.Artists = null;
                record.Publisher = tbRecordPublisher.Text;
                record.TracksCount = Int32.Parse(tbRecordTrackCount.Text);
                record.Genres = genres.FirstOrDefault(g => g.GenreID == (int)cbbRecordGenre.SelectedValue);
                record.GenreID = record.Genres.GenreID;
                record.Genres = null;
                record.Years = findYear(tbRecordYear.Text);
                record.YearID = record.Years.YearID;
                record.Years = null;
                record.Cost = Decimal.Parse(tbRecordCost.Text);
                record.SalePrice = Decimal.Parse(tbRecordSalePrice.Text);
                record.StockCount = Int32.Parse(tbRecordStockCount.Text);
                record.IsOnSale = chkRecordOnSale.Checked;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void AddRecord()
        {            
            Records newRecord = new Records();
            if (!FillREcordFields(newRecord))
                return;
            SQLInsertRecord(newRecord);
        }
        public void ModRecord()
        {
            if (!FillREcordFields(SelectedRecord))
                return;
            SQLUpdateRecord(SelectedRecord);
        }
        public void DelRecord()
        {
            SQLDeleteRecord(SelectedRecord.RecordID);
        }

        public void AddArtist()
        {
            Artists newArtist = new Artists { Name = tbArtistName.Text };
            SQLInsertArtist(newArtist);
        }
        public void ModArtist()
        {
            SelectedArtist.Name = tbArtistName.Text;
            SQLUpdateArtist(SelectedArtist);
        }
        public void DelArtist()
        {
            SQLDeleteArtist(SelectedArtist.ArtistID);
        }
        public void AddGenre()
        {
            Genres newGenre = new Genres { GenreName = tbGenreName.Text };
            SQLInsertGenre(newGenre);
        }
        public void ModGenre()
        {
            SelectedGenre.GenreName = tbGenreName.Text;
            SQLUpdateGenre(SelectedGenre);
        }
        public void DelGenre()
        {
            SQLDeleteGenre(SelectedGenre.GenreID);
        }
        public void AddUser()
        {
            var newUser = new Users { Username = tbUserName.Text, Password = tbUserPassword.Text, AccessLevel = chkUserAdmin.Checked ? 1 : 0 };
            SQLInsertUser(newUser);
        }
        public void ModUser()
        {
            SelectedUser.Username = tbUserName.Text;
            SelectedUser.Password = tbUserPassword.Text;
            SelectedUser.AccessLevel = chkUserAdmin.Checked ? 1 : 0;
            SQLUpdateUser(SelectedUser);
        }
        public void DelUser()
        {
            SQLDeleteUser(SelectedUser.UserID);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbpMain.SelectedTab == tbpRecord)
                AddRecord();
            else if (tbpMain.SelectedTab == tbpArtist)
                AddArtist();
            else if (tbpMain.SelectedTab == tbpGenre)
                AddGenre();
            else if (tbpMain.SelectedTab == tbpUser)
                AddUser();
            GetInfo();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (tbpMain.SelectedTab == tbpRecord)
                ModRecord();
            else if (tbpMain.SelectedTab == tbpArtist)
                ModArtist();
            else if (tbpMain.SelectedTab == tbpGenre)
                ModGenre();
            else if (tbpMain.SelectedTab == tbpUser)
                ModUser();
            GetInfo();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbpMain.SelectedTab == tbpRecord)
                DelRecord();
            else if (tbpMain.SelectedTab == tbpArtist)
                DelArtist();
            else if (tbpMain.SelectedTab == tbpGenre)
                DelGenre();
            else if (tbpMain.SelectedTab == tbpUser)
                DelUser();

            GetInfo();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (!FillREcordFields(SelectedRecord))
                return;
            if (SelectedRecord.StockCount > 1)
            {
                SelectedRecord.StockCount--;
                SQLUpdateRecord(SelectedRecord);
            }
            else if (SelectedRecord.StockCount >= 0) //1 или 0
            {
                DelRecord();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text; // Получаем текст для поиска из TextBox
            
            // Проверка выбранного элемента в ComboBox
            switch (cbbSearch.SelectedIndex)
            {
                case 0: // По названию
                {
                    var titleRecords = records
                    .Where(r => r.Title.Contains(searchText))
                    .ToList();
                    dgvMain.DataSource = titleRecords;
                    break;
                }

                case 1: // По исполнителю
                { 
                    var artistRecords = records
                        .Where(r => r.Artists != null && r.Artists.Name.Contains(searchText))
                        .ToList();
                    dgvMain.DataSource = artistRecords;
                    break;
                }

                case 2: // По жанру
                {
                    var genreRecords = records
                    .Where(r => r.Genres != null && r.Genres.GenreName.Contains(searchText))
                    .ToList();
                    dgvMain.DataSource = genreRecords;
                    break;
                }

                default:
                MessageBox.Show("Выберите критерий поиска."); // Если ничего не выбрано
                break;
            }
        }
    }
}
