using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows;

namespace StudentGradeManager
{
    public sealed partial class MainPage : Page
    {
        private List<Student> students;

        public MainPage()
        {
            this.InitializeComponent();
            students = new List<Student>();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            string studentID = StudentID.Text;
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string className = ClassName.Text;
            string grade = Grade.Text;

            Student newStudent = new Student(studentID, firstName, lastName, className, grade);
            students.Add(newStudent);

            StudentID.Text = FirstName.Text = LastName.Text = ClassName.Text = Grade.Text = "";

            StudentListBox.Items.Add(newStudent.ToString());
        }

        private async void SaveGrades_Click(object sender, RoutedEventArgs e)
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.Desktop;
            save
