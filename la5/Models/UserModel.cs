namespace la5.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RoleModelID { get; set; }
        public RoleModel RoleModel { get; set; }

    }
}
