using AutoMapper;
using BusinessLogic.DTOs.Review;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    internal class ReviewProfile :Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, GetAllReviewDTO>();
            CreateMap<Review, GetReviewByIdDTO>();

            CreateMap<AddReviewDTO, Review>().ReverseMap();
            CreateMap<UpdateReviewDTO, Review>().ReverseMap();
        }
    }
}
