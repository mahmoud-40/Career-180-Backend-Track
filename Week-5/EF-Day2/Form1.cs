using EF_Day2.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Day2
{
    public partial class Form1 : Form
    {
        BlogContext db = new BlogContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV.DataSource = db.News.Include(n => n.Author).ToList();
        }
    }
}