using JoePizza.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JoePizza.Controllers
{
    public class PizzaController : Controller
    {
        List<PizzaDetails> pizzaDetails;
        static List<Order> orders = new List<Order>();
        public PizzaController()
        {
            pizzaDetails = new List<PizzaDetails>();
            Info info = new Info();
            info.InsertData();
            pizzaDetails = info.pizzaDetails;
        }
        // GET: PizzaController
        public ActionResult Index()
        {
            return View(pizzaDetails);
        }
        public ActionResult AddToCart(int id)
        {
            TempData["id"] = id;
            var ans = pizzaDetails.Find(x => x.Id == id);
            return View(ans);
        }
        [HttpPost]
        public ActionResult AddToCart(IFormCollection collection)
        {
            // int qty = Convert.ToInt32(Request.Form["qty"]);
            Order order = new Order();
            int id = Convert.ToInt32(TempData["id"]);
            order.Quantity = Convert.ToInt32(Request.Form["qty"]);
            var ans = pizzaDetails.Find(x => x.Id == id);
            order.ProdId = ans.Id;
            order.ProdName = ans.Name;
            order.Total = ans.Price * order.Quantity;
            orders.Add(order);
            return RedirectToAction("Checkout");
        }

        public ActionResult Checkout()
        {
            return View(orders);
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
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

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
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

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
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
