using AutoMapper;
using AdvancedAccountingCustomerTracker.Models;
using AdvancedAccountingCustomerTracker.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedAccountingCustomerTracker.App_Start
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<Accountant, AccountantDto>();
            CreateMap<AccountantDto, Accountant>();
            CreateMap<WorkOrder, WorkOrderDto>();
            CreateMap<WorkOrderDto, WorkOrder>();
        }

    }
}