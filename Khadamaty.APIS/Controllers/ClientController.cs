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
    public class ClientController : ControllerBase
    {
        #region Field
        private readonly IClientRep client;
        private readonly IMapper mapper;
        #endregion
        #region ctor
        public ClientController(IClientRep client, IMapper mapper)
        {
            this.client = client;
            this.mapper = mapper;
           
        }
        #endregion

        #region APIS 


        #region APIGetAll
        [HttpGet]
        [Route("~/Api/Client/GetData")]

        public IActionResult GetData()
        {
            try
            {
                var data = client.Get();
                var model = mapper.Map<IEnumerable<ClientVM>>(data);

                return Ok(new ApiResponce<IEnumerable<ClientVM>>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });

            }
            catch (Exception ex)
            {
                return NotFound(new ApiResponce<IEnumerable<ClientVM>>
                {
                    Code = "400",
                    Message = ex.Message,
                    Statues = "Not Found",
                });
            }



        }
        #endregion

        #region APICreate

        [Route("~/Api/Client/PostClient")]
        [HttpPost]
        public IActionResult PostClient(ClientVM clientVM)
        {

            try
            {
                if (ModelState.IsValid)
                {


                    var model = mapper.Map<Client>(clientVM);
                    var Result = client.Create(model);

                    return Ok(new ApiResponce<Client>
                    {
                        Code = "200",
                        Message = "Data Created",
                        Statues = "OK",
                        Data = Result
                    });
                }
                return NotFound(new ApiResponce<ClientVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Validation Erro"

                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<ClientVM>
                {
                    Code = "400",
                    Message = "Data NOT Created",
                    Statues = ex.Message
                });

            }

        }
        #endregion

        #region APIGetById

        [Route("~/Api/Client/GetClientByID/{id}")]
        [HttpGet]
        public IActionResult GetClientByID(int ID)
        {
            try
            {

                var data = client.GetByID(ID);
                var model = mapper.Map<ClientVM>(data);

                return Ok(new ApiResponce<ClientVM>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<ClientVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });

            }

        }
        #endregion



        #region APIPUT

        [Route("~/Api/Client/PUTClient")]
        [HttpPut]
        public IActionResult PUTClient(ClientVM clientvm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = mapper.Map<Client>(clientvm);
                    var Result = client.Update(model);


                    return Ok(new ApiResponce<Client>
                    {
                        Code = "200",
                        Message = "Data Updated",
                        Statues = "OK",
                        Data = Result
                    });
                }

                return NotFound(new ApiResponce<ClientVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Not Found",
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<ClientVM>
                {
                    Code = "400",
                    Message = "Data NOT Update",
                    Statues = "Not Found",
                });

            }

        }

        #endregion


        #region APIDelete


        [Route("~/Api/Client/DeleteClient")]
        [HttpDelete]
        public IActionResult DeleteClient(ClientVM clientvm)
        {
            try
            {
                var model = mapper.Map<Client>(clientvm);
                client.Delete(model);


                return Ok(new ApiResponce<Client>
                {
                    Code = "200",
                    Message = "Data Deleted",
                    Statues = "OK",
                });
            }
            catch (Exception ex)
            {
               

                return NotFound(new ApiResponce<ClientVM>
                {
                    Code = "400",
                    Message =ex.Message ,
                    Statues = "Data NOT Delete",
                });

            }

        }

        #endregion
        #endregion
    }
}
