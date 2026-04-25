using BackEnd.Aritmica.Features.Logs.Services.Interfaces;
using BackEnd.Aritmica.Features.Person.Models;
using Dapper;
using System.Data;

namespace BackEnd.Aritmica.Features.Person.Repositories;

public class PersonRepository(ILogsService logsService)
{
    protected int SavePerson(IDbTransaction dbTransaction, PersonModel personModel)
    {
        try
        {
            return dbTransaction.Connection!.ExecuteScalar<int>(SqlToSavePerson, personModel, dbTransaction);
        }
        catch (Exception exception)
        {
            logsService.SaveErrorLog(exception.Message, nameof(PersonRepository));
            return 0;
        }
    }

    private const string SqlToSavePerson = 
        """
        INSERT INTO Person (
                    IdPerson,
                    NamePerson,
                    NickName,
                    EmailPerson,
                    PasswordPerson,
                    PhoneNumberPerson,
                    TypePerson,
                    BirthdayDate,
                    RegistrationDate,
                    LastLogin,
                    Active,
                    ProfilePic
                )
                VALUES (
                    @IdPerson,
                    @NamePerson,
                    @NickName,
                    @EmailPerson,
                    @PasswordPerson,
                    @PhoneNumberPerson,
                    @TypePerson,
                    @BirthdayDate,
                    @RegistrationDate,
                    @LastLogin,
                    @Active,
                    @ProfilePic
                )
                ON CONFLICT (IdPerson) DO UPDATE SET
                    NamePerson = EXCLUDED.NamePerson,
                    NickName = EXCLUDED.NickName,
                    EmailPerson = EXCLUDED.EmailPerson,
                    PasswordPerson = EXCLUDED.PasswordPerson,
                    PhoneNumberPerson = EXCLUDED.PhoneNumberPerson,
                    TypePerson = EXCLUDED.TypePerson,
                    BirthdayDate = EXCLUDED.BirthdayDate,
                    RegistrationDate = EXCLUDED.RegistrationDate,
                    LastLogin = EXCLUDED.LastLogin,
                    Active = EXCLUDED.Active,
                    ProfilePic = EXCLUDED.ProfilePic
                RETURNING IdPerson
        """;
}