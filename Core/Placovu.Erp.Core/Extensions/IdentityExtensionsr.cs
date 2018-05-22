using System;
using System.Security.Claims;
using System.Security.Principal;
using Placovu.Erp.Core.Extensions;
using Placovu.Erp.Core.Security;

namespace Microsoft.AspNet.Identity
{
    public static class IdentityExtensions
    {
        public static long? GetUserPracticeProfileId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("PracticeProfileId");
            // Test for null to avoid issues during local testing
            long tempVal;
            //long? val = long.TryParse(stringVal, out tempVal) ? tempVal : (int?)null;
            return (claim != null) ? long.TryParse(claim.Value, out tempVal) ? (long?)tempVal : null : null;
        }
        public static string GetUserPracticeProfileName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("PracticeProfileName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
        public static string GetUserNameDisplay(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst(ClaimTypes.GivenName);
            // Test for null to avoid issues during local testing
            return (claim != null) ? OHCryptographyHelper.DecryptString(claim.Value, OHCryptographySettings.KeyPassword, OHCryptographySettings.SaltPassword) : "No User";
        }
        public static string GetUserIdForLoginId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("UserId");
            // Test for null to avoid issues during local testing
            return claim.Value.ToString();
        }
        public static bool IsSystemAdmin(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("IsSystemAdmin");
            // Test for null to avoid issues during local testing
            return Convert.ToBoolean(claim.Value);
        }
        public static long GetPatientProfileId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("PatientProfileId");
            // Test for null to avoid issues during local testing
            long tempVal;
            //long? val = long.TryParse(stringVal, out tempVal) ? tempVal : (int?)null;
            return (claim != null) ? long.TryParse(claim.Value, out tempVal) ? tempVal : 0 : 0;
        }
        public static string GetPatientProfileName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("PatientProfileName");
            // Test for null to avoid issues during local testing
            return claim?.Value.ToString() ?? "Patient Profile Name??";
        }
        public static Guid GetLoginId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("LastLoginId");
            // Test for null to avoid issues during local testing
            return claim?.Value.ToGuid() ?? Guid.Empty;
        }
        public static string GetUserLocalTimeZone(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("UserLocalTimeZone");
            // Test for null to avoid issues during local testing
            return claim?.Value.ToString() ?? string.Empty;
        }
        public static string GetUserUtcTimeZoneOffset(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("UserUtcTimeZoneOffset");
            // Test for null to avoid issues during local testing
            return claim?.Value.ToString() ?? string.Empty;
        }
        public static string GetDefaultUtcTimeZoneOffset(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("DefaultUtcTimeZoneOffset");
            // Test for null to avoid issues during local testing
            return claim?.Value.ToString() ?? string.Empty;
        }
        public static string GetDefaultAppTimeZoneId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("DefaultAppTimeZoneId");
            // Test for null to avoid issues during local testing
            return claim?.Value.ToString() ?? string.Empty;
        }

    }
}