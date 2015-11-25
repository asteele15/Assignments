using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    class Person
    {
        private string firstname;
        private string lastname;
        private string address;
        private string fullname;
        private string phonenumber;

        public Person(string first, string last, string full, string street, string phone)
        {
            firstname = first;
            lastname = last;
            address = street;
            phonenumber = phone;
            fullname = first + " " + last;

        }

        public string FirstName
        {
            get
            {
                return firstname;
            }//end get
        }//end FirstName

        public string LastName
        {
            get
            {
                return lastname;
            }//end get
        }//end LastName

        public string Address
        {
            get
            {
                return address;
            }//end get
        }//end Address

        public string PhoneNumber
        {
            get
            {
                return phonenumber;
            }//end get
        }//end Phone number



           

        static void Main(string[] args)
        {
            

        }//end main
    }//end class

    public class Student : Person
    {
        private int GPA;
        private string major;
        private string graddate;

        public Student(string first, string last, string full, string street, string phone,
            int gpa, string type, string date)
            : base(first, last, full, street, phone)
        {
            GPA = gpa;
            major = type;
            graddate = date;
        }//end student

    

    public string displayStudentInfo() 
    { 
    string studentInfo = GPA + " " + major + " " + graddate;
    return studentInfo;
    }//end display of student information

    public int Gpa(int gradeA, int gradeB, int gradeC)
    {
        int GPA = (gradeA + gradeB + gradeC) / 3;
        return GPA;
    }//Gpa



}//end student

    public class Employees : Person
    {
        private string ID;
        private string department;

    public Employees(string first, string last, string full, string street, string phone,
            string id, string dept) 
        : base( first, last, full, street, phone ) 
    {
        ID = id;
        department = dept;
    }

    public string EmployeeInfo()
    {
        string EmployeeInfo = ID + " " + department;
        return EmployeeInfo;
    }//end employee info



    }//end employees

    public class Instructors : Employees
    {
        private string officephone;
        private string officehours;

        public Instructors(string first, string last, string full, string street, string phone,
            string id, string dept, string ophone, string ohours) 
        : base( first, last, full, street, phone, id, dept ) 
    {
        officephone = ophone;
        officehours = ohours;

    }

        public string IInfo()
        {
            string InstructorInfo = officehours + " " + officephone;
            return InstructorInfo;
        }//end instructor information

    }//end instructors

}//end namespace

