using ASP_NET_HW_2.Models;
using PagedList;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_HW_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly CommentDbContext _db = new CommentDbContext();
        private const byte PageSize = 5;
        private int _pageNumber = 1;

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Comment(int? page)
        {
            _pageNumber = (page ?? 1);
            return View(_db.Comments.ToList().ToPagedList(_pageNumber, PageSize));
        }

        [HttpPost]
        public ActionResult Comment(Comment comment, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(image.InputStream))
                    {
                        imageData = binaryReader.ReadBytes(image.ContentLength);
                    }
                    comment.ImageData = imageData;
                    comment.ImageMimeType = image.ContentType;

                    _db.Comments.Add(comment);
                    _db.SaveChanges();
                    List<Comment> comments = _db.Comments.ToList();
                    return View(_db.Comments.ToList().ToPagedList(_pageNumber, PageSize));
                }

                _db.Comments.Add(comment);
                _db.SaveChanges();
                return View(_db.Comments.ToList().ToPagedList(_pageNumber, PageSize));
            }

            return View(_db.Comments.ToList().ToPagedList(_pageNumber, PageSize));
        }
    }
}