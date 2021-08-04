using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public DateTime GeBirthDate()
        {
            return _birthDate;
        }

    }
}