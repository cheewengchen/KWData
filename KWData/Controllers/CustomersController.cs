using AutoMapper;
using KWData.Contracts;
using KWData.Data;
using KWData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KWData.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _repo;
        private readonly IMapper _mapper;        

        public CustomersController(ICustomerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;            
        }
        
        // GET: CustomersController
        public ActionResult Index(string SearchString)
        {

            //var customers = from m in _db.Customers 
            //                    select m;
            //if (!String.IsNullOrEmpty(SearchString))
            //{
            //    customers = customers.Where(s => s.CustomerName.Contains(SearchString));
            //}

            // var customers =  _repo.FindAll().ToList();

            var customers = _repo.GetCustomerByName(SearchString);
            var model = _mapper.Map<List<Customer>, List<CustomerVM>>(customers.ToList());
            return View(model);
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
