using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public static class ListPostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de Posts");
      Console.WriteLine("---------------");
      Console.WriteLine("");

      List();

      Console.ReadKey();
      MenuPostScreen.Load();
    }

    private static void List()
    {
      var repository = new Repository<Post>(Database.Connection);
      var posts = repository.Get();
      
      foreach (var post in posts)
      {
        Console.WriteLine($"{post.Id} - {post.Title} ({post.Slug})");
      }
    }
  }
}