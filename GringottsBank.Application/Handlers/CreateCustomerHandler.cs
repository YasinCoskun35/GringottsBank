using GringottsBank.Application.Commands;
using GringottsBank.Application.Mappers;
using GringottsBank.Application.Responses;
using GringottsBank.Core.Entities;
using GringottsBank.Core.Repositories.Base;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GringottsBank.Application.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CustomerResponse>
    {
        private readonly IRepository<Customer> _customerRepo;
        public CreateCustomerHandler(IRepository<Customer> customerRepository)
        {
            _customerRepo = customerRepository;
        }
        public async Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var employeeEntitiy = CustomerMapper.Mapper.Map<Customer>(request);
            if (employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _customerRepo.AddAsync(employeeEntitiy);
            var employeeResponse = CustomerMapper.Mapper.Map<CustomerResponse>(newEmployee);
            return employeeResponse;
        }
    }
}
