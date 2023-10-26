using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class PostRepository : Repository<Post>
  {
    private readonly SqlConnection _connection;
    public PostRepository(SqlConnection connection)
      : base(connection)
    => _connection = connection;

    public List<Post> GetWithTags()
    {
      var query = @"
        SELECT 
            [P].*,
            [T].*
        FROM [Post] P
            LEFT JOIN [PostTag] ON [PostTag].[PostId] = [P].[Id] 
            LEFT JOIN [Tag] T ON [PostTag].[TagId] = [T].[Id]
      ";
      var posts = new List<Post>();

      var items = _connection.Query<Post, Tag, Post>(query,
      (post, tag) =>
      {
        var pts = posts.FirstOrDefault(x => x.Id == post.Id);
        if (pts == null)
        {
          pts = post;
          if (tag != null)
          {
            pts.Tags.Add(tag);
          }
          posts.Add(pts);
        }
        else
        {
          pts.Tags.Add(tag);
        }
        return post;
      }, splitOn: "Id"
      );

      return posts;
    }
  }
}