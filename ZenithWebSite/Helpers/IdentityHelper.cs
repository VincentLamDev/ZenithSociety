using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZenithWebSite.Models;

namespace ZenithWebSite.Helpers
{
    public class IdentityHelper
    {
        internal static void SeedIdentities(ZenithWebSite.Models.ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));      
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists(RoleNames.ROLE_ADMINISTRATOR))       
            {     
                var roleresult = roleManager.Create(new IdentityRole(RoleNames.ROLE_ADMINISTRATOR));     
            }          
            if (!roleManager.RoleExists(RoleNames.ROLE_MEMBER))          
            {         
                var roleresult = roleManager.Create(new IdentityRole(RoleNames.ROLE_MEMBER));       
            }

            string adminUserName = "a";
            string adminEmail = "a@a.a";
            string password = "P@$$w0rd";

            ApplicationUser admin = userManager.FindByName(adminUserName);
            if (admin == null)
            {
                admin = new ApplicationUser()
                {
                    UserName = adminUserName,
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                IdentityResult userResult = userManager.Create(admin, password);
                if (userResult.Succeeded)
                {
                    var result = userManager.AddToRole(admin.Id, RoleNames.ROLE_ADMINISTRATOR);
                }
            }

            string memberUserName = "m";
            string memberEmail = "m@m.m";

            ApplicationUser member = userManager.FindByName(memberUserName);
            if (member == null)
            {
                member = new ApplicationUser()
                {
                    UserName = memberUserName,
                    Email = memberEmail,
                    EmailConfirmed = true
                };
                IdentityResult userResult = userManager.Create(member, password);
                if (userResult.Succeeded)
                {
                    var result = userManager.AddToRole(member.Id, RoleNames.ROLE_MEMBER);
                }
            }
        }
    }

}