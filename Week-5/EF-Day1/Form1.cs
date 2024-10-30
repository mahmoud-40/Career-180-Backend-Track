using System.Runtime.InteropServices.JavaScript;
using EF_Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Day1
{
    public partial class Form1 : Form
    {
        TeamContext db = new TeamContext();
        private int _Id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV_Players.DataSource = db.Players.ToList();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Player player = new Player()
            {
                Name = tb_name.Text,
                Nationality = tb_nationalty.Text,
                Position = tb_position.Text,
                Goals = int.Parse(tb_goals.Text),
                Matches = int.Parse(tb_games.Text),
                Number = int.Parse(tb_number.Text),
                Salary = int.Parse(tb_salary.Text),
                RedCards = int.Parse(tb_redcards.Text),
                YellowCards = int.Parse(tb_yellowcards.Text)
            };

            db.Players.Add(player);
            db.SaveChanges();
            DGV_Players.DataSource = db.Players.ToList();

            MessageBox.Show("Player Added Successfully");

            tb_name.Text = tb_goals.Text = tb_games.Text = tb_nationalty.Text = tb_number.Text = tb_position.Text = tb_redcards.Text = tb_salary.Text = tb_yellowcards.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Player player = db.Players.Where(p => p.id == _Id).FirstOrDefault();
            player.Name = tb_name.Text;
            player.Nationality = tb_nationalty.Text;
            player.Position = tb_position.Text;
            player.Goals = int.Parse(tb_goals.Text);
            player.Matches = int.Parse(tb_games.Text);
            player.Number = int.Parse(tb_number.Text);
            player.Salary = int.Parse(tb_salary.Text);
            player.RedCards = int.Parse(tb_redcards.Text);
            player.YellowCards = int.Parse(tb_yellowcards.Text);

            db.SaveChanges();
            DGV_Players.DataSource = db.Players.ToList();

            MessageBox.Show("Player Updated Successfully");

            tb_name.Text = tb_goals.Text = tb_games.Text = tb_nationalty.Text = tb_number.Text = tb_position.Text = tb_redcards.Text = tb_salary.Text = tb_yellowcards.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Player player = db.Players.Where(p => p.id == _Id).FirstOrDefault();
            db.Players.Remove(player);
            db.SaveChanges();
            DGV_Players.DataSource = db.Players.ToList();

            MessageBox.Show("Player Deleted Successfully");

            tb_name.Text = tb_goals.Text = tb_games.Text = tb_nationalty.Text = tb_number.Text = tb_position.Text = tb_redcards.Text = tb_salary.Text = tb_yellowcards.Text = "";
        }

        private void DGV_Players_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _Id = Convert.ToInt32(DGV_Players.Rows[e.RowIndex].Cells[0].Value.ToString());
            Player player = db.Players.Where(p => p.id == _Id).FirstOrDefault();
            tb_name.Text = player.Name;
            tb_nationalty.Text = player.Nationality;
            tb_position.Text = player.Position;
            tb_goals.Text = player.Goals.ToString();
            tb_games.Text = player.Matches.ToString();
            tb_number.Text = player.Number.ToString();
            tb_salary.Text = player.Salary.ToString();
            tb_redcards.Text = player.RedCards.ToString();
            tb_yellowcards.Text = player.YellowCards.ToString();
        }
    }
}
