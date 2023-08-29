using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWorkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                employeeInfoTbl employee = new employeeInfoTbl
                {
                    dateOfEmployment = DateTime.Now.ToString(),
                    otherNames = "Ken",
                    surName="Greg",
                    department="Mechanical",
                    role="HOD"

                };
                using (MyDBContext context=new MyDBContext())
                {
                    context.employeeInfo.Add(employee);
                    context.SaveChanges();
                    MessageBox.Show("Saved Successfully");

                }


            }
            catch (Exception ex)
            {

            
            }
        }

        private void bttnRead_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {

               // context.employeeInfo.
               // MessageBox.Show("Saved Successfully");

            }
        }
    }
}
