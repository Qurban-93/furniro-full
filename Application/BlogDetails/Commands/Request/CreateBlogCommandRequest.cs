﻿using Application.BlogDetails.Commands.Response;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.BlogDetails.Commands.Request
{
    public class CreateBlogCommandRequest : IRequest<CreateBlogCommandResponse>
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public int CategoryId { get; set; }
        public int AppUserId { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}