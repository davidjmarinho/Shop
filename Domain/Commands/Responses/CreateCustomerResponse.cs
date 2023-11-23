using System;

namespace Shop.Domain.Commands.Responses{

    public class CreateCustomerResponse
    {
        public Guid Id  {get; set;}
        public string Name {get; set;}
        public string Email {get;set;}
        
        public DateTime Date {get; set;}
    }
}