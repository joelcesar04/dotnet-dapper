using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
  public static class ListUserScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de Tags");
      Console.WriteLine("---------------");
      Console.WriteLine("");

      List();

      Console.ReadKey();
      MenuUserScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<User>(Database.Connection);
      var users = repository.Get();

      foreach (var user in users)
      {
        Console.WriteLine($"{user.Id} - {user.Name} ({user.Slug})");
      }
    }
  }
}