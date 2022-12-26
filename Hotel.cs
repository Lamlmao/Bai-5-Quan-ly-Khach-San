using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai5
{
    public class Hotel
    {
        private int Price;
        private int Prize;
        private int Day;
        private char Room;
        private DateTime CheckIn;
        private DateTime CheckOut;
        private Customer[] Customers;
        public void InputForCustomer(Customer[] customers){
            Customers = customers;
        }
        public void Input(DateTime checkin, DateTime checkout, char room){
            CheckIn = checkin;
            CheckOut = checkout;
            Room = room;
        }
        public void RoomPrize(char room){
            if(room == 'A'){
                Prize = 500;
            }
            else if(room == 'B'){
                Prize = 300;
            }
            else if(room == 'C'){
                Prize = 100;
            }
            else return;
        }

        public Hotel()
        {
        }

        public int GetDay(){
            int day = CheckOut.Day - CheckIn.Day; 
            return day;
        }
        public int GetPrice(){
            Price = Prize * GetDay();
            return Price;
        }
        public void Output(){
            Console.WriteLine("Thoi gian su dung phong: " + " " + CheckIn + " -> " + CheckOut);
            Console.WriteLine("Price: " + Price);
            for(int j = 0; j < Customers.Length; j++){
                Customers[j].OutputCustomer();
            }
        }
    }
}