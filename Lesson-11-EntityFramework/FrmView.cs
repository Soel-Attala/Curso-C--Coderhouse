using Lesson_11_EntityFramework.database;
using Lesson_11_EntityFramework.models;

namespace Lesson_11_EntityFramework
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {

        }

        private void btnDataLoad_Click(object sender, EventArgs e)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                List<Product> products = context.Products.ToList();

                this.dvgProducts.DataSource = products;
            }
        }
    }
}