namespace DesktopApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenSorting_Click(object sender, EventArgs e)
        {
            SortingVisualizerForm sortingForm = new SortingVisualizerForm();
            sortingForm.Show();
        }

        private void btnOpenPathfinding_Click(object sender, EventArgs e)
        {
            PathfindingVisualizerForm pathfindingForm = new PathfindingVisualizerForm();
            pathfindingForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
