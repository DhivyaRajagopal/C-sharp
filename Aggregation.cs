//Aggregation 

//Code reusability is achieved.

using System;
namespace Aggregation
{
   public class Address
    {
        public int str_no;
        public string st_name;
        public string city;
        public Address(int str_no,string st_name,string city)
        {
            this.str_no = str_no;
            this.st_name = st_name;
            this.city = city;
        }
    }
    public class Employee
    {
        public int e_id;
        public string e_name;
        public Address add;
        public Employee(int e_id,string e_name,Address add)
        {
            this.e_id = e_id;
            this.e_name = e_name;
            this.add = add;
        }
        public void emp_details()
        {
            Console.WriteLine("id:" + e_id +" name:" + e_name + " street_no:" + add.str_no+" street name:"+add.st_name+" city:"+add.city);
        }
        public static void Main(string[] args)
        {
            Address add1 = new Address(01,"kg","kovai");
            Employee emp = new Employee(20, "xyz",add1);
            emp.emp_details();
            Console.ReadKey();
    
        }
    }
}
