using System;
class Customer {
        //Fill your code
		private string _customerName,_customerEmail,_customerType,_customerAddress;
        public string CustomerName{
            set{
                _customerName=value;
            }
            get{
                return _customerName;
            }
        }
        public string CustomerEmail{
            set{
                _customerEmail=value;
            }
            get{
                return _customerEmail;
            }
        }
        public string CustomerType{
            set{
                _customerType=value;
            }
            get{
                return _customerType;
            }
        }
        public string CustomerAddress{
            set{
                _customerAddress=value;
            }
            get{
                return _customerAddress;
            }
        }
        public Customer(){
            
        }
        public Customer (string _customerName,string _customerEmail,string _customerType,string _customerAddress){
            this._customerName=_customerName;
            this._customerEmail=_customerEmail;
            this._customerType=_customerType;
            this._customerAddress=_customerAddress;
        }
        public void DisplayDetails(){
            Console.WriteLine("Customer Details");
            Console.WriteLine("Name: "+_customerName);
            Console.WriteLine("E-mail: "+_customerEmail);
            Console.WriteLine("Type: "+_customerType);
            Console.WriteLine("Location: "+_customerAddress);
        }

 

}