using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FirmaManager
    {
        private IApplicantService _applicantService;

        public FirmaManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveData (Person person)
        {
            PersonManager personManager = new PersonManager ();

            if (_applicantService.checkPerson(person))
            {
                Console.WriteLine(person.FirstName+""+person.LastName+"geçerli bir vatandaş bilgisine sahiptir!");
            }
        } 
    }
}
