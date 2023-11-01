namespace Interface_Proj
{
    public partial class IRegistrationForm1 : Form
    {
        public IRegistrationForm1()
        {
            InitializeComponent();
        }

        private void IStudentBut1_Click(object sender, EventArgs e)
        {
            IRegistrationForm2 registration = new IRegistrationForm2();
            this.Hide();
            registration.Show();
        }

        private void IProfessorBut1_Click(object sender, EventArgs e)
        {
            IRegistrationForm2 registration = new IRegistrationForm2();
            this.Hide();
            registration.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IAdministratorForm1 admin = new IAdministratorForm1();
            this.Hide();
            admin.Show();
        }

        private void IRegistrationForm1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}