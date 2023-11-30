namespace Interface_Proj
{
    public partial class IRegistrationForm1 : Form
    {
        public IRegistrationForm1()
        {
            InitializeComponent();
        }

        private void IProfessorBut1_Click(object sender, EventArgs e)
        {
            IRegistrationForm2 registration = new IRegistrationForm2();
            this.Hide();
            registration.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IAdminRegistrationForm adminreg = new IAdminRegistrationForm();
            this.Hide();
            adminreg.Show();
        }

        private void ICreatorsBut_Click(object sender, EventArgs e)
        {
            ICreatorsForm creators = new ICreatorsForm();
            this.Hide();
            creators.Show();
        }
    }
}