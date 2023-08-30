using E_Ticket.Models;

namespace E_Ticket.Data.Services
{
	public interface IOrdersService
	{
		Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAdress);
		Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
	}
}
