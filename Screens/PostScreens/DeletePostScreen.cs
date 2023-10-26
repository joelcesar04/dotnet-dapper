using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public static class DeletePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Deletar um post: ");
      Console.WriteLine("---------------------");
      Console.WriteLine("");

      Console.Write("Id: ");
      var id = Console.ReadLine();

      Delete(new Post
      {
        Id = int.Parse(id)
      });

      Console.ReadKey();
      MenuPostScreen.Load();
    }

    private static void Delete(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Delete(post);
        Console.WriteLine("Post deletado com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar o post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}
