using Lab05.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            reportViewer1.Visible = false;
        }

        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            StudentDB studentDB = new StudentDB();
            List<Student> students = studentDB.Student.ToList();
            List<ReportStudent> reportStudents = new List<ReportStudent>();
            foreach (var item in students)
            {
                ReportStudent reportStudent = new ReportStudent();

                reportStudent.studentID = item.StudentID;
                reportStudent.fullName = item.FullName;
                reportStudent.facultyName = item.Faculty.FacultyName;
                reportStudent.averageScore = Convert.ToDouble(item.AverageScore);

                reportStudents.Add(reportStudent);
            }
            reportViewer1.LocalReport.ReportPath = "./Report/ReportSV.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("StudentDataSet", reportStudents);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
