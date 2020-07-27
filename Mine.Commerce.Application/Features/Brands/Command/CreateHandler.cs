using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Mine.Commerce.Domain;
using Mine.Commerce.Domain.Core;

namespace Mine.Commerce.Application.Brands
{
    public class CreateHandler : IRequestHandler<CreateRequest, Guid>
    {
        private readonly ICommandRepository<Brand> _brandRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateHandler(ICommandRepository<Brand> brandRepository, 
                                IUnitOfWork unitOfWork )
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
        }        
        public async Task<Guid> Handle(CreateRequest request, CancellationToken cancellationToken)
        {
            var brand = Brand.Create(request.Name, request.Country);
            await _brandRepository.AddAsync(brand);
            await _unitOfWork.Commit();
            
            return brand.Id;
        }
    }

    public class CreateRequest : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Country  { get; set; }
    }
}