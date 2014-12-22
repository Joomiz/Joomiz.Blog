﻿using Joomiz.Blog.Application.Contracts;
using Joomiz.Blog.Application.Factories;
using Joomiz.Blog.Domain.Contracts.Services;
using Joomiz.Blog.Domain.Entities;
using System;

namespace Joomiz.Blog.Application.Services
{
    public class CommentAppService : ICommentAppService
    {
        private readonly ICommentService commentService;

        public CommentAppService()
        {
            this.commentService = ServiceFactory.GetCommentService();
        }

        public CommentAppService(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        
        public void Approve(int commentId, int authorId)
        {
            // the authorId parameter will be used in near future for logging purposes.

            commentService.Approve(commentId);       
        }

        public void Reject(int commentId, int authorId)
        {
            // the authorId parameter will be used in near future for logging purposes.

            commentService.Reject(commentId);
        }

        public Comment GetById(int id)
        {
            return commentService.GetById(id);
        }

        public PagedList<Comment> GetAll(int pageNumber = 1, int pageSize = 50)
        {
            return commentService.GetAll(pageNumber, pageSize);
        }

        public void Add(Comment obj)
        {
            commentService.Add(obj);
        }

        public void Update(Comment obj)
        {
            commentService.Update(obj);
        }

        public void Delete(int id)
        {
            commentService.Delete(id);
        }
    }
}