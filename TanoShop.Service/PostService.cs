using System;
using System.Collections.Generic;
using System.Linq;
using TanoShop.Data.Infrastructure;
using TanoShop.Data.Repositories;
using TanoShop.Model.Models;

namespace TanoShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(int page, int pageSize, out int totalRow, string tag);
        void SaveChanges();
    }


    public class PostService : IPostService
    {
        IPostRepository _postRepsitory;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            _postRepsitory = postRepository;
            _unitOfWork = unitOfWork;

        }

        public void Add(Post post)
        {
            _postRepsitory.Add(post);
        }

        public void Delete(int id)
        {
            _postRepsitory.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepsitory.GetAll(new string[] {"PostCategory"});
        }

        public IEnumerable<Post> GetAllByTagPaging(int page, int pageSize, out int totalRow, string tag)
        {
            return _postRepsitory.GetMultiPaging(t=>t.Status==true, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepsitory.GetMultiPaging(t => t.Status == true, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepsitory.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepsitory.Update(post);
        }
    }
}
