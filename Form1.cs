using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Data.Entities;
using SchoolManagement.Data;

//using SchoolManagement.Data.Migrations;
using System.Data.Entity;

namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            SetupData();
        }


        BackgroundWorker bw;
        private void SetupData()
        {
            lblProcessing.Text = "Setting up data please wait...";

            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;

            bw.RunWorkerAsync();
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    if (!ctx.Teachers.Any())
                    {
                        var teachers = new List<Teacher>()
                        {
                            new Teacher()
                            {
                                Fname = "Anitha",
                                Classes = new List<Class>()
                                {
                                    new Class() {PeriodNo=1},
                                    new Class() {PeriodNo=2}
                                }
                            },

                            new Teacher()
                            {
                                Fname = "Ramesh",
                                Classes = new List<Class>()
                                {
                                    new Class() {PeriodNo=1},
                                    new Class() {PeriodNo=2}
                                }

                            }
                        };
                        ctx.Teachers.AddRange(teachers);
                    }

                    ctx.SaveChanges();
                    e.Result = "Ready!";
                }

            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProcessing.Text = e.Result.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new SchoolContext())
                {
                    var results = ctx.Teachers.SqlQuery("select * from teachers");
                    var name = results.FirstOrDefault()?.Fname ?? "NA";
                    MessageBox.Show(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



    }
}
