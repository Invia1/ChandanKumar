using System;

namespace Hospital_Management.Functionality
{
    public interface IPatientsOperations
    {
        int createPatient();
        void deletePatient();
        void updatePatient();

        void searchPatient();

        void fetchAll();
    }
}
