using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class CategoryRepository : Repository<Category>
  {
    private readonly SqlConnection _connection;
    public CategoryRepository(SqlConnection connection)
      : base(connection)
    {
      _connection = connection;
    }

    public List<Category> GetWithPosts()
    {
      var query = @"
        SELECT 
            C.*,
            P.* 
        FROM Category C
            LEFT JOIN Post P ON P.CategoryId = C.Id
      ";
      var categories = new List<Category>();

      var items = _connection.Query<Category, Post, Category>(query,
      (category, post) =>
      {
        var categ = categories.FirstOrDefault(x => x.Id == category.Id);
        if (categ == null)
        {
          categ = category;
          if (post != null)
          {
            categ.Posts.Add(post);
          }
          categories.Add(categ);
        }
        else
        {
          categ.Posts.Add(post);
        }
        return category;
      }, splitOn: "Id");
      return categories;
    }
  }
}