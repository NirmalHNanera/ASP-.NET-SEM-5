using System;

namespace Lab3
{
    class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("General hospital details...");
        }
    }

    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo hospital details...");
        }
    }

    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt hospital details...");
        }
    }

    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Superspeciality hospital details...");
        }
    }
}