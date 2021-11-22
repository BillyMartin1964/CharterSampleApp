using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CharterSampleApp.CharterRestApi.DbContext;
using CharterSampleApp.CharterRestApi.Models;

namespace CharterSampleApp.CharterRestApi.Controllers
{
    [Route("api/UserAccounts")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {
        private readonly CharterContext _context;

        public UserAccountsController(CharterContext context)
        {
            _context = context;
        }

        // GET: api/UserAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserAccount>>> GetCharterUserAccount()
        {
            return await _context.CharterUserAccount.ToListAsync();
        }

        // GET: api/UserAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserAccount>> GetUserAccount(int id)
        {
            var userAccount = await _context.CharterUserAccount.FindAsync(id);

            if (userAccount == null)
            {
                return NotFound();
            }

            return userAccount;
        }

        // PUT: api/UserAccounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserAccount(int id, UserAccount userAccount)
        {
            if (id != userAccount.AccountNumber)
            {
                return BadRequest();
            }

            _context.Entry(userAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserAccountExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserAccount>> PostUserAccount(UserAccount userAccount)
        {
            _context.CharterUserAccount.Add(userAccount);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserAccount), new { id = userAccount.AccountNumber }, userAccount);

           // return CreatedAtAction("GetUserAccount", new { id = userAccount.UserAccountId }, userAccount);
        }

        //// DELETE: api/UserAccounts/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUserAccount(int id)
        //{
        //    var userAccount = await _context.CharterUserAccount.FindAsync(id);
        //    if (userAccount == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.CharterUserAccount.Remove(userAccount);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool UserAccountExists(int id)
        {
            return _context.CharterUserAccount.Any(e => e.AccountNumber == id);
        }
    }
}
