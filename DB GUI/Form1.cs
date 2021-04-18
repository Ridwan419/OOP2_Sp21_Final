﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace DB_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //do validation
            //Insert data into Database
            string cname = tbCName.Text;
            string ccode = tbCCode.Text;

            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            string query = string.Format("insert into courses values ('{0}','{1}')",cname,ccode);
            try 
            {
                  SqlCommand cmd = new SqlCommand(query, conn);
                  int row = cmd.ExecuteNonQuery();
                   if(row > 0)
                   {
                     MessageBox.Show("Course Inserted");
                   }
                   else
                   {
                     MessageBox.Show("Failed to insert Course");
                   }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            conn.Close();
            RefreshControls(); //To Refresh the Form after Inserted values
            //When we click in the Add button at a time Data is inserted and also Loaded
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }

        //When click the Load button all the data load in the box from database
        private void LoadData_Click(object sender, EventArgs e)
        {

            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }

        //Data Retrieve functionality from Database
        List<Course> GetAllCourses()
        {
            var conn = Database.ConnectDB();
            List<Course> courses = new List<Course>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from courses";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course c = new Course();
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                    courses.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
            return courses;
        }

        //When we just run/Refresh the From Data is Automatically Loaded from Database
        private void Form1_Load(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }

        void RefreshControls() // Refresh function to blank the Form after Inserted values
        {
            tbCCode.Text = "";
            tbCName.Text = "";
        }

        private void BtnSearch_Click(object sender, EventArgs e) //For search course
        {
            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int id = Int32.Parse(tbSrchCId.Text);
            string query = "select * from courses where id = "+id;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Course c = new Course();
            while (reader.Read())
            {
                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
            }
            conn.Close();

            tbCCodeUpdate.Text = c.CourseCode;
            tbCnameUpdate.Text = c.CourseName; 

        }

        private void BtnUpdate_Click(object sender, EventArgs e) //Update the course info
        {
            int id = Int32.Parse(tbSrchCId.Text);
            string cCode = tbCCodeUpdate.Text.Trim();
            string cName = tbCnameUpdate.Text;

            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = string.Format("update courses set CourseName='{0}', CourseCode='{1}' where id={2}", cName, cCode, id);

            SqlCommand cmd = new SqlCommand(query, conn);
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }
    }
    
}
