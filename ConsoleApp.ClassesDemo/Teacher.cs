using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = "TCH-" + GetRandomNumber();
        }
    }
}