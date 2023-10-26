using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
  public static class DeleteRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Deletar um perfil: ");
      Console.WriteLine("-------------");
      Console.WriteLine("");

      Console.Write("Id: ");
      var id = Console.ReadLine();

      Delete(new Role
      {
        Id = int.Parse(id)
      });

      Console.WriteLine("");
      Console.WriteLine("Usuário deletado com sucesso");
      Console.ReadKey();
      MenuRoleScreen.Load();

    }

    private static void Delete(Role role)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);

        repository.Delete(role);

      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível deletar o perfil");
        Console.WriteLine(ex.Message);
      }
    }
  }
}