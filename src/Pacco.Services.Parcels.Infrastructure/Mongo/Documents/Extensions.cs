using Pacco.Services.Parcels.Application.DTO;
using Pacco.Services.Parcels.Core.Entities;

namespace Pacco.Services.Parcels.Infrastructure.Mongo.Documents
{
    public static class Extensions
    {
        public static Parcel AsEntity(this ParcelDocument document)
            => new Parcel(document.Id, document.CustomerId, document.Variant, document.Size, document.Name,
                document.Description);

        public static ParcelDocument AsDocument(this Parcel entity)
            => new ParcelDocument
            {
                Id = entity.Id,
                CustomerId = entity.CustomerId,
                Variant = entity.Variant,
                Size = entity.Size,
                Name = entity.Name,
                Description = entity.Description
            };

        public static ParcelDto AsDto(this ParcelDocument document)
            => new ParcelDto
            {
                Id = document.Id,
                CustomerId = document.CustomerId,
                Variant = document.Variant.ToString().ToLowerInvariant(),
                Size = document.Size.ToString().ToLowerInvariant(),
                Name = document.Name,
                Description = document.Description
            };
    }
}