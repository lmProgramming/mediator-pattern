﻿using MediatorPattern.Models;

namespace MediatorPattern.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}