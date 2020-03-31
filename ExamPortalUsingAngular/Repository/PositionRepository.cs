using ExamPortalAngular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortalAngular.Repository
{
    public class PositionRepository:IPositionRepository
    {
        private ApplicationContext context;
        private DbSet<Position> positionEntity;
        public PositionRepository(ApplicationContext context)
        {
            this.context = context;
            positionEntity = context.Set<Position>();
        }

        void IPositionRepository.DeletePosition(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Position> GetAllPositions()
        {
            return positionEntity.AsEnumerable();
        }

        Position IPositionRepository.GetPosition(long id)
        {
            throw new NotImplementedException();
        }

        void IPositionRepository.SaveStudent(Position position)
        {
            throw new NotImplementedException();
        }

        void IPositionRepository.UpdatePosition(Position position)
        {
            throw new NotImplementedException();
        }
    }
}
