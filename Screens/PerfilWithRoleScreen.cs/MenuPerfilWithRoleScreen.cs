namespace Blog.Screens.PerfilWithRoleScreen
{
  public static class MenuPerfilWithRoleScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Víncular usuário a um perfil");
      Console.WriteLine("--------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar");
      Console.WriteLine("2 - Cadastrar");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          ListPerfilWithRole.Load();
          break;
        case 2:
          CreatePerfilWithRole.Load();
          break;
        default:
          MenuPerfilWithRoleScreen.Load();
          break;
      }
    }
  }
}