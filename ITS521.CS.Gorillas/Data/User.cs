using Microsoft.EntityFrameworkCore;

namespace ITS521.CS.Gorillas.Data {
    class UserContext : DbContext {
        DbSet<User> Users { get; set; }
    }

    class User {

    }
}
