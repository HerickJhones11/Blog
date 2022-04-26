using BlogApi.Models;

namespace BlogApi.Services
{
    public interface IPostService
    {
        public Post Create(Post post);
        public Post Get(int id);
        public List<Post> List();
        public Post Update(Post post);
        public bool Delete(int id);
    }
}
