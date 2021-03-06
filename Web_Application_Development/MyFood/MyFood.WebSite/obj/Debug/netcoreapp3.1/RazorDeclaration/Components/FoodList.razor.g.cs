// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyFood.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Hieu_iceTea\Learn\SEM3\Learn_CSharp_FPT\Web_Application_Development\MyFood\MyFood.WebSite\Components\FoodList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hieu_iceTea\Learn\SEM3\Learn_CSharp_FPT\Web_Application_Development\MyFood\MyFood.WebSite\Components\FoodList.razor"
using MyFood.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Hieu_iceTea\Learn\SEM3\Learn_CSharp_FPT\Web_Application_Development\MyFood\MyFood.WebSite\Components\FoodList.razor"
using MyFood.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class FoodList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "D:\Hieu_iceTea\Learn\SEM3\Learn_CSharp_FPT\Web_Application_Development\MyFood\MyFood.WebSite\Components\FoodList.razor"
       
    //01
    Food selectedFood;
    int selectedFoodId;

    void SelectFood(int foodId)
    {
        selectedFoodId = foodId;
        selectedFood = FoodService.GetFoods().First(x => x.Id == foodId);
        GetCurrentRating();
    }

    //02
    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedFood.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        } else
        {
            voteCount = selectedFood.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedFood.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedFood.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedFood.Id}: {rating}");
        FoodService.AddRating(selectedFoodId, rating);
        SelectFood(selectedFoodId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileService FoodService { get; set; }
    }
}
#pragma warning restore 1591
