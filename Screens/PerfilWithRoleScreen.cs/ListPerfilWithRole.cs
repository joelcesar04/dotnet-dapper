
using Blog.Models;
using Blog.Repositories;
using Dapper;

namespace Blog.Screens.PerfilWithRoleScreen
{
  public static class ListPerfilWithRole
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de Usuários/Perfis");
      Console.WriteLine("-------------------------");
      Console.WriteLine("");

      List();

      Console.ReadKey();
      MenuPerfilWithRoleScreen.Load();
    }

    private static void List()
    {
      try
      {
        var repository = new UserRepository(Database.Connection);

        var users = repository.GetWithRoles();
        foreach (var user in users)
        {
          Console.WriteLine($"{user.Name} - {user.Slug}");
          foreach (var role in user.Roles)
          {
            Console.WriteLine($" - {role.Name}");
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível visualizar o vínculo");
        Console.WriteLine(ex.Message);
      }
    }
  }
}