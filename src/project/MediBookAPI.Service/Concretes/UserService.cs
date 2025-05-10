using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Model.Entities;
using MediBookAPI.Service.Abstracts;

namespace MediBookAPI.Service.Concretes;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Add(User user)
    {
        _userRepository.Add(user);
    }

    public void Delete(int id)
    {
        var user = _userRepository.GetById(id) ?? 
            throw new Exception("Kullanıcı bulunamadı");
        
        _userRepository.Delete(user);
    }

    public List<User> GetAll()
    {
        return _userRepository.GetAll();
    }

    public User GetById(int id)
    {
        return _userRepository.GetById(id) ?? 
            throw new Exception("Kullanıcı bulunamadı");
    }

    public User GetByUsername(string username)
    {
        return _userRepository.Query().FirstOrDefault(x => x.Username == username) ?? 
            throw new Exception("Kullanıcı bulunamadı");
    }

    public void Update(User user)
    {
        var existingUser = _userRepository.GetById(user.Id) ?? 
            throw new Exception("Kullanıcı bulunamadı");

        _userRepository.Update(user);
    }
} 