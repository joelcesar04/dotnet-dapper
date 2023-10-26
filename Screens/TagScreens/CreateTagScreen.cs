using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public static class CreateTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Nova Tag: ");
      Console.WriteLine("-------------");
      Console.WriteLine("");


      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();

      Create(new Tag
      {
        Name = name,
        Slug = slug
      });

      Console.ReadKey();
      MenuTagScreen.Load();
    }

    private static void Create(Tag tag)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);

        repository.Create(tag);
        Console.WriteLine("Usuário Cadastrado");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar a tag");
        Console.WriteLine(ex.Message);
      }
    }
  }
}