using DataTables.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SampleCore.Core.Model;
using SampleCore.Core.IServices;
using SampleCore.Entity;

namespace DataTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataService _DataService;
        public HomeController(IDataService DataService)
        {
            
            _DataService = DataService;
        }
        public IActionResult Adding()
        {
            return View();
        }
        public IActionResult Privacy(DataDetail detail)
        { 
            if(ModelState.IsValid)
            {
                _DataService.CreateDataEntry(detail);
                return RedirectToAction("Read");
            }
            else
            {
                return RedirectToAction("Adding");
            }
        }
        public ActionResult Read()
        {
            using (var context = new sampleContext())
            {
                var r = context.Data.ToList();
                return View(r);
            }
        }
        public IActionResult Update(int id)
        {
            var value = _DataService.SaveMethod(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(int id, Data model)
        {
            _DataService.Update(id, model);
            return RedirectToAction("Read");
        }
        public IActionResult Delete(int id)
        {
            _DataService.DeleteConform(id);
            return RedirectToAction("Read");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
    }
}