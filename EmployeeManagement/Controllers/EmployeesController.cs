using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Context;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
        /**
  * @class EmployeesController
  * @brief Controller class for managing employees.
  */
        public class EmployeesController : Controller
        {
            private readonly ApplicationDbContext _context;

            /**
             * @brief Initializes a new instance of the EmployeesController class.
             * @param context The application database context.
             */
            public EmployeesController(ApplicationDbContext context)
            {
                _context = context;
            }

            /**
             * @brief Retrieves a list of all employees.
             * @return A task that represents the asynchronous operation.
             *         The task result contains the IActionResult object that
             *         renders a view with the list of employees.
             */
            public async Task<IActionResult> Index()
            {
                return _context.Employees != null ?
                            View(await _context.Employees.ToListAsync()) :
                            Problem("Entity set 'ApplicationDbContext.Employees' is null.");
            }

            /**
             * @brief Retrieves the details of an employee.
             * @param id The ID of the employee.
             * @return A task that represents the asynchronous operation.
             *         The task result contains the IActionResult object that
             *         renders a view with the employee details, or returns a
             *         not found result if the employee is not found.
             */
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null || _context.Employees == null)
                {
                    return NotFound();
                }

                var employees = await _context.Employees
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (employees == null)
                {
                    return NotFound();
                }

                return View(employees);
            }

            /**
             * @brief Displays the view for creating a new employee.
             * @return The IActionResult object that renders the create employee view.
             */
            public IActionResult Create()
            {
                return View();
            }

            /**
             * @brief Creates a new employee.
             * @param employees The employee object to create.
             * @return A task that represents the asynchronous operation.
             *         The task result contains the IActionResult object that
             *         redirects to the index action if the employee is created
             *         successfully, or returns the create view if there is a
             *         validation error.
             */
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,FirstName,MiddleName,LastName,EmailAddress,PhoneNo")] Employees employees)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(employees);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(employees);
            }

        // GET: Employees/Edit/5
        /**
         * @brief Displays the view for editing an employee.
         * @param id The ID of the employee to edit.
         * @return A task that represents the asynchronous operation.
         *         The task result contains the IActionResult object that
         *         renders the edit view for the specified employee, or
         *         returns a not found result if the employee is not found.
         */
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }
            return View(employees);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /**
         * @brief Updates an existing employee.
         * @param id The ID of the employee to update.
         * @param employees The updated employee object.
         * @return A task that represents the asynchronous operation.
         *         The task result contains the IActionResult object that
         *         redirects to the index action if the employee is updated
         *         successfully, or returns the edit view if there is a
         *         validation error or concurrency exception.
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,MiddleName,LastName,EmailAddress,PhoneNo")] Employees employees)
        {
            if (id != employees.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeesExists(employees.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employees);
        }

        // GET: Employees/Delete/5
        /**
         * @brief Displays the view for deleting an employee.
         * @param id The ID of the employee to delete.
         * @return A task that represents the asynchronous operation.
         *         The task result contains the IActionResult object that
         *         renders the delete view for the specified employee, or
         *         returns a not found result if the employee is not found.
         */
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: Employees/Delete/5
        /**
         * @brief Deletes an employee.
         * @param id The ID of the employee to delete.
         * @return A task that represents the asynchronous operation.
         *         The task result contains the IActionResult object that
         *         redirects to the index action after the employee is deleted,
         *         or returns a problem result if there is an error.
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Employees == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Employees' is null.");
            }
            var employees = await _context.Employees.FindAsync(id);
            if (employees != null)
            {
                _context.Employees.Remove(employees);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * @brief Checks if an employee with the specified ID exists.
         * @param id The ID of the employee.
         * @return True if an employee with the specified ID exists, otherwise false.
         */
        private bool EmployeesExists(int id)
        {
            return (_context.Employees?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
