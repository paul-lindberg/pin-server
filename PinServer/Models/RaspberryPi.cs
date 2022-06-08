using Microsoft.AspNetCore.Mvc;

namespace PinServer.Models
{
    public class RaspberryPi : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pin1 { get; set; }
        public int Pin2 { get; set; }
        public int Pin3 { get; set; }

        public RaspberryPi() { }
        public RaspberryPi(int id, string name, int pin1, int pin2, int pin3)
        {
            Id = id;
            Name = name;
            Pin1 = pin1;
            Pin2 = pin2;
            Pin3 = pin3;
        }
    }
}
