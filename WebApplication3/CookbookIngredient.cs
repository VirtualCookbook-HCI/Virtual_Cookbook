//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3
{
    using System;
    using System.Collections.Generic;
    
    public partial class CookbookIngredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int RecipeId { get; set; }
    
        public virtual CookbookRecipe CookbookRecipe { get; set; }
    }
}
