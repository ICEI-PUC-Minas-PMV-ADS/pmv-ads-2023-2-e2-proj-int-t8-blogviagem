using BlogViagem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogViagem.Controllers
{
    public class PostsController : Controller
    {
        private readonly AppDbContext _context;
        public PostsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Posts.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Post post) 
        { 
            if(ModelState.IsValid)
            {
                Post novoPost = new Post
                {
                    Titulo = post.Titulo,
                    Descricao = post.Descricao,
                    Datapost = DateTime.Now,
                    IdAdmin = post.IdAdmin,
                };

                _context.Posts.Add(novoPost);
                await _context.SaveChangesAsync(); 
                return RedirectToAction("Index");
            }

            return View(post);
        }

        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Posts.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Post post)
        {
            if (id != post.ID)
                return NotFound();

            if (ModelState.IsValid)
            {
                Post novoPost = new Post
                {
                    ID=id,
                    Titulo = post.Titulo,
                    Descricao = post.Descricao,
                    Datapost = DateTime.Now,
                    IdAdmin = post.IdAdmin,
                };
                _context.Posts.Update(novoPost);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
                return NotFound();

            var dados = await _context.Posts.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Posts.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Posts.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Posts.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
