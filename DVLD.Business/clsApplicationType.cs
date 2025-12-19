using DVLD.DataAccess;
using System.Data;

namespace DVLD.Business
{
    public class clsApplicationType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public float Fees { get; set; }

        public clsApplicationType()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
        }

        private clsApplicationType(int ID, string Title, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }

        static public DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationTypes();
        }

        public static clsApplicationType Find(int ID)
        {
            string Title = "";
            float Fees = 0;

            if (clsApplicationTypeData.GetApplicationTypeInfoByID(ID, ref Title, ref Fees))

                return new clsApplicationType(ID, Title, Fees);
            else
                return null;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }

        public bool Save()
        {
            return _UpdateApplicationType();
        }
    }
}
