using AutoMapper;
using Br.Com.Restaurant.Api.Controllers;
using Br.Com.Restaurant.Business.DTOs;
using Br.Com.Restaurant.Business.Interfaces;
using Br.Com.Restaurant.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Br.Com.Restaurant.Api.V1
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/restaurants")]
    public class RestaurantController : MainController
    {
        private IRestaurantService service;
        private readonly IMapper mapper;
        
        public RestaurantController(IRestaurantService pService, IMapper pMapper)
        {
            service = pService;
            mapper = pMapper;
        }

        [Route("{id}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<DTORestaurant>> GetRestaurantById(string id)
        {
            try
            {
                var restaurant = mapper.Map<DTORestaurant>(await service.GetRestaurantById(id));

                if (restaurant == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(restaurant);
                }
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Ex);
            }
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<List<DTORestaurant>>> GetRestaurants([FromQuery] string name)
        {
            try
            {
                var list = mapper.Map<List<DTORestaurant>>(await service.GetRestaurants(name));
                return Ok(list);
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<DTORestaurant>> Create([FromBody] DTORestaurant dto)
        {
            try
            {
                var model = mapper.Map<Restaurants>(dto);

                var restaurant = mapper.Map<DTORestaurant>(await service.Save(model));

                return Ok(restaurant);
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Ex);
            }
        }

        [Route("{id}")]
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<DTORestaurant>> Update(string id, [FromBody] DTORestaurant dto)
        {
            try
            {
                var model = mapper.Map<Restaurants>(dto);

                var restaurant = mapper.Map<DTORestaurant>(await service.Update(id, model));

                return Ok(restaurant);
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Ex);
            }
        }

        [Route("{id}")]
        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<bool>> Delete(string id)
        {
            try
            {
                var excluido = await service.Delete(id);

                if (excluido)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception Ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, Ex);
            }
        }
    }
}
