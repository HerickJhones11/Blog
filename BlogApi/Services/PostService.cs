using BlogApi.Models;
using BlogApi.Repositories;

namespace BlogApi.Services
{
    public class PostService : IPostService
    {
        public Post Create(Post post)
        {
            post.Id = PostRepository.Post.Count + 1;
            PostRepository.Post.Add(post);

            return post;
        }
        public Post Get(int id)
        {
            var post = PostRepository.Post.FirstOrDefault(o => o.Id == id);
            if (post == null) return null;
            return post;
        }
        public List<Post> List()
        {
            var post = PostRepository.Post;
            return post;
        }
        public Post Update(Post newPost)
        {
            var oldPost = PostRepository.Post.FirstOrDefault(o => o.Id == newPost.Id);
            if(oldPost is null) return null;
            
            oldPost.Title = newPost.Title;
            oldPost.Text = newPost.Text;
            oldPost.Rating = newPost.Rating;

            return newPost;
        }
        public bool Delete(int id)
        {
            var oldPost = PostRepository.Post.FirstOrDefault(o=> o.Id == id);

            if (oldPost is null) return false;

            PostRepository.Post.Remove(oldPost);

            return true;
        }
    }
}
