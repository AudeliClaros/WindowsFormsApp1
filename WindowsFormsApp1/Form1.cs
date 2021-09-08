using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
        private void btnFill_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstname", "NOMBRE");
            dgData.Columns.Add("lastname", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("genero", "GENERO");


            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idstudent, student.firstname, student.lastname,
                student.age, student.genero);

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<Student> selectAllData()
        {
            List<Student> result = (
                                   from student in Student.GetStudents()
                                   select new Student()
                                   {
                                       idstudent = student.idstudent,
                                       firstname = student.firstname,
                                       lastname = student.lastname,
                                       age = student.age,
                                       genero = student.genero
                                   }
                                    
                                   

                ).ToList();

            return result;

        }

       
    }
}
