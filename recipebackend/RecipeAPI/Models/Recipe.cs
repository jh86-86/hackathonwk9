namespace RecipeAPI
{
    public class Recipe
    {
        public int Id { get; set; }
        public string CategoryDish { get; set; }
        public string Title { get; set; }
        public string Theme { get; set; }
        public string PrepTime { get; set; }
        public string CookingTime { get; set; }
        public string Portion { get; set; }
        public string[] Ingredient { get; set; }
        public string[] Instruction { get; set; }
        public string Picture { get; set; }
    }
}

