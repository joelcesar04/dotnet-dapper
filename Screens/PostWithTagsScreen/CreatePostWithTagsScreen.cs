
using Dapper;

namespace Blog.Screens.PostWithTagsScreen
{
  public static class CreatePostWithTagsScreen
  {
    public static void Load()
    {
      Console.Clear();

      Console.WriteLine("Qual ID do post que deseja vincular? ");
      var idPost = int.Parse(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine("Qual ID da tag que deseja vincular? ");
      var idTag = int.Parse(Console.ReadLine());

      Create(idPost, idTag);
      Console.WriteLine();
      Console.WriteLine();

      Console.ReadKey();
      MenuPostWithTagsScreen.Load();
    }

    private static void Create(int idPost, int idTag)
    {
      var connection = Database.Connection;

      var query = @"
        INSERT INTO [PostTag] VALUES(@PostId, @TagId)
      ";

      var rows = connection.Execute(query, new
      {
        PostId = idPost,
        TagId = idTag
      });

      Console.WriteLine($"{rows} linhas afetadas");
    }
  }
}