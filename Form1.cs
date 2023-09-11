namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Int64.Parse(StudentDesign.Text);
            StudentInfoClass.Program = ProgramDesign.Text;
            StudentInfoClass.LastName = LastNameDesign.Text;
            StudentInfoClass.FirstName = FirstNameDesign.Text;
            StudentInfoClass.MiddleName = MiddleNameDesign.Text;
            StudentInfoClass.Age = Int64.Parse(AgeDesign.Text);
            StudentInfoClass.ContactNo = Int64.Parse(ContactNoDesign.Text);
            StudentInfoClass.Address = AddressDesign.Text;
            FrmConfirm compirm = new FrmConfirm();

            compirm.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}