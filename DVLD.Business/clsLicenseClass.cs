using DVLD.DataAccess;
using System.Data;

namespace DVLD.Business
{
    public class clsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public byte MinAge { get; set; }
        public byte ValidityLength { get; set; }
        public float ClassFees { get; set; }

        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.Description = "";
            this.MinAge = 18;
            this.ValidityLength = 10;
            this.ClassFees = 0;

            Mode = enMode.AddNew;
        }

        private clsLicenseClass(int LicenseClassID, string ClassName, string Description, byte MinAge, byte ValidityLength, float Fees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.Description = Description;
            this.MinAge = MinAge;
            this.ValidityLength = ValidityLength;
            this.ClassFees = Fees;
            Mode = enMode.Update;

        }

        private bool _AddNewLicenseClass()
        {
            //call DataAccess Layer 

            this.LicenseClassID = clsLicenseClassData.AddNewLicenseClass(this.ClassName, this.Description,
                this.MinAge, this.ValidityLength, this.ClassFees);


            return (this.LicenseClassID != -1);
        }

        private bool _UpdateLicenseClass()
        {
            //call DataAccess Layer 

            return clsLicenseClassData.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.Description,
                this.MinAge, this.ValidityLength, this.ClassFees);
        }

        static public clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = "", Description = "";
            byte MinAge = 18, ValidityLength = 10;
            float Fees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref Description, ref MinAge, ref ValidityLength, ref Fees))

                return new clsLicenseClass(LicenseClassID, ClassName, Description, MinAge, ValidityLength, Fees);
            else
                return null;
        }

        static public clsLicenseClass Find(string ClassName)
        {
            int LicenseClassID = -1;
            string Description = "";
            byte MinAge = 0, ValidityLength = 0;
            float Fees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref Description, ref MinAge, ref ValidityLength, ref Fees))

                return new clsLicenseClass(LicenseClassID, ClassName, Description, MinAge, ValidityLength, Fees);
            else
                return null;
        }

        static public DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassData.GetAllLicenseClasses();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicenseClass())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicenseClass();

            }

            return false;
        }
    }
}
