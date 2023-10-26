using Blog;
using Blog.Screens.TagScreens;
using Blog.Screens.RoleScreens;
using Microsoft.Data.SqlClient;
using Blog.Screens.UserScreens;
using Blog.Screens.CategoryScreen;
using Blog.Screens.PerfilWithRoleScreen;
using Blog.Screens.PostScreens;
using Blog.Screens.PostWithTagsScreen;

class Program
{
  private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";
  static void Main(string[] args)
  {
    Database.Connection = new SqlConnection(CONNECTION_STRING);
    Database.Connection.Open();

    Load();
    Console.ReadKey();
    
    Database.Connection.Close();
  }

  private static void Load()
  {
    Console.Clear();
    Console.WriteLine("Meu Blog");
    Console.WriteLine("-----------------");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine();
    Console.WriteLine("1 - Gestão de usuário");
    Console.WriteLine("2 - Gestão de perfil");
    Console.WriteLine("3 - Gestão de categoria");
    Console.WriteLine("4 - Gestão de tag");
    Console.WriteLine("5 - Gestão de posts");
    Console.WriteLine("6 - Vincular perfil/usuário");
    Console.WriteLine("7 - Vincular post/tag");
    Console.WriteLine();
    Console.WriteLine();
    var option = short.Parse(Console.ReadLine());

    switch (option)
    {
      case 1:
        MenuUserScreen.Load();
        break;

      case 2:
        MenuRoleScreen.Load();
        break;

      case 3:
        MenuCategoryScreen.Load();
        break;

      case 4:
        MenuTagScreen.Load();
        break;

      case 5:
        MenuPostScreen.Load();
        break;

      case 6:
        MenuPerfilWithRoleScreen.Load();
        break;

      case 7:
        MenuPostWithTagsScreen.Load();
        break;
        
      default: 
        Load();
        break;
    }
  }
}