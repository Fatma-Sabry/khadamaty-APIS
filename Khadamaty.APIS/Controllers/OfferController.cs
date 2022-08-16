using AutoMapper;
using Khadamaty.BL.Helper;
using Khadamaty.BL.Interface;
using Khadamaty.BL.Models;
using Khadamaty.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Khadamaty.APIS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        #region Field
        private readonly IOfferRep offer;
        private readonly IMapper mapper;
        private readonly IProjectRep project;
        #endregion
        #region ctor
        public OfferController(IOfferRep offer,IMapper mapper,IProjectRep project )
        {
            this.offer = offer;
            this.mapper = mapper;
            this.project = project;
        }
        #endregion
        #region APIS 

        #region APIGetAll
        [HttpGet]
        [Route("~/Api/Offer/GetData")]

        public IActionResult GetData()
        {
            try
            {
                    var data = offer.Get();
                    var model = mapper.Map<IEnumerable<OfferVM>>(data);
          
                return Ok(new ApiResponce<IEnumerable<OfferVM>>
                    {
                        Code = "200",
                        Message = "Data Retrive",
                        Statues = "OK",
                        Data = model
                    });
               
            }
            catch (Exception ex)
            {
                return NotFound(new ApiResponce<IEnumerable<OfferVM>>
                {
                    Code = "400",
                    Message = ex.Message,
                    Statues = "Not Found",
                });
            }



        }
        #endregion


        #region APICreate

        [Route("~/Api/Offer/PostOffer")]
        [HttpPost]
        public IActionResult PostOffer(OfferVM offerVM)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    var model = mapper.Map<Offer>(offerVM);
                    var Result = offer.Create(model);

                    return Ok(new ApiResponce<Offer>
                    {
                        Code = "200",
                        Message = "Data Created",
                        Statues = "OK",
                        Data = Result
                    });
                }
              //  var Retrive = new SelectList(project.Get(), "Id", "Discribtion");
                return NotFound(new ApiResponce<OfferVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Validation Erro"
                  
                });
            }
            catch (Exception ex)
            {

              //  var Retrive = new SelectList(project.Get(), "Id", "Discribtion");

                return NotFound(new ApiResponce<OfferVM>
                {
                    Code = "400",
                    Message = "Data NOT Created",
                    Statues = ex.Message
                });

            }

        }
        #endregion


        #region APIGetById

        [Route("~/Api/Offer/GetOfferByID/{id}")]
        [HttpGet]
        public IActionResult GetOfferByID(int ID)
        {
            try
            {

                var data = offer.GetByID(ID);
                var model = mapper.Map<OfferVM>(data);

                return Ok(new ApiResponce<OfferVM>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<OfferVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });

            }

        }
        #endregion



        #region APIPUT

        [Route("~/Api/Offer/PUTOffer")]
        [HttpPut]
        public IActionResult PUTOffer(OfferVM offervm)
        {
            try
            {
                if (ModelState.IsValid) 
                { 
                var model = mapper.Map<Offer>(offervm);
                var Result = offer.Update(model);
            

                return Ok(new ApiResponce<Offer>
                {
                    Code = "200",
                    Message = "Data Updated",
                    Statues = "OK",
                    Data = Result
                });
                }
              //  var offerlist = new SelectList(project.Get(), "Id", "Discribtion",offervm.Id);

                return NotFound(new ApiResponce<OfferVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Not Found",
                });
            }
            catch (Exception ex)
            {

              //  var offerlist = new SelectList(project.Get(), "Id", "Discribtion",offervm.Id);

                return NotFound(new ApiResponce<OfferVM>
                {
                    Code = "400",
                    Message = "Data NOT Update",
                    Statues = "Not Found",
                });

            }

        }

        #endregion


        #region APIDelete


        [Route("~/Api/Offer/DeleteOffer")]
        [HttpDelete]
        public IActionResult DeleteOffer(OfferVM offervm)
        {
            try
            {
                var model = mapper.Map<Offer>(offervm);
                offer.Delete(model);

            //    var list = new SelectList(project.Get(), "Id", "Discribtion", offervm.Id);

                return Ok(new ApiResponce<Offer>
                {
                    Code = "200",
                    Message = "Data Deleted",
                    Statues = "OK",
                });
            }
            catch (Exception ex)
            {
              //  var list = new SelectList(project.Get(), "Id", "Discribtion", offervm.Id);

                return NotFound(new ApiResponce<OfferVM>
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
