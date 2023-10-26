using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
  public static class CreatePostScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Novo Post: ");
      Console.WriteLine("-------------");
      Console.WriteLine("");


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

      Create(new Post
      {
        Title = title,
        Summary = summary,
        Body = body,
        Slug = slug,
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now,
        AuthorId = int.Parse(idAuthor),
        CategoryId = int.Parse(idCategory),
      });

      Console.WriteLine("Usuário cadastrado com sucesso");
      Console.ReadKey();
      MenuPostScreen.Load();
    }

    private static void Create(Post post)
    {
      try
      {
        var repository = new Repository<Post>(Database.Connection);
        repository.Create(post);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível criar um post");
        Console.WriteLine(ex.Message);
      }
    }
  }
}