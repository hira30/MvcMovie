using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // /HelloWorld にアクセスした時の処理
        public IActionResult Index()
        {
            return View();
        }

        // /HelloWorld/Welcome にアクセスした時の処理
        public string Welcome(string name, int age = 1)
        {
            return $"名前：{name}さん, 年齢：{age}歳";
        }
    }
}