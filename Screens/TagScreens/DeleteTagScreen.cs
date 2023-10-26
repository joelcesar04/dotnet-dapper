
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
  public static class DeleteTagScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Deletar uma tag: ");
      Console.WriteLine("---------------------");
      Console.WriteLine("");

      Console.Write("Id: ");
      var id = Console.ReadLine();

      Delete(new Tag
      {
        Id = int.Parse(id)
      });

      Console.ReadKey();
      MenuTagScreen.Load(); 
    }

    private static void Delete(Tag tag)
    {
      try
      {
        var repository = new Repository<Tag>(Database.Connection);
        repository.Delete(tag);
        Console.WriteLine("Tag deletada com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar a tag");
        Console.WriteLine(ex.Message);
      }

    }
  }
}