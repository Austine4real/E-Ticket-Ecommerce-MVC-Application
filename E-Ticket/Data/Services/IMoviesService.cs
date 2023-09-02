using E_Ticket.Data.Base;
using E_Ticket.Data.ViewModels;
using E_Ticket.Models;

namespace E_Ticket.Data.Services
{
	public interface IMoviesService : IEntityBaseRepository<Movie>
	{
		Task<Movie> GetMovieByIdAsync(int id);
		Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
		Task AddNewMovieAsync(NewMovieVM data);
		Task UpdateMovieAsync(NewMovieVM data);
	}
}
