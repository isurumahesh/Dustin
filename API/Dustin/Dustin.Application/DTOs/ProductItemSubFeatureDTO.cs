using Dustin.Application.DTOs;

namespace Dustin.Domain.Entities
{
    public record ProductItemSubFeatureDTO
    {
        public SubFeatureDTO SubFeature { get; init; }
       // public ProductItem ProductItem { get; init; }
    }
}