using System;
class User
{
	private string _name;
	private string _username;
	private string _password;
	private long _phoneNumber;
        public string Name{
            set{
                _name=value;
            }
            get{
                return _name;
            }
        }
        public string Username{
            set{
                _username=value;
            }
            get{
                return _username;
            }
        }
        public string Password{
            set{
                _password=value;
            }
            get{
                return _password;
            }
        }
        public long PhoneNumber{
            set{
                _phoneNumber=value;
            }
            get{
                return _phoneNumber;
            }
        }
        public User(){
            
        }
        public User(string n,string u,string p,long pn){
            this._name=n;
            this._username=u;
			this._password=p;
			this._phoneNumber=pn;
        }
	public bool ComparePhoneNumber(User user)
	{
		if (this._phoneNumber==user._phoneNumber)
			return true;
		else
			return false;
	}
}