﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZomatoDemo.DomainModel.Models;
using static ZomatoDemo.Repository.UnitOfWork.IUnitOfWorkRepository;

namespace ZomatoDemo.core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public RestaurantController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        //Get:api/Restaurant

        [HttpGet]
        [Route("restaurant/{id}")]
        public async Task<ActionResult> GetRestaurantLocationAsync(int restaurantId)
        {
            return Ok(unitOfWork.Restaurant.GetRestaurantLocation(restaurantId));
        }
        [HttpGet]
        [Route("allrestaurants")]
        public async Task<ActionResult> GetAllRestaurantAsync()
        {
            return Ok(unitOfWork.Restaurant.GetRestaurants());
        }

        [HttpGet]
        [Route("restaurant/{userId}/{restaurantId}")]
        public async Task<ActionResult> GetUserRestaurantAsync(int userId, int restaurantId)
        {
            return Ok(unitOfWork.Restaurant.GetUserRestaurants(userId, restaurantId));
        }

        //post
        [HttpPost]
        [Route("location")]
        public async Task<ActionResult> PostLocationAsync(List<Location> location)
        {
            return Ok(unitOfWork.Restaurant.AddLocation(location));
        }

        [HttpPost]
        [Route("allrestaurants")]
        public async Task<ActionResult> PostAllRestaurantAsync(List<Restaurant> restaurants)
        {
            return Ok(unitOfWork.Restaurant.AddAllRestaurants(restaurants));
        }

        //put
        [HttpPut]
        [Route("restaurant/{id}")]
        public async Task<ActionResult> UpdateRestaurantAsync(int restaurantId)
        {
            return Ok(unitOfWork.Restaurant.EditRestaurant(restaurantId));
        }

        //delete
        [HttpDelete]
        [Route("restaurant/{id}")]
        public async Task<ActionResult> RemoveRestaurantAsync(int restaurantId)
        {
            return Ok(unitOfWork.Restaurant.DeleteRestaurant(restaurantId));
        }
    }
}
