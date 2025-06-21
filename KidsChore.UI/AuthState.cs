using KidsChore.Domain.Entities;

namespace KidsChore.UI
{
    public static class AuthState
    {
        public static User? CurrentUser { get; set; }
        public static void Logout() => CurrentUser = null;
    }
} 