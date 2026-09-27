using System.Data;
using Microsoft.Data.SqlClient;
namespace umuta_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=localhost; Initial Catalog=umuta; Integrated Security=True; TrustServerCertificate=True");
        void listele()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TabStu", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        void temizle()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TabStu values(@name, @surname,@email)", conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            listele();
            temizle();
        }

        int id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from TabStu where Id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            conn.Close();
            listele();
            temizle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update TabStu set Name = @name, Surname = @surname, Email = @email where Id = @id", conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            listele();
            temizle();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TabStu where Name = @search", conn);
            cmd.Parameters.AddWithValue("@search", txtName.Text);

            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);

            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}