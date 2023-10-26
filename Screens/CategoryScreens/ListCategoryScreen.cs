
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
  public static class ListCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de Categorias");
      Console.WriteLine("---------------");
      Console.WriteLine("");

      List();

      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    private static void List()
    {
      var repository = new CategoryRepository(Database.Connection);
      var categories = repository.GetWithPosts();

      foreach (var category in categories)
      {
        Console.WriteLine($"{category.Id} - {category.Name} ({category.Slug})");
        Console.WriteLine($" - Quantidade de posts {category.Posts.Count}");
        Console.WriteLine("");
      }
    }
  }
}