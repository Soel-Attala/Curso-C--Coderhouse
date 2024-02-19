using Lesson_12_Scaffolding.database;
using Lesson_12_Scaffolding.models;
namespace Lesson_12_Scaffolding
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void DataLoad_Click(object sender, EventArgs e)
        {
            using (CoderContext database = new CoderContext())
            {
                List<User> users = database.Users.ToList();

                this.dgvList.DataSource = users;
            }
        }
    }
}