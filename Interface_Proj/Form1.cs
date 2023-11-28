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
            //IProfessorForm1 form = new IProfessorForm1();
            //this.Hide();
            //form.Show();
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

        private void ICreatorsBut_Click(object sender, EventArgs e)
        {
            ICreatorsForm creators = new ICreatorsForm();
            this.Hide();
            creators.Show();
        }
    }
}