using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeCRUD.Models;

namespace PracticeCRUD.Service
{
    public class TransactionService
    {
        private readonly TransactionContext _context;

        public TransactionService(TransactionContext context)
        {
            _context = context;
        }

        public async Task<List<Transaction>> GetAllTransactions()
        {
            return await _context.Transaction.ToListAsync();
        }

        public async Task<Transaction> GetTransactionById(int id)
        {
            return await _context.Transaction.FindAsync(id);
        }

        public async Task AddTransaction(Transaction transaction)
        {
            _context.Transaction.Add(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTransaction(Transaction transaction)
        {
            _context.Entry(transaction).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTransaction(int id)
        {
            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction != null)
            {
                _context.Transaction.Remove(transaction);
                await _context.SaveChangesAsync();
            }
        }

    }

}
