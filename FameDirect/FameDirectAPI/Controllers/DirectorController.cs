using BLogic;
using TheModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace FameDirectAPI
{
    [ApiController]
    [Route("api/director")]
    public class DirectorController : Controller
    {
        DirectorGetServices _direcGetServices;
        DirectorCud _direcCUD;

        public DirectorController()
        {
            _direcGetServices = new DirectorGetServices();
            _direcCUD = new DirectorCud();
        }

        [HttpGet]
        public IEnumerable<FameDirectAPI.Directors> GetDirectors()
        {
            var direc = _direcGetServices.GetAllDirectors();

            List<FameDirectAPI.Directors> directors = new List<Directors>();

            foreach (var item in  direc)
            {
                directors.Add(new FameDirectAPI.Directors { Director = item.Director, Movie = item.Movie });
            }

            return directors;
        }

        [HttpPost]

        public JsonResult AddDirec (Directors request)
        {
            var result = _direcCUD.CreateDirectors(request.Director, request.Movie);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateDirec (Directors request)
        {
            var result = _direcCUD.UpdateDirectors(request.Director, request.Movie);

            return new JsonResult (result);
        }

        [HttpDelete]
        public JsonResult DeleteSong(FameDirectAPI.Directors request)
        {

            var delete = new TheModel.Directors
            {
                Director = request.Director

            };

            var result = _direcCUD.DeleteDirectors(delete);

            return new JsonResult(result);
        }
    }
}