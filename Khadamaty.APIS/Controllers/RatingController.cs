using AutoMapper;
using Khadamaty.BL.Helper;
using Khadamaty.BL.Interface;
using Khadamaty.BL.Models;
using Khadamaty.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Khadamaty.APIS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        #region Field
        private readonly IRatingRep rating;
        private readonly IMapper mapper;
        #endregion
        #region ctor
        public RatingController(IRatingRep rating, IMapper mapper)
        {
            this.rating = rating;
            this.mapper = mapper;

        }
        #endregion

        #region APIS 


        #region APIGetAllRatingVM
        [HttpGet]
        [Route("~/Api/Rating/GetData")]

        public IActionResult GetData()
        {
            try
            {
                var data = rating.Get();
                var model = mapper.Map<IEnumerable<RatingVM>>(data);

                return Ok(new ApiResponce<IEnumerable<RatingVM>>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });

            }
            catch (Exception ex)
            {
                return NotFound(new ApiResponce<IEnumerable<RatingVM>>
                {
                    Code = "400",
                    Message = ex.Message,
                    Statues = "Not Found",
                });
            }



        }
        #endregion

        #region APICreate

        [Route("~/Api/Rating/PostRating")]
        [HttpPost]
        public IActionResult PostRating(RatingVM ratingVM)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    var model = mapper.Map<Rating>(ratingVM);
                    var Result = rating.Create(model);

                    return Ok(new ApiResponce<Rating>
                    {
                        Code = "200",
                        Message = "Data Created",
                        Statues = "OK",
                        Data = Result
                    });
                }
                return NotFound(new ApiResponce<RatingVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Validation Erro"

                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<RatingVM>
                {
                    Code = "400",
                    Message = "Data NOT Created",
                    Statues = ex.Message
                });

            }

        }
        #endregion

        #region APIGetById

        [Route("~/Api/Rating/GetRatingByID/{id}")]
        [HttpGet]
        public IActionResult GetRatingByID(int ID)
        {
            try
            {

                var data = rating.GetByID(ID);
                var model = mapper.Map<RatingVM>(data);

                return Ok(new ApiResponce<RatingVM>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<RatingVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });

            }

        }
        #endregion



        #region APIPUT

        [Route("~/Api/Rating/PUTRating")]
        [HttpPut]
        public IActionResult PUTRating(RatingVM ratingvm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = mapper.Map<Rating>(ratingvm);
                    var Result = rating.Update(model);


                    return Ok(new ApiResponce<Rating>
                    {
                        Code = "200",
                        Message = "Data Updated",
                        Statues = "OK",
                        Data = Result
                    });
                }

                return NotFound(new ApiResponce<RatingVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Not Found",
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<RatingVM>
                {
                    Code = "400",
                    Message = "Data NOT Update",
                    Statues = "Not Found",
                });

            }

        }

        #endregion


        #region APIDelete


        [Route("~/Api/Rating/DeleteRating")]
        [HttpDelete]
        public IActionResult DeleteRating(RatingVM ratingvm)
        {
            try
            {
                var model = mapper.Map<Rating>(ratingvm);
                rating.Delete(model);


                return Ok(new ApiResponce<Rating>
                {
                    Code = "200",
                    Message = "Data Deleted",
                    Statues = "OK",
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<RatingVM>
                {
                    Code = "400",
                    Message = "Data NOT Delete",
                    Statues = "Not Found",
                });

            }

        }

        #endregion
        #endregion
    }
}
