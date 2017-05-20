using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DniFruitsKart.UI.Components
{
    public class InventoryWidget : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int threshold = 10)
        {
            var inventory = new List<InventoryItem>()
            {
                new InventoryItem() {  Name = "Banner", Count = 8 },
                new InventoryItem() {  Name = "Markers", Count = 3 },
                new InventoryItem() {  Name = "Jacket", Count = 4 },
                new InventoryItem() {  Name = "Hoodie", Count = 12 },
                new InventoryItem() {  Name = "Poster", Count = 6 },
                new InventoryItem() {  Name = "Pens", Count = 16 }
            };

            return View(inventory.Where(x => x.Count <= threshold).ToList());
        }
    }

    public class InventoryItem
    {
        public InventoryItem()
        {
        }

        public int Count { get; set; }
        public string Name { get; set; }
    }
}
