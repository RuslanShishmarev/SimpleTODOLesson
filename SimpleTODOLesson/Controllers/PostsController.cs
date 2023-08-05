using Microsoft.AspNetCore.Mvc;
using SimpleTODOLesson.Models;
using SimpleTODOLesson.Services.Interfaces;

namespace SimpleTODOLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostsService _postsService;

        public PostsController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        [HttpPost]
        public PostModel Create(PostModel model)
        {
            return _postsService.Create(model);
        }

        [HttpPatch]
        public PostModel Update(PostModel model)
        {
            return _postsService.Update(model);
        }

        [HttpGet("{id}")]
        public PostModel Get(int id)
        {
            return _postsService.Get(id);
        }

        [HttpGet]
        public IEnumerable<PostModel> GetAll()
        {
            return _postsService.Get();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _postsService.Delete(id);

            return Ok();
        }
    }
}
