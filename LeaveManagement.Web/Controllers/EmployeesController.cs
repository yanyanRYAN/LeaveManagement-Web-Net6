using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
{

    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);//since we are grabbing employees from db, hide info using mapper
            
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/employeeId  **we changed this from Details, you can change it as long as you have a view that matches the destination.  asp-action="method name" == "method name"
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }



        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                //is form valid??
                if (ModelState.IsValid)
                {
                    //var leaveAllocation = await leaveAllocationRepository.GetAsync(model.Id);
                    //if(leaveAllocation == null)
                    //{
                    //    return NotFound();
                    //}
                    //leaveAllocation.Period = model.Period;
                    //leaveAllocation.NumberOfDays = model.NumberOfDays;
                    //await leaveAllocationRepository.UpdateAsync(leaveAllocation);

                    //return RedirectToAction(nameof(ViewAllocations), new {id = model.EmployeeId});

                    //we want to limit certain crud operations to where they are specified.  I.e, shouldnt be updating data in an edit method.
                    // as a controller should only get filtered/sorted data and pass it to view...the repository should be handling the data access

                    if(await leaveAllocationRepository.UpdateEmployeeAllocation(model))
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                    }

                }
                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occured.  Please try again later.");
                
            }
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveAllocationRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }

       
    }
}
