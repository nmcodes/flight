using System;
namespace api.Entities
{
    public class User
    {
        // public enum UserStatus { ADMIN, SIMPLE_CUSTOMER, ACCOUNT_CUSTOMER };
        public User(){}
        public long UserID { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public int age { set; get; }
        public string password { set; get; }
        public string email { set; get; }
        public string gender { set; get; }
        public string phoneNumber { set; get; }
        public string status { set; get; }
    }
}
