using AutoMapper;
using MyApi.DTOs;
using MyApi.Models;
using MyApi.Repositories.Interfaces;
using MyApi.Services.Interfaces;

namespace MyApi.Services
{
    public class ReviewService : ServiceBase<Review, ReviewDTO, IReviewRepository>, IReviewService
    {
        public ReviewService(IReviewRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
