using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public static class DeleteUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Deletar um usuário: ");
      Console.WriteLine("---------------------");
      Console.WriteLine("");

      Console.Write("Id: ");
      var id = Console.ReadLine();

      Delete(new User
      {
        Id = int.Parse(id)
      });

      Console.WriteLine("Usuário deletado com sucesso");
      Console.ReadKey();
      MenuUserScreen.Load(); 
    }

    private static void Delete(User user)
    {
      try
      {
        var repository = new Repository<User>(Database.Connection);

        repository.Delete(user);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível deletar o usuário");
        Console.WriteLine(ex.Message);
      }
    }
  }
}