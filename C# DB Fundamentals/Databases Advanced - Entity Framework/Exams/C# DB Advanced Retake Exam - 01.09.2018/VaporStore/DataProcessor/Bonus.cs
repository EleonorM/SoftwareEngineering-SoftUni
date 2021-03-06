﻿namespace VaporStore.DataProcessor
{
    using Data;
    using System.Linq;

    public static class Bonus
    {
        public static string UpdateEmail(VaporStoreDbContext context, string username, string newEmail)
        {
            var user = context.Users.FirstOrDefault(x => x.Username == username);

            if (user == null)
            {
                return $"User {username} not found";
            }

            var userWithSameEmail = context.Users.FirstOrDefault(x => x.Email == newEmail);

            if (userWithSameEmail != null)
            {
                return $"Email {newEmail} is already taken";
            }


            user.Email = newEmail;
            context.SaveChanges();

            return $"Changed {username}'s email successfully";
        }
    }
}
