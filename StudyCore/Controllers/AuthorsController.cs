using StudyCore.BindingModels;
using StudyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudyCore.Controllers
{
    [RoutePrefix("api/Author")]

    public class AuthorsController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [Route("CreateAuthor")]
        public IHttpActionResult CreateAuthor(CreateAuthorBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Authors.Add(new Author
            {
                Name = model.Name
            });
            db.SaveChanges();
            return Json( new { Message = "Add_Author_Success"});
        }
    }
}
