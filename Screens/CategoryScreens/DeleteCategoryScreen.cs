using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreen
{
  public static class DeleteCategoryScreen
  {
    public static void Load()
    {

      Console.Clear();
      Console.WriteLine("Deletar uma categoria: ");
      Console.WriteLine("---------------------");
      Console.WriteLine("");

      Console.Write("Id: ");
      var id = Console.ReadLine();

      Delete(new Category
      {
        Id = int.Parse(id)
      });

      Console.ReadKey();
      MenuCategoryScreen.Load();
    }

    private static void Delete(Category category)
    {
      try
      {
        var repository = new Repository<Category>(Database.Connection);
        repository.Delete(category);
        Console.WriteLine("Categoria deletada com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível atualizar a categoria");
        Console.WriteLine(ex.Message);
      }

    }
  }
}