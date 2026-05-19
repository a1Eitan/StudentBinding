using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
    public class Student : ObservableObject
    {
        private string image;
        private string name;
        private int age;
        private DateTime birthDate;
        private string email;
        private string phoneNumber;

        public string Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged(nameof(Image)); }
        }
        public string Name { 
            get { return name; } 
            set { name = value;  OnPropertyChanged(nameof(Name)); } 
        }
        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged(nameof(Age)); }
        }
        public DateTime BirthDate { 
            get { return birthDate; } 
            set { birthDate = value; OnPropertyChanged(nameof(BirthDate)); }
        }
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; OnPropertyChanged(nameof(PhoneNumber)); }
        }

        public Student(string image, string name, int age, DateTime birthDate, string email, string phoneNumber)
        {
            this.image = image;
            this.name = name;
            this.age = age;
            this.birthDate = birthDate;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
    }
}
