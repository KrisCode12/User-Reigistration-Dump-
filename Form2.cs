using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usertegistration_app
{
    public partial class Form2 : Form1 
    {
       private DelegateNumber DelnumAge, DelnumContacNo, DelnumStudentNo;
       private  DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        public Form2()
        {
            InitializeComponent();
            
            //DelegateText//
            DelProgram = new DelegateText(StudentInfoClass.getProgram);
            DelLastName = new DelegateText(StudentInfoClass.getLastName);
            DelFirstName = new DelegateText(StudentInfoClass.getFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.getMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.getAddress);
            //DelegateNumber//
            DelnumAge = new DelegateNumber(StudentInfoClass.getAge);
            DelnumStudentNo = new DelegateNumber(StudentInfoClass.getStudenNo);
           DelnumContacNo = new DelegateNumber(StudentInfoClass.getContactNo);
        
 }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void L2Studno_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void l2Fname_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

   
}
