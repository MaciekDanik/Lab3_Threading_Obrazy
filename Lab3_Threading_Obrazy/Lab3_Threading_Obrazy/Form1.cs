namespace Lab3_Threading_Obrazy
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_Matrix_Click(object sender, EventArgs e)
        {
            MatrixForm matrixForm = new MatrixForm();
            this.Hide();
            matrixForm.ShowDialog();
            this.Close();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_imgProcessing_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm();
            this.Hide();
            imageForm.ShowDialog();
            this.Close();
        }
    }
}
