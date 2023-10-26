using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeCRUD.Models;



namespace PracticeCRUD.Service
{
    public class FoodService
    {
        private readonly FoodContext _context;

        public FoodService(FoodContext context)
        {
            _context = context;
        }

        public async Task<List<Food>> GetAllFoods()
        {
            return await _context.Food.ToListAsync();
        }

        public async Task<Food> GetFoodById(int id)
        {
            return await _context.Food.FindAsync(id);
        }

        public async Task AddFood(Food food)
        {
            _context.Food.Add(food);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFood(Food food)
        {
            _context.Entry(food).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFood(int id)
        {
            var food = await _context.Food.FindAsync(id);
            if (food != null)
            {
                _context.Food.Remove(food);
                await _context.SaveChangesAsync();
            }
        }

    }

}
