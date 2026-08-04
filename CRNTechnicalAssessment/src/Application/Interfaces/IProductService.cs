using Application.DTOs;
using CRNTechnicalAssessment.src.Application.DTOs;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<ProductDto?> GetByIdAsync(int id);

        Task<ProductDto> CreateAsync(CreateProductDto dto);

        Task UpdateAsync(int id, UpdateProductDto dto);

        Task DeleteAsync(int id);
    }
}