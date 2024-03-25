using System;

namespace LegacyApp.Core.Interface;

public interface IInputValidator
{
    public bool ValidateName(String firstName, String lastName);
    public bool ValidateEmail(String email);
    public bool ValidateAge(DateTime dateOfBirth);
    
}