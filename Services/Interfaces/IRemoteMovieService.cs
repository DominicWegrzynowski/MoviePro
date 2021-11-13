using MoviePro.Enums;
using MoviePro.Models.TMDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Services.Interfaces
{
    public interface IRemoteMovieService
    {
        Task<MovieDetail> MovieDetailAsync(int id);
        Task<MovieSearch> SearchMoviesAsync(MovieCategory category, int count);
        Task<ActorDetail> ActorDetailAsync(int id);
    }
}
