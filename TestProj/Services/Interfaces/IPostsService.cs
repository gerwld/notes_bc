using TestProj.Models;

namespace TestProj.Services.Interfaces;

public interface IPostsService
{
    PostModel Create(PostModel model);
    PostModel Update(PostModel model);
    PostModel Get(int id);
    List<PostModel> Get();
    void Delete(int id);
}