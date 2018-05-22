using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;
using System.Web;
using Placovu.Erp.Core.EntityModel;
using Microsoft.Owin.Extensions;
using Placovu.Erp.Core.Extensions;


namespace Placovu.Erp.Core.Security.Models
{
    public class ApplicationUserRole : IdentityUserRole<string> { }
    public class ApplicationUserClaim : IdentityUserClaim<string> { }
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string UserNameDisplay { get; set; }
        public long? PracticeProfileId { get; set; }
        public long? PatientProfileId { get; set; }
        public bool IsSystemAdmin { get; set; }
        public bool IsDeleted { get; set; }
        public string UserLocalTimeZone { get; set; }
        public string UserUtcTimeZoneOffset { get; set; }
        public string PracticeProfileName { get; set; }
        public Guid? LastLoginId { get; set; }


        //public string PracticeProfileName { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            var defaultUtcTimeZoneOffset = ApplicationDbContext.Create().ApplicationSettings.First();
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("UserId", this.Id));
            userIdentity.AddClaim(new Claim(ClaimTypes.GivenName, this.UserNameDisplay.ToString()));
            userIdentity.AddClaim(new Claim("PracticeProfileId", this.PracticeProfileId == null ? "" : this.PracticeProfileId.ToString()));
            userIdentity.AddClaim(new Claim("PracticeProfileName", PracticeProfileName?.ToString() ?? ""));
            userIdentity.AddClaim(new Claim("PatientProfileId", this.PatientProfileId == null ? "" : this.PatientProfileId.ToString()));
            userIdentity.AddClaim(new Claim("IsSystemAdmin", this.IsSystemAdmin.ToString()));
            userIdentity.AddClaim(new Claim("UserLocalTimeZone", string.IsNullOrEmpty(this.UserLocalTimeZone) ? "" : this.UserLocalTimeZone.ToString()));
            userIdentity.AddClaim(new Claim("UserUtcTimeZoneOffset", string.IsNullOrEmpty(this.UserUtcTimeZoneOffset) ? "" : this.UserUtcTimeZoneOffset.ToString()));
            userIdentity.AddClaim(new Claim("DefaultUtcTimeZoneOffset", string.IsNullOrEmpty(defaultUtcTimeZoneOffset.DefaultUtcTimeZoneOffset) ? "-6:00" : defaultUtcTimeZoneOffset.DefaultUtcTimeZoneOffset));
            userIdentity.AddClaim(new Claim("DefaultAppTimeZoneId", string.IsNullOrEmpty(defaultUtcTimeZoneOffset.DefaultUtcTimeZone) ? "Central Standard Time" : defaultUtcTimeZoneOffset.DefaultUtcTimeZone));
            userIdentity.AddClaim(new Claim("LastLoginId", this.LastLoginId == null? Guid.Empty.ToString() : LastLoginId.ToString()));
            return userIdentity;
        }
    }
    // Must be expressed in terms of our custom UserRole:
    public class ApplicationRole : IdentityRole<string, ApplicationUserRole>
    {
        public ApplicationRole()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public ApplicationRole(string name)
            : this()
        {
            this.Name = name;
        }

        // Add any custom Role properties/code here
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base(ConnectionStringHelper.OntrackHelthConnectionString, throwIfV1Schema: false)
        {
        }
        public DbSet<ApplicationSetting> ApplicationSettings { set; get; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().ToTable("SysUser");
            modelBuilder.Entity<IdentityRole>().ToTable("SysRole");
            modelBuilder.Entity<IdentityUserRole>().ToTable("SysUserRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("SysUserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("SysUserClaim");            
            Database.SetInitializer<ApplicationDbContext>(null);            
        }
    }
    public class ApplicationRoleStore : RoleStore<ApplicationRole, string, ApplicationUserRole>, IQueryableRoleStore<ApplicationRole, string>,IRoleStore<ApplicationRole, string>, IDisposable
    {
        public ApplicationRoleStore()
            : base(new IdentityDbContext())
        {
            base.DisposeContext = true;
        }
        public ApplicationRoleStore(DbContext context)
            : base(context)
        {
        }
    }
}