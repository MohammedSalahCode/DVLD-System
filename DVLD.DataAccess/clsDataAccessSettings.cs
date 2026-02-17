using System.Configuration;

namespace DVLD.DataAccess
{
    static class clsDataAccessSettings
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DVLDConnectionString"].ConnectionString;
    }
}
