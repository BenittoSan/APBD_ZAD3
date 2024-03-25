namespace LegacyApp.Core.Interface;

public interface IClientRepository
{
    public Client GetById(int clientId);
}