using System.Configuration;

namespace DVLD.DataAccess
{
    static class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLDConnectionString"].ConnectionString;
    }
}
