using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Healz.Data;
using Healz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;

namespace Healz.Controllers
{
    public class BlogPostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;

        public BlogPostsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager,IHostingEnvironment hostingEnvironment)
        {
           
            _context = context;
            _userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: BlogPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogPost.ToListAsync());
        }

        // GET: BlogPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost
                .FirstOrDefaultAsync(m => m.BlogPostId == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }

        // GET: BlogPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogPostCreateVM model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.ImgUrl != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images/post");
                    uniqueFileName =  Guid.NewGuid().ToString() + "_" + model.ImgUrl.FileName;
                    string filePath = Path.Combine(uploadsFolder,uniqueFileName);
                    model.ImgUrl.CopyTo(new FileStream(filePath, FileMode.Create));

                }
                var user = await _userManager.GetUserAsync(HttpContext.User);
                
                BlogPost blogPost = new BlogPost
                {
                    postTitle = model.postTitle,
                    postDesc = model.postDesc,
                    postDate = model.postDate,
                    postedBy = user.FirstName + " " + user.LastName,
                    postImgUrl = uniqueFileName
                };
                
                _context.Add(blogPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //// GET: BlogPosts/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var blogPost = await _context.BlogPost.FindAsync(id);
        //    if (blogPost == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(blogPost);
        //}

        // POST: BlogPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id,Healz.Models.BlogPostEditVM blogPost)
        //{
        //    if (id != blogPost.BlogPostId)
        //    {
        //        return NotFound();
        //    }
        //    string uniqueFileName = null;
        //    if (ModelState.IsValid)
        //    {
                
        //        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images/post");
        //         uniqueFileName = Guid.NewGuid().ToString() + "_" + blogPost.ImgUrl.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        blogPost.ImgUrl.CopyTo(new FileStream(filePath, FileMode.Create));
        //        try
        //        {
        //            BlogPost blogEditPost = new BlogPost
        //            {
        //                BlogPostId = blogPost.BlogPostId,
        //                postTitle = blogPost.postTitle,
        //                postDesc = blogPost.postDesc,
        //                postImgUrl = uniqueFileName,
        //                postDate = blogPost.postDate,
        //                postedBy = blogPost.postedBy

        //            };
        //            _context.Update(blogEditPost);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BlogPostExists(blogPost.BlogPostId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(blogPost);
        //}

        // GET: BlogPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPost
                .FirstOrDefaultAsync(m => m.BlogPostId == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }

        // POST: BlogPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogPost = await _context.BlogPost.FindAsync(id);
            _context.BlogPost.Remove(blogPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostExists(int id)
        {
            return _context.BlogPost.Any(e => e.BlogPostId == id);
        }
    }
}
