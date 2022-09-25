using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Encapsulation_Exercise_01
{
    class Program
    {
        #region// TODO: Create a Personally Identifiable Information class (Name is PII_Info)
        // TODO: Create 4 private fields
        // TODO: Create 4 public methods to get (read) those fields
        // TODO: Create 4 public methods to set (write) those fields

        // TODO: Create 2 private auto-implemented properties 
        // TODO: Creaet 1 method called SetInfo() which sets the private properties
        // TODO: Create 1 method called InformationReport() which creatively displays the 2 private properties 

        // BONUS
        // TODO: Create 1 private readonly field called _secret of type string
        // Thought Experiment: How can you initialize this field with a value?
        // Answer Here:  
        // TODO: Assign a value to the _secret field

        #endregion
        class PII_Info
        {
            private int _userId;
            private string _privateKey;
            private decimal _wallet;
            private bool _isAuthenticated;

            private string UserName { get; set; }
            private string Password { get; set; }   


            public int GetUserId()
            {
                return _userId;
            }

            public string GetKey()
            {
                return _privateKey;
            }
            public decimal Amount()
            {
                return _wallet;
            }
            public bool Authenticate()
            {
                return _isAuthenticated;
            }


            public void UserId(int userID)
            {
                _userId = userID;
            }
            public void PrivateKey(string key)
            {
                _privateKey = key;
            }
            public void Wallet(decimal wallet)
            {
                _wallet = wallet;
            }
            public void IsAuthenticated(bool authenticate)
            {
                _isAuthenticated = authenticate;
            }

            public void SetInfo(string username, string password)
            {
                UserName = username;
                Password = password;    
            }
            private readonly string _secret;

            public PII_Info(string secret)
            {
                _secret = secret;   
            }
            private void InformationReport()
            {
                Console.WriteLine($"Username: {UserName}\n" +
                    $"Password: {Password}\n" +
                    $"User ID: {_userId}\n" +
                    $"Private Key: {_privateKey}\n" +
                    $"Wallet: {string.Format(_wallet.ToString())}\n" +
                    $"Is Authenticated: {_isAuthenticated}\n\n" +
                    $"Secret: {_secret}\n");
                    Console.WriteLine();
                Console.WriteLine();
            }
            
        }



        #region// TODO: Create a FULL PROPERTY by using the code snippet: type propfull and then press tab twice (propfull + tab + tab)

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        #endregion

        static void Main(string[] args)
        {
            // Thought Experiment: Will the following code work or cause a compiler error?
            // Console.WriteLine(myVar); 
            // Answer Here: It will cause an error because the myVar field has been encapsulated by the private access modifier



            // Thought Experiment: How would you access the private myVar variable and print it out to the console?
            // TODO:  
            // Why: ? 



            // TODO: Create an instance of the PII_Info class


        }
    }
}
