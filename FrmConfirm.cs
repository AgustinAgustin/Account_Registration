using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.StudentInfoClass;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            StudentNoDes.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            ProgramDes.Text = DelProgram(StudentInfoClass.Program);
            LastNameDes.Text = DelLastName(StudentInfoClass.LastName);
            FirstnameDes.Text = DelFirstName(StudentInfoClass.FirstName);
            MiddleNameDes.Text = DelMiddleName(StudentInfoClass.MiddleName);
            AgeDes.Text = DelNumAge(StudentInfoClass.Age).ToString();
            ContactNoDes.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            AddressDes.Text = DelAddress(StudentInfoClass.Address);
        }
    }
}
