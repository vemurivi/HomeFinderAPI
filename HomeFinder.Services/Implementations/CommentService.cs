using AutoMapper;
using HomeFinder.Data.Repository.Interfaces;
using HomeFinder.Services.Contracts;
using HomeFinder.Services.Domain;
using System.Threading.Tasks;

namespace HomeFinder.Services.Implementations
{
    public class CommentService : ICommentService
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepo _commentRepo;

        public CommentService(IMapper mapper, ICommentRepo commentRepo)
        {
            _mapper = mapper;
            _commentRepo = commentRepo;
        }
        public async Task<Comment> Create(Comment comment)
        {
            var entity = _mapper.Map<Data.DataObjects.Comment>(comment);
            var result = await _commentRepo.Create(entity);
            return _mapper.Map<Comment>(result);
        }

        public async Task Delete(long key)
        {
            await _commentRepo.Delete(key);
        }

        public async Task<Comment> Read(long key)
        {
            var result = await _commentRepo.Read(key);
            return _mapper.Map<Comment>(result);
        }

        public async Task<Comment> Update(Comment comment)
        {
            var entity = _mapper.Map<Data.DataObjects.Comment>(comment);
            var result = await _commentRepo.Update(entity);
            return _mapper.Map<Comment>(result);
        }
    }
}

