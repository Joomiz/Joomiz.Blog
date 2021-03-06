﻿using Joomiz.Blog.Domain.Model;
using System;
using System.Collections.Generic;

namespace Joomiz.Blog.Domain.Contracts.Services
{
    public interface ICategoryService : IServiceBase<Category>
    {
        IEnumerable<Category> GetByPostId(int postId);
    }
}
