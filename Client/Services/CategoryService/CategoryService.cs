namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        private readonly HttpClient http;

        public CategoryService(HttpClient http)
        {
            this.http = http;
        }

        public List<Category> Categories { get; set; } = new List<Category>();
        public async Task GetCategories()
        {
            var result = await http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if (result != null && result.Success)
                Categories = result.Data;
        }
    }
}
