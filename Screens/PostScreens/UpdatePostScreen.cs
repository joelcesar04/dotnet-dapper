
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public static class UpdatePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Atualizando um Post: ");
      Console.WriteLine("-------------");
      Console.WriteLine("");

      Console.Write("Id: ");
      var id = Console.ReadLine();
      Console.Write("Título: ");
      var title = Console.ReadLine();
      Console.Write("Sumário: ");
      var summary = Console.ReadLine();
      Console.Write("Corpo: ");
      var body = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();
      Console.Write("Id Autor: ");
      var idAuthor = Console.ReadLine();
      Console.Write("Id Categoria: ");
      var idCategory = Console.ReadLine();

      Update(new Post
      {
        Id = int.Parse(id),
        Title = title,
        Summary = summary,
        Body = body,
        Slug = slug,
        LastUpdateDate = DateTime.Now,
        AuthorId = int.Parse(idAuthor),
        CategoryId = int.Parse(idCategory),
      });

      Console.ReadKey();
      MenuPostScreen.Load();

    }

    private static void Update(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Update(post);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar um post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}