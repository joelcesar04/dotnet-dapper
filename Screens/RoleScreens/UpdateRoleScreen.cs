using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
  public static class UpdateRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizar perfil: ");
      Console.WriteLine("-------------");
      Console.WriteLine("");

      Console.Write("Id: ");
      var id = Console.ReadLine();

      Console.Write("Nome: ");
      var name = Console.ReadLine();

      Console.Write("Slug: ");
      var slug = Console.ReadLine();

      Update(new Role
      {
        Id = int.Parse(id),
        Name = name,
        Slug = slug
      });

      Console.WriteLine("");
      Console.WriteLine("Usuário atualizado com sucesso");
      Console.ReadKey();
      MenuRoleScreen.Load();
    }

    private static void Update(Role role)
    {
      try
      {
        var repository = new Repository<Role>(Database.Connection);

        repository.Update(role);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar o perfil");
        Console.WriteLine(ex.Message);
      }
    }
  }
}