using BlogApi.Models;

namespace BlogApi.Repositories
{
    public class PostRepository
    {
        public static List<Post> Post = new()
        {
            new Post { Id = 1, Title = "Eternals", Rating = 6.8, Text = "babababababa"},
            new Post { Id = 2, Title = "Eternals2", Rating = 6.8, Text = "babababababa" },
            new Post { Id = 3, Title = "Eternals3", Rating = 6.8, Text = "babababababa" },
            new Post { Id = 4, Title = "Eternals4", Rating = 6.8, Text = "babababababa" }
        };
    }
}
