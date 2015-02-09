using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JessesHockeyShop.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JessesHockeyShop.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            // Access the application context and create result variables.
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            // Create a RoleStore object by using the ApplicationDbContext object. 
            // The RoleStore is only allowed to contain IdentityRole objects.
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects.
            // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object. 
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            // Then, you create the "canEdit" role if it doesn't already exist.
            if (!roleMgr.RoleExists("Admin"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "Admin" });
            }

            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "admin@JessesHockeyShop.com",
                Email = "admin@JessesHockeyShop.com"
            };
            IdUserResult = userMgr.Create(appUser, "P@ssword123");

            // If the new "canEdit" user was successfully created, 
            // add the "canEdit" user to the "canEdit" role. 
            if (!userMgr.IsInRole(userMgr.FindByEmail("admin@JessesHockeyShop.com").Id, "admin"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("admin@JessesHockeyShop.com").Id, "admin");
            }
        }
    }
}