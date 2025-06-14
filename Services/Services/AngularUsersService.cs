using AutoMapper;
using Repository.IRepo;
using Repository.Models;
using Services.Common;
using Services.DTOs;
using Services.IServices;

namespace Services.Services
{
    public class AngularUsersService(IAngularUserRepo angularUserRepo, IMapper mapper) : IAngularUsersService
    {
        private readonly IAngularUserRepo _angularUserRepo = angularUserRepo;
        private readonly IMapper _mapper = mapper;

        public async Task<GenericResult> GetAllAsync()
        {
            List<AngularUsersDTO> result = _mapper.Map<List<AngularUsers>, List<AngularUsersDTO>>(await _angularUserRepo.GetAllAsync());
            return new GenericResult(result != null, result != null && result.Count > 0 ? Message.Success : Message.NotFound, result != null && result.Count > 0 ? result : null);
        }

        public async Task<GenericResult> CreateAsync(AngularUsersDTO angularUsersDTO)
        {
            AngularUsersDTO result = new();
            if (angularUsersDTO != null)
            {
                result = _mapper.Map<AngularUsers, AngularUsersDTO>(await _angularUserRepo.CreateAsync(_mapper.Map<AngularUsersDTO, AngularUsers>(angularUsersDTO)));
            }
            return new GenericResult(result != null && result.Id > 0, result != null && result.Id > 0 ? Message.Created : Message.Conflict, result != null && result.Id > 0 ? result : null);
        }

        public async Task<GenericResult> GetByIdAsync(int id)
        {
            AngularUsersDTO result = _mapper.Map<AngularUsers, AngularUsersDTO>(await _angularUserRepo.GetByIdAsync(id));
            return new GenericResult(result != null, result != null ? Message.Success : Message.NotFound, result);
        }

        public async Task<GenericResult> UpdateAsync(AngularUsersDTO angularUsersDTO)
        {
            AngularUsersDTO result = new();
            if (angularUsersDTO != null)
            {
                result = _mapper.Map<AngularUsers, AngularUsersDTO>(await _angularUserRepo.UpdateAsync(_mapper.Map<AngularUsersDTO, AngularUsers>(angularUsersDTO)));
            }
            return new GenericResult(result != null && result.Id > 0, result != null && result.Id > 0 ? Message.Success : Message.Conflict, result != null && result.Id > 0 ? result : null);
        }
    }
}