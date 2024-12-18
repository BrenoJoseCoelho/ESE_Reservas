﻿using ReservasApi.Dtos;
using ReservasApi.Models;

namespace ReservasApi.Repositories.Participants
{
    public interface IParticipantRepository
    {
        Task<IEnumerable<ParticipantDto>> GetAll();
        Task<Participant> GetById(Guid id);
        Task<Participant> Create(Participant category);
        Task<Participant> Update(Participant category);
        Task<Participant> Delete(Guid id);
    }
}
