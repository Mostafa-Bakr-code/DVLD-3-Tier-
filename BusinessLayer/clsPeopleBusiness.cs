using System;
using System.Data;
using DataLayer;

namespace BusinessLayer
{
    public class clsPeopleBusiness
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }                  
        public string NationalNo { get; set; }              
        public string FirstName { get; set; }               
        public string SecondName { get; set; }               
        public string ThirdName { get; set; }               
        public string LastName { get; set; }                 
        public DateTime DateOfBirth { get; set; }            
        public int Gender { get; set; }                     
        public string Address { get; set; }                  
        public string Phone { get; set; }                   
        public string Email { get; set; }                   
        public int NationalityCountryID { get; set; }        
        public string ImagePath { get; set; }


        public clsPeopleBusiness()

        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.MinValue; // Set to default value
            this.Gender = 0; // Default gender
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = 0;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        public clsPeopleBusiness(int personID, string nationalNo, string firstName, string secondName, string thirdName,
               string lastName, DateTime dateOfBirth, int gender, string address, string phone, string email,
               int nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;

            Mode = enMode.Update;  // When creating with parameters, assume it's for updating
        }



        public static clsPeopleBusiness Find(int PersonID)
        {
            // Variables to hold the retrieved data from the data layer
            string nationalNo = "";
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            DateTime dateOfBirth = DateTime.MinValue;
            int gender = 0;
            string address = "";
            string phone = "";
            string email = "";
            int nationalityCountryID = 0;
            string imagePath = "";

            
            if (clsPeopleData.GetPersonInfoByID(PersonID, ref nationalNo, ref firstName, ref secondName, ref thirdName, ref lastName,
                ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                
                return new clsPeopleBusiness(PersonID, nationalNo, firstName, secondName, thirdName, lastName, dateOfBirth, gender,
                    address, phone, email, nationalityCountryID, imagePath);
            }
            else
            {
             
                return null;
            }
        }

        public static DataTable GetAllPersons()
        {
            return clsPeopleData.GetAllPersons();
        }

        public static DataTable GetAllCountries()
        {
            return clsPeopleData.GetAllCountries();
        }

        public static int GetTotalNumberOfPersons()
        {
            return clsPeopleData.GetTotalNumberOfPersons();
        }

        public static bool IsPersonExist(int personID)
        {

            return clsPeopleData.IsPersonExist(personID);

        }

        public static bool IsPersonExist(string nationalNO)
        {

            return clsPeopleData.IsPersonExist(nationalNO);

        }

    }
}
