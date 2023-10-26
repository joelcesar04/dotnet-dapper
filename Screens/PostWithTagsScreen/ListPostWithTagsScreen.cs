
using Blog.Repositories;

namespace Blog.Screens.PostWithTagsScreen
{
  public static class ListPostWithTagsScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de Usuários/Perfis");
      Console.WriteLine("-------------------------");
      Console.WriteLine("");

      List();

      Console.ReadKey();
      MenuPostWithTagsScreen.Load();
    }

    private static void List()
    {
      var repository = new PostRepository(Database.Connection);

      var postsWithTags = repository.GetWithTags();

      foreach (var post in postsWithTags)
      {
        Console.WriteLine($"{post.Id} - {post.Title} ({post.Slug})");
        Console.WriteLine($"Quantidade de tags: {post.Tags.Count}");
        
      }
    }
  }
}