using MeetingRoom.Domain.Entities;

namespace MeetingRoom.Application.Interfaces.Services;

public interface IUserService
{
    public Task<UserModel?> GetUserByIdAsync(string userId);
    
    public Task<UserModel?> GetUserByUsernameAsync(string username);

    public Task<List<UserModel>> GetAllUsersAsync();

    public Task<UserModel> AddUserAsync(string username, string password, bool isAdmin);

    public Task DeleteUserByIdAsync(string userId);

    public Task<UserModel> LoginAsync(string username, string password);

    public Task CheckUserExistAsync(string accountType, string accountId);
}
