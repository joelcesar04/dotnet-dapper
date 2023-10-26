using Dapper;

namespace Blog.Screens.PerfilWithRoleScreen
{
  public static class CreatePerfilWithRole
  {
    public static void Load()
    {
      Console.Clear();

      Console.WriteLine("Qual ID do usuário que deseja vincular? ");
      var idUser = int.Parse(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Qual ID do perfil que deseja vincular? ");
      var idRole = int.Parse(Console.ReadLine());

      Create(idUser, idRole);
      Console.WriteLine();
      Console.WriteLine();

      Console.ReadKey();
      MenuPerfilWithRoleScreen.Load();
    }

    private static void Create(int idUser, int idRole)
    {
      var connection = Database.Connection;

      var query = @"
        INSERT INTO [UserRole] VALUES(@UserId, @RoleId)
      ";

      var rows = connection.Execute(query, new
      {
        UserId = idUser,
        RoleId = idRole
      });

      Console.WriteLine($"{rows} linhas afetadas");
    }
  }
}