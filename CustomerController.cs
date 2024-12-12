using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCDHProject2.Models;

namespace MVCDHProject2.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {

        private readonly ICustomerDAL obj;
        public CustomerController(ICustomerDAL obj)
        {
            this.obj = obj;
        }
        [AllowAnonymous]
        public ViewResult DisplayCustomers()
        {
            return View(obj.Customers_Select());
        }
        [AllowAnonymous]
        public ViewResult DisplayCustomer(int Custid)
        {
            return View(obj.Customer_Select(Custid));
        }
       // [Authorize]
        public ViewResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult AddCustomer(Customer customer)
        {
            obj.Customer_Insert(customer);
            return RedirectToAction("DisplayCustomers");
        }
      //  [Authorize]
        public ViewResult EditCustomer(int Custid)
        {
            return View(obj.Customer_Select(Custid));
        }
        public RedirectToActionResult UpdateCustomer(Customer customer)
        {
            obj.Customer_Update(customer);
            return RedirectToAction("DisplayCustomers");
        }
       // [Authorize]
        public RedirectToActionResult DeleteCustomer(int Custid)
        {
            obj.Customer_Delete(Custid);
            return RedirectToAction("DisplayCustomers");
        }

    }
}
