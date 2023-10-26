using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeCRUD.Service;
using PracticeCRUD.Models;

namespace PracticeCRUD.Controllers
{
	[ApiController]
	[Route("api/foods")]
	public class FoodController : ControllerBase
	{
		private readonly FoodService _foodService;

		public FoodController(FoodService foodService)
		{
			_foodService = foodService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllFoods()
		{
			var foods = await _foodService.GetAllFoods();
			return Ok(foods);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetFood(int id)
		{
			var food = await _foodService.GetFoodById(id);
			if (food == null)
			{
				return NotFound();
			}
			return Ok(food);
		}

		[HttpPost]
		public async Task<IActionResult> AddFood(Food food)
		{
			await _foodService.AddFood(food);
			return CreatedAtAction("GetFood", new { id = food.ID }, food);
		}

	}


}
