using DataLayer.Context;
using Services.Interfaces;

namespace Services.Services
{
    public class OrderService 
    {
        private OrderContext _context = new();

        public OrderService(OrderContext context)
        {
            _context = context;
        }

        public List<string> GetAll()
        {
            return _context.Personals.Select(x => x.Name).ToList();
        }
    }
}
