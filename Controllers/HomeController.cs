using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(string inputText)
    {
        if (string.IsNullOrWhiteSpace(inputText))
        {
            ViewBag.Error = "Please enter some text.";
            return View();
        }

        var result = Huffman.Encode(inputText);
        ViewBag.EncodedText = result.encoded;

        var codes = new Dictionary<char, string>();
        for (int i = 0; i < 256; i++)
            if (result.codes[i] != null)
                codes[(char)i] = result.codes[i];

        ViewBag.Codes = codes;
        ViewBag.InputText = inputText;
        return View();
    }
}
