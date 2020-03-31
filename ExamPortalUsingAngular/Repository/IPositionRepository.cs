using ExamPortalAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortalAngular.Repository
{
    public interface IPositionRepository
    {
        void SaveStudent(Position position);
        IEnumerable<Position> GetAllPositions();
        Position GetPosition(long id);
        void DeletePosition(long id);
        void UpdatePosition(Position position);
    }
}
