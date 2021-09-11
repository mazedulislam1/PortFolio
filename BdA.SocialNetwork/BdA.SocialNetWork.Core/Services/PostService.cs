using BdA.SocialNetWork.Core.Contexts;
using BdA.SocialNetWork.Core.Entities;
using BdA.SocialNetWork.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Services
{
    public class PostService : IPostService
    {
        private IPostUnitOfWork _unitOfWork;
        public PostService(IPostUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddPost(Post post)
        {
            _unitOfWork.PostRepository.Add(post);
        }

        public void DeletePost(Post post)
        {
            _unitOfWork.PostRepository.Delete(post);
        }

        public IEnumerable<Post> GetAll()
        {
            return _unitOfWork.PostRepository.GetAll();
        }

        public Post GetById(int id)
        {
            return _unitOfWork.PostRepository.GetById(id);
        }

        public void UpdatePost(Post post)
        {
            _unitOfWork.PostRepository.Update(post);
        }
    }
}
