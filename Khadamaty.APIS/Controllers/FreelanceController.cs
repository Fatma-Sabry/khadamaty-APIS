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
    public class FreelanceController : ControllerBase
    {
        #region Field
        private readonly IFreelanceRep freelance;
        private readonly IMapper mapper;
        #endregion
        #region ctor
        public FreelanceController(IFreelanceRep freelance, IMapper mapper)
        {
            this.freelance = freelance;
            this.mapper = mapper;

        }
        #endregion

        #region APIS 


        #region APIGetAllFreelances
        [HttpGet]
        [Route("~/Api/Freelance/GetData")]

        public IActionResult GetData()
        {
            try
            {
                var data = freelance.Get();
                var model = mapper.Map<IEnumerable<FreelanceVM>>(data);

                return Ok(new ApiResponce<IEnumerable<FreelanceVM>>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });

            }
            catch (Exception ex)
            {
                return NotFound(new ApiResponce<IEnumerable<FreelanceVM>>
                {
                    Code = "400",
                    Message = ex.Message,
                    Statues = "Not Found",
                });
            }



        }
        #endregion

        #region APICreate

        [Route("~/Api/Freelance/PostFreelance")]
        [HttpPost]
        public IActionResult PostFreelance(FreelanceVM freelanceVM)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    var model = mapper.Map<Freelance>(freelanceVM);
                    var Result = freelance.Create(model);

                    return Ok(new ApiResponce<Freelance>
                    {
                        Code = "200",
                        Message = "Data Created",
                        Statues = "OK",
                        Data = Result
                    });
                }
                return NotFound(new ApiResponce<FreelanceVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Validation Erro"

                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<FreelanceVM>
                {
                    Code = "400",
                    Message = "Data NOT Created",
                    Statues = ex.Message
                });

            }

        }
        #endregion

        #region APIGetById

        [Route("~/Api/Freelance/GetFreelanceByID/{id}")]
        [HttpGet]
        public IActionResult GetFreelanceByID(int ID)
        {
            try
            {

                var data = freelance.GetByID(ID);
                var model = mapper.Map<FreelanceVM>(data);

                return Ok(new ApiResponce<FreelanceVM>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<FreelanceVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });

            }

        }
        #endregion



        #region APIPUT

        [Route("~/Api/Freelance/PUTFreelance")]
        [HttpPut]
        public IActionResult PUTFreelance(FreelanceVM freelancevm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = mapper.Map<Freelance>(freelancevm);
                    var Result = freelance.Update(model);


                    return Ok(new ApiResponce<Freelance>
                    {
                        Code = "200",
                        Message = "Data Updated",
                        Statues = "OK",
                        Data = Result
                    });
                }

                return NotFound(new ApiResponce<FreelanceVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Not Found",
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<FreelanceVM>
                {
                    Code = "400",
                    Message = "Data NOT Update",
                    Statues = "Not Found",
                });

            }

        }

        #endregion


        #region APIDelete


        [Route("~/Api/Freelance/DeleteFreelance")]
        [HttpDelete]
        public IActionResult DeleteFreelance(FreelanceVM freelancevm)
        {
            try
            {
                var model = mapper.Map<Freelance>(freelancevm);
                freelance.Delete(model);


                return Ok(new ApiResponce<Freelance>
                {
                    Code = "200",
                    Message = "Data Deleted",
                    Statues = "OK",
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<FreelanceVM>
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
