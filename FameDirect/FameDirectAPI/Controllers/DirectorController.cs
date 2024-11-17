using BLogic;
using TheModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Amazon.S3;
using Amazon.S3.Transfer;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FameDirectAPI
{
    [ApiController]
    [Route("api/director")]
    public class DirectorController : Controller
    {
        private readonly DirectorGetServices _direcGetServices;
        private readonly DirectorCud _direcCUD;
        private readonly string _accessKey = "";
        private readonly string _secretKey = "";
        private readonly string _bucketName = "kadelacruz";
        private readonly AmazonS3Client _s3Client;

        public DirectorController()
        {
            _direcGetServices = new DirectorGetServices();
            _direcCUD = new DirectorCud();
            _s3Client = new AmazonS3Client(_accessKey, _secretKey, Amazon.RegionEndpoint.USEast1);
        }

        [HttpGet]
        public IEnumerable<FameDirectAPI.Directors> GetDirectors()
        {
            var direc = _direcGetServices.GetAllDirectors();

            List<FameDirectAPI.Directors> directors = new List<Directors>();

            foreach (var item in direc)
            {
                directors.Add(new FameDirectAPI.Directors { Director = item.Director, Movie = item.Movie });
            }

            return directors;
        }

        [HttpPost]
        public JsonResult AddDirec(Directors request)
        {
            var result = _direcCUD.CreateDirectors(request.Director, request.Movie);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateDirec(Directors request)
        {
            var result = _direcCUD.UpdateDirectors(request.Director, request.Movie);

            return new JsonResult(result);
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

        // New endpoint to upload a file to S3
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFileToS3(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file provided.");
            }

            var fileTransferUtility = new TransferUtility(_s3Client);

            try
            {
                using (var fileStream = file.OpenReadStream())
                {
                    var uploadRequest = new TransferUtilityUploadRequest
                    {
                        InputStream = fileStream,
                        Key = file.FileName,
                        BucketName = _bucketName,
                        ContentType = file.ContentType
                    };

                    await fileTransferUtility.UploadAsync(uploadRequest);
                }

                return Ok("File uploaded successfully.");
            }
            catch (AmazonS3Exception e)
            {
                return StatusCode(500, $"Error encountered: {e.Message}");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Unexpected error: {e.Message}");
            }
        }
    }
}
