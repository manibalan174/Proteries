using System;

namespace proteries
{
    class Program
    {
        private string _Name;
        private  int _Mark;
        public void setame(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name is NUll Or Empty");
            }
            this._Name = Name;
        }
        public string getName()
        {
            return  this._Name;
        }

        public void setMark(int Mark)
        {
            if( Mark < 0 || Mark > 100)
            {
                throw new Exception("Invalid Mark");
            }
            this._Mark = Mark;
        }
        public int getMark()
        {
            return this._Mark;
        }
       
    }
    public class TestEmployee{
       static void Main(string[] args)
        {
            Console.WriteLine("Old Method Of Proteries");
            Program p = new Program();
            p.setame("Stalin");
            p.setMark(20);
            Console.WriteLine("Student Name : {0} \n Student Mark : {1}",p.getName(),p.getMark());
        }
    }
}
