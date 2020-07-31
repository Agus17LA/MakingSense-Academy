using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones.Model
{
    public class UserCollection : ObservableCollection<User>
    {

    }
    public class User
    {
        private int id { get; set; }
        private String dni { get; set; }
        private String name { get; set; }
        private String surname { get; set; }
        private String username { get; set; }
        private String password { get; set; }
        private String userType { get; set; }
        private Boolean userStatus { get; set; }
        private int cityId { get; set; }
        public User(int id, string dni, string name, string surname, string username, string password, string userType, bool userStatus, int cityId)
        {
            this.id = id;
            this.dni = dni;
            this.name = name;
            this.surname = surname;
            this.username = username;
            this.password = password;
            this.userType = userType;
            this.userStatus = userStatus;
            this.cityId = cityId;
        }

    }
}
