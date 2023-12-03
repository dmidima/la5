using la5.Models;

namespace la5.Models
{
    public class RoleModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public List<UserModel> Users { get; set; }
        public RoleModel()
        {
            Users = new List<UserModel>();
        }
    }
}
