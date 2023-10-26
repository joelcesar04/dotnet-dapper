using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
  public static class CreateCategoryScreen
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Nova Categoria: ");
      Console.WriteLine("-------------");
      Console.WriteLine("");


      Console.Write("Nome: ");
      var name = Console.ReadLine();
      Console.Write("Slug: ");
      var slug = Console.ReadLine();

      Create(new Category
      {
        Name = name,
        Slug = slug
      });

      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    private static void Create(Category category)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);

        repository.Create(category);
        Console.WriteLine("Categoria cadastrada");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar a categoria");
        Console.WriteLine(ex.Message);
      }
    }
  }
}