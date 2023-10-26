namespace Blog.Screens.PostWithTagsScreen
{
  public static class MenuPostWithTagsScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Víncular post a uma tag");
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
          ListPostWithTagsScreen.Load();
          break;
        case 2:
          CreatePostWithTagsScreen.Load();
          break;
        default:
          Load();
          break;
      }
    }
  }
}