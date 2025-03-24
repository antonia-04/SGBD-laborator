using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;


namespace SGBD___laborator_1
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource bsParent = new BindingSource();
        BindingSource bsChild = new BindingSource();
        //string connectionString = @"DESKTOP-B9HP8D2\SQLEXPRESS;Database=BookStore;Integrated Security=true;TrustServerCertificate=true;";
        string connectionString = @"Server=DESKTOP-B9HP8D2\SQLEXPRESS;Database=BookStore;
        Integrated Security=true;TrustServerCertificate=true";


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM Author;", con);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Book;", con);

                    parentAdapter.Fill(ds, "Author");
                    MessageBox.Show($"S-au încărcat {ds.Tables["Author"].Rows.Count} autori");

                    childAdapter.Fill(ds, "Book");


                    DataColumn pkColumn = ds.Tables["Author"].Columns["idAuthor"];
                    DataColumn fkColumn = ds.Tables["Book"].Columns["idAuthor"];
                    DataRelation relation = new DataRelation("FK_Author_Book", pkColumn, fkColumn, true);
                    ds.Relations.Add(relation);

                    bsParent.DataSource = ds.Tables["Author"];
                    dataGridViewParent.DataSource = bsParent;

                    bsChild.DataSource = bsParent;
                    bsChild.DataMember = "FK_Author_Book";
                    dataGridViewChild.DataSource = bsChild;

                    // Afișăm numele autorului selectat în textBox
                    textBox1.DataBindings.Add("Text", bsParent, "name", true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    /* daca lucram doar cu SqlDataAdapters, putem omite deschiderea conexiunii, deoarece acest tip
                     * de obiect deschide si inchide apoi automat conexiunea
                     */
                    parentAdapter.SelectCommand.Connection = con;
                    childAdapter.SelectCommand.Connection = con;
                    if (ds.Tables.Contains("Book"))
                    {
                        ds.Tables["Book"].Clear();

                    }
                    if (ds.Tables.Contains("Author"))
                    {
                        ds.Tables["Author"].Clear();
                    }
                    parentAdapter.Fill(ds, "Author");
                    childAdapter.Fill(ds, "Book");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bsChild_CurrentChanged(object sender, EventArgs e)
        {
            if (bsChild.Current != null)
            {
                DataRowView selectedBook = (DataRowView)bsChild.Current;
                if (selectedBook.DataView.Table.Columns.Contains("title"))
                    textBoxTitle.Text = selectedBook["title"].ToString();
                if (selectedBook.DataView.Table.Columns.Contains("price"))
                    textBoxPrice.Text = selectedBook["price"].ToString();
                if (selectedBook.DataView.Table.Columns.Contains("year"))
                    textBoxYear.Text = selectedBook["year"].ToString();
                if (selectedBook.DataView.Table.Columns.Contains("idPublisher"))
                    textBoxIdPublisher.Text = selectedBook["idPublisher"].ToString();
                if (selectedBook.DataView.Table.Columns.Contains("idProvider"))
                    textBoxIdProvider.Text = selectedBook["idProvider"].ToString();
            }
            else
            {
                textBoxTitle.Clear();
                textBoxPrice.Clear();
                textBoxYear.Clear();
                textBoxIdPublisher.Clear();
                textBoxIdProvider.Clear();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (bsParent.Current == null)
            {
                MessageBox.Show("Selectați un autor înainte de a adăuga o carte.");
                return;
            }

            int authorId = (int)((DataRowView)bsParent.Current)["idAuthor"];
            string title = textBoxTitle.Text.Trim();
            decimal price;
            int year, publisherId, providerId;

            if (!decimal.TryParse(textBoxPrice.Text, out price) ||
                !int.TryParse(textBoxYear.Text, out year) ||
                !int.TryParse(textBoxIdPublisher.Text, out publisherId) ||
                !int.TryParse(textBoxIdProvider.Text, out providerId))
            {
                MessageBox.Show("Date invalide! Verificați valorile introduse.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmdMax = new SqlCommand("SELECT MAX(isbn) FROM Book", con);
                    object result = cmdMax.ExecuteScalar();
                    int newISBN = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1; // Dacă nu există, începe de la 1

                    SqlCommand cmd = new SqlCommand("INSERT INTO Book (isbn, title, price, year, idAuthor, idPublisher, idProvider) VALUES (@isbn, @title, @price, @year, @idAuthor, @idPublisher, @idProvider)", con);

                    cmd.Parameters.AddWithValue("@isbn", newISBN);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@idAuthor", authorId);
                    cmd.Parameters.AddWithValue("@idPublisher", publisherId);
                    cmd.Parameters.AddWithValue("@idProvider", providerId);
                    cmd.ExecuteNonQuery();
                }

                button1_Click_1(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (bsChild.Current == null)
            {
                MessageBox.Show("Selectați o carte înainte de a o actualiza.");
                return;
            }

            DataRowView selectedBook = (DataRowView)bsChild.Current;
            int bookId = (int)selectedBook["isbn"];
            string title = textBoxTitle.Text.Trim();
            decimal price;
            int year, publisherId, providerId;

            if (!decimal.TryParse(textBoxPrice.Text, out price) ||
                !int.TryParse(textBoxYear.Text, out year) ||
                !int.TryParse(textBoxIdPublisher.Text, out publisherId) ||
                !int.TryParse(textBoxIdProvider.Text, out providerId))
            {
                MessageBox.Show("Date invalide! Verificați valorile introduse.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Book SET title = @title, price = @price, year = @year, idPublisher = @idPublisher, idProvider = @idProvider WHERE isbn = @isbn", con);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@idPublisher", publisherId);
                    cmd.Parameters.AddWithValue("@idProvider", providerId);
                    cmd.Parameters.AddWithValue("@isbn", bookId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cartea a fost actualizată!");
                button1_Click_1(null, null); // Reîncarcă datele
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (bsChild.Current == null)
            {
                MessageBox.Show("Selectați o carte înainte de a o șterge.");
                return;
            }

            DataRowView selectedBook = (DataRowView)bsChild.Current;
            int bookId = (int)selectedBook["isbn"];

            DialogResult result = MessageBox.Show("Sigur doriți să ștergeți această carte?", "Confirmare", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Book WHERE isbn = @isbn", con);
                    cmd.Parameters.AddWithValue("@isbn", bookId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cartea a fost ștearsă!");
                button1_Click_1(null, null); // Reîncarcă datele
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }
}
