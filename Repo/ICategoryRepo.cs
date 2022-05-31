using WebApiProjectMUI_React.DTOs;

namespace WebApiProjectMUI_React.Repo
{
    public interface ICategoryRepo
    {
        public  List<CategoryDTO> GetAllCategory();
        public int AddCategory(CategoryDTO category);
        public int EditCategory(int id, CategoryDTO categoryDto);
        public int DeleteCategory(int id);
    }
}