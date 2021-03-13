using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminBlog.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System;
using AdminBlog.Filter;

namespace AdminBlog.Controllers
{
    [UserFilter]
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private readonly BlogContext _context;
        public BlogController(ILogger<BlogController> logger, BlogContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult BlogList()
        {
           var List = _context.Blog.ToList();
            return View(List);
        }
        public IActionResult IsPublish(int Id)
        {
            var blog = _context.Blog.Find(Id);
            blog.IsPublish = true;
            _context.Update(blog);
            _context.SaveChanges();
            return RedirectToAction(nameof(BlogList));
        }
        public IActionResult Blog()
        {
            ViewBag.Categories = _context.Category.Select(w =>
              new SelectListItem
              {
                  Text = w.Name,
                  Value = w.Id.ToString()
              }).ToList();
            return View();
        }
        public async Task<IActionResult> Save(Blog model)
        {
            if(model != null)
            {
                var file = Request.Form.Files.First();
                //C:\Users\aleyn\source\repos\MyBlog\wwwroot\img
                string savePath = Path.Combine("C:", "Users", "aleyn", "source", "repos", "MyBlog", "wwwroot", "img");
                var fileName = $"{DateTime.Now:MMddHHmmss}.{file.FileName.Split(".").Last()}";
                var fileUrl = Path.Combine(savePath, fileName);

                using(var fileStream=new FileStream(fileUrl, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                model.ImagePath = fileName;
                model.AuthorId = (int)HttpContext.Session.GetInt32("id");

                await _context.AddAsync(model);
                await _context.SaveChangesAsync();

                return Json(true);
            }
            return Json(false);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
