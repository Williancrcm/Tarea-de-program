using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica0709
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btfill_Click(object sender, EventArgs e)
        {
            dgdata.Columns.Add("IDstudent", "CODIGO");
            dgdata.Columns.Add("firstname", "NOMBRE");
            dgdata.Columns.Add("lastname", "APELLIDO");
            dgdata.Columns.Add("age", "AÑO");
            dgdata.Columns.Add("gender", "GENERO");

            foreach (var student in selectAllData())
            {
                dgdata.Rows.Add(student.IDstudent, student.firstname, student.lastname,
                    student.age, student.gender);
            }
        }
            private List<Student> selectAllData()
            {
                List<Student> result = ( from student in Student.GetStudents()
                                        select new Student ()
                                        {
                                            IDstudent = student.IDstudent,
                                            firstname = student.firstname,
                                            lastname = student.lastname,
                                            age = student.age,
                                            gender = student.gender
                                        }
                    ).ToList() ;

                return result;
     
            }

    }
}
