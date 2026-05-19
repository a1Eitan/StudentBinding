using StudentBinding.Models;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        private Student currentStudent;
        private Student s1;
        private Student s2;

        public Student CurrentStudent
        {
            get { return currentStudent; }
            set { currentStudent = value; OnPropertyChanged(nameof(currentStudent)); }
        }
        public MainPage()
        {
            InitializeComponent();

            s1 = new Student("daniel.png", "daniel", 17, new DateTime(2009, 9, 1), "daniel@gmail.com", "0546973990");
            s2 = new Student("noa.png", "noa", 16, new DateTime(2009, 8, 14), "noa@gmail.com", "0507200927");

            CurrentStudent = s1;
            editDate.Date = CurrentStudent.BirthDate;
            this.BindingContext = CurrentStudent;
        }

        private void ChangeStudent_Clicked(Object sender, EventArgs e)
        {
            if (CurrentStudent == s1)
            {
                CurrentStudent = s2;
                editDate.Date = CurrentStudent.BirthDate;
                this.BindingContext = CurrentStudent;
            }
            else
            {
                CurrentStudent = s1;
                editDate.Date= CurrentStudent.BirthDate;
                this.BindingContext = CurrentStudent;
            }
        }

        private void UpdateDate_Clicked(object sender, EventArgs e)
        {
            CurrentStudent.BirthDate = editDate.Date;
            this.BindingContext = null;
            this.BindingContext = CurrentStudent;
        }
    }
}
