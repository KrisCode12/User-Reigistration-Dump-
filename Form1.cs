namespace usertegistration_app
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.StudentNo = Convert.ToInt64(tbStudentNo);
            StudentInfoClass.FirstName = tbFirstName.Text.ToString();
            StudentInfoClass.LastName = tbLastName.Text.ToString();
            StudentInfoClass.MiddleName = tbLastName.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(tbAge);
            StudentInfoClass.ContactNo = Convert.ToInt64(tbContactNo);
            StudentInfoClass.Address =tbAddress.Text.ToString();

            //Call
            Form2 form2 = new Form2();
            form2.ShowDialog();



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
public delegate long DelegateNumber(long num);
public delegate string DelegateText(string text);
class StudentInfoClass
 {
   

    public static string Program = " ";
    public static long StudentNo = 0;
    public static string FirstName = " ";
    public static string LastName = " ";
    public static string MiddleName = "";
    public static long Age = 0;
    public static long ContactNo = 0;
    public static string Address = " ";


    public static long getStudenNo(long StudentNo)
    {
        return StudentNo;
    }
    public static String getProgram(String Program)
    {
        return Program;
    }
    public static String getLastName(String LastName)
    {
        return LastName;
    }
    public static String getFirstName(String FirstName)
    {
        return FirstName;
    }
    public static String getMiddleName(String MiddleName)
    {
        return MiddleName;
    }
    public static long getAge(long Age)
    {
        return Age;
    }
    public static long getContactNo(long ContactNumber)
    {
        return ContactNumber;
    }
    public static string getAddress(string Address)
    {
        return Address;
    }

}
