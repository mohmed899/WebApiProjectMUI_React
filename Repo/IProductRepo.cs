using WebApiProjectMUI_React.DTOs;

namespace WebApiProjectMUI_React.Repo
{
    public interface IProductRepo
    {
        int Add(ProductDTO productDTO);
        List<ProductDTO> getAll();
        public ProductDTO GetByName(string name);
        public int  Update(ProductDTO productDTO);
        public int  Delete(int id);
    }
}