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
    public class ProjectsController : ControllerBase
    {
        #region Filed
        private readonly IProjectRep project;
        private readonly IMapper mapper;
  
        #endregion
        #region Ctor
        public ProjectsController(IProjectRep project,IMapper mapper)
        {
            this.project = project;
            this.mapper = mapper;
         
        }
        #endregion
        #region APIS 

        #region APIGetAll
        [HttpGet]
        [Route("~/Api/Projects/GetData")]
 
        public IActionResult GetData() 
        {
            
            try
            {         
                    var data = project.Get();
                    var model = mapper.Map<IEnumerable<ProjectVM>>(data);
                    return Ok(new ApiResponce<IEnumerable<ProjectVM>>
                    {
                        Code = "200",
                        Message = "Data Retrive",
                        Statues = "OK",
                        Data = model
                    });
           
            }
            catch (Exception ex)
            {
                return NotFound(new ApiResponce<IEnumerable<ProjectVM>>
                {
                    Code = "400",
                    Message =ex.Message ,
                    Statues = "Not Found",
                });
            }



        }
        #endregion

        #region APIGetById

        [Route("~/Api/Projects/GetProjectByID/{id}")]
        [HttpGet]
        public IActionResult GetProjectByID(int ID)
        {
            try
            {

                var data = project.GetByID(ID);
                var model = mapper.Map<ProjectVM>(data);
                return Ok(new ApiResponce<ProjectVM>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<ProjectVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });

            }

        }
        #endregion


        #region APIImplementation
        [HttpGet]
        [Route("~/Api/Projects/Implementation/{id}")]
        public IActionResult Implementation(int ID)
        {
            try
            {
            var data = project.GetByID(ID);
            var model = mapper.Map<ProjectVM>(data);
                return Ok(new ApiResponce<ProjectVM>
                {
                    Code = "200",
                    Message = "Data Retrive",
                    Statues = "OK",
                    Data = model
                });
            }
            catch (Exception)
            {

                return NotFound(new ApiResponce<ProjectVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });
            }
        
        }
        #endregion


        #region APICreate

        [Route("~/Api/Projects/PostProject")]
        [HttpPost]
        public IActionResult PostProject(ProjectVM projectVM )
        {
             
            try
            {
            if (ModelState.IsValid)
            { 

                projectVM.PhotoName = FileUploader.FileUploade("/wwwroot/Files/Images/", projectVM.Photo);
                projectVM.FileName = FileUploader.FileUploade("/wwwroot/Files/Docs/", projectVM.File);
                var model = mapper.Map<Project>(projectVM);
                 var Result =  project.Create(model);

                return Ok(new ApiResponce<Project>
                {
                    Code = "200",
                    Message = "Data Created",
                    Statues = "OK",
                    Data= Result
                });
                }
                return  NotFound(new ApiResponce<ProjectVM>
                {
                    Code = "400",
                    Message = "Data NOT Valid",
                    Statues = "Validation Erro",
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<ProjectVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });

            }

        }
        #endregion


        #region APIPUT

        [Route("~/Api/Projects/PUTProject")]
        [HttpPut]
        public IActionResult PUTEmployee(ProjectVM projectvm)
        {
            try
            {
                var model = mapper.Map<Project>(projectvm);
              var Result=  project.Update(model);

                return Ok(new ApiResponce<Project>
                {
                    Code = "200",
                    Message = "Data Updated",
                    Statues = "OK",
                     Data= Result
                });
            }
            catch (Exception ex)
            {


                return NotFound(new ApiResponce<ProjectVM>
                {
                    Code = "400",
                    Message = "Data NOT Retrive",
                    Statues = "Not Found",
                });

            }

        }

        #endregion


        #region APIDelete


        [Route("~/Api/Projects/DeleteProject")]
        [HttpDelete]
        public IActionResult DeleteEmployee(ProjectVM projectvm)
        {
            try
            {
                var model = mapper.Map<Project>(projectvm);
                project.Delete(model);
                FileUploader.RemoveFile("/wwwroot/Files/Images/",model.PhotoName);
                FileUploader.RemoveFile("/wwwroot/Files/Images/", projectvm.FileName);
                return Ok(new ApiResponce<Project>
                {
                    Code = "200",
                    Message = "Data Deleted",
                    Statues = "OK",                    
                });
            }
            catch (Exception ex)
            {
                return NotFound(new ApiResponce<ProjectVM>
                {
                    Code = "400",
                    Message = "Data NOT Delete",
                    Statues = "Not Found",
                });

            }

        }

        #endregion

        #region APIConfirm 
        
        [Route("~/Api/Projects/Confirm")]
        [HttpGet]
        public IActionResult Confirm( )
        {
            return Ok( new ApiResponce<string>{Code="200"  , Message="Project Confirm" });

            #region Logic
            //try
            //{

            //    projectVM.IsActive=false;
            //    var model = mapper.Map<Project>(projectVM);
            //    var Result = project.Update(model);
            //    return Ok(new ApiResponce<Project>
            //    {
            //        Code = "200",
            //        Message = "Project Is Confirmed",
            //        Statues = "OK",
            //        Data = Result
            //    });
            //}
            //catch (Exception ex)
            //{


            //    return NotFound(new ApiResponce<ProjectVM>
            //    {
            //        Code = "400",
            //        Message = "Data NOT Retrive",
            //        Statues = "Not Found",
            //    });

            //}
            #endregion
        }
        #endregion



        #endregion
    }
}
