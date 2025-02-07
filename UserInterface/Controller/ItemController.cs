namespace UserInterface.Controller;
using Microsoft.AspNetCore.Mvc;
using Service;
using DotNetHW2;

[ApiController]
[Route("item-api")]
public class ItemController:ControllerBase
{
    [HttpPost("add-Book")]
    public ContentResult AddBook(int price, int numbersOfItem, string address, int numberOfPages, string publication)
    {
        bool result=Service.ItemService.GetItemService().AddBook(price, numbersOfItem, address, numberOfPages, publication);
        if (result)
        {
            return Content("book added");
        }
        else
        {
            return Content("book not added");
        }
    }

    [HttpPost("add-Pen")]
    public ContentResult AddPen(int price, int numbersOfItem, string address, string brand, string color)
    {
        bool result=Service.ItemService.GetItemService().AddPen(price, numbersOfItem, address, brand, color);
        if (result)
        {
            return Content("pen added");
        }
        else
        {
            return Content("pen not added");
        }
    }

    [HttpDelete("delete-item")]
    public ContentResult removeItem(Item item)
    {
        bool result=Service.ItemService.GetItemService().RemoveItem(item);
        if (result)
        {
            return Content("item removed");
        }
        else
        {
            return Content("item not removed");
        }
    }

    [HttpPatch("Buy-Item")]
    public ContentResult BuyItem(Item item)
    {
        bool result=Service.ItemService.GetItemService().BuyItem(item);
        if (result)
        {
            return Content("item buyed");
        }
        else
        {
            return Content("item not buyed");
        }
    }
}