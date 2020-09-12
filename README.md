# Learning2020
C# Problems
1. Hospital Management System
   - It contains 4 main entities(Patients, Doctors, Nurses, Wardboys)
   - Patients can get treatment from only one doctor. (Aggregation Relationship betwwen Patient and Doctors)
   - Patients can have multiple nurses and wardboys.
   - Patients can have multiple Allergies. (Coposition Relationship between Patient and Allergies) 
   - Patients can visit Hospital multiple times. (Aggregation Relationship between Patient and Visits)
   - Each Visit is having treatments and each tratments is having medicines.
   - Staff class is containing common information about the Doctors, Nurses and Wardboys.
   - Staff class is super class of Doctors, Nurses and Wardboys class.
   - Factory method(Design Pattern) is useed for creating the instance of Staff(Doctors, Nurses, Wardboys)
   - Salary Interface(Contract) for the Doctors, Nurses and Wardboys classes, The criteria to calculate the salary of Doctors, Nurses and Wardboys is different and all should          implement the salary interface.
