using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai5
{
    public class Customer
    {
        private string Name;
        private int Age;
        private int Id;
        private DateTime CheckIn;
        private DateTime CheckOut;
        public void InputCustomer(string name, int age, int id){
            Name = name;
            Age = age;
            Id = id;
        }
        public Customer(DateTime checkin){
            CheckIn = checkin;
        }
        public Customer(){}
        public string GetName(){
            return Name;
        }
        public void SetName(string name){
            Name = name;
        }
        public int GetAge(){
            return Age;
        }
        public int GetId(){
            return Id;
        }
        public void OutputCustomer(){
            Console.WriteLine("Thong tin khach hang: ");
            Console.WriteLine("Ten : " + Name);
            Console.WriteLine("Tuoi : " + Age);
            Console.WriteLine("Id : " + Id);
        }
    }
}