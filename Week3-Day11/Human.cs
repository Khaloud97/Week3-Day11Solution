

namespace Week3_Day11
{
    internal class Human
    {
        public static int cnt;
        private int id;
        public string name;
        public int age;
        public string address;
        private string email;
       //public string email;
        public Human()
        {
            
        }

        public Human(string name,int age, string address, string email)
        {
            //what hapend inside function stay inside function
            cnt += 1;
            this.name = name;   
            this.age = ValidetAge(age) ? age : 0;// if age is true is number will retuern age but if Validet of this Age is false will return 0 
            this.address = address;
            this.email = email;
            this.id = cnt;
        }

        //get function to id read only 
        public int GetID(int id) {

            return this.id;
        }

        //get function to read email  only 
        public string GetEmail(string email)
        {

            return this.email;
        }
        //set function to do change i can add on it
        public void SetEmail(string email)
        {
            this.email = email;
        }
        //Write get id as a body Expression Method
       // public string GetEmail(string email)=> this.email;


        // In this function i will chack what the user enter in the age input if write  0 or less And if >100 
        public bool ValidetAge(int age)
        {
            if (age <= 0 || age >=100) {
                return false;
            
            }
            return true;
        }

        //body Expression Method
        public string GreetingByName() => $"Hello {this.name} ,{this.age} ,from {this.address} , your email: {this.email}";
    }
}
