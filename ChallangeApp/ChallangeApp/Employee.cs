using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{
    internal class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        private List<int> Score = new List<int>();
        public int ScoreSum
        {
            get
            {
                return Score.Sum();
            }
        }

        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void AddScore(int score)
        {
            Score.Add(score);
        }
    }
}
