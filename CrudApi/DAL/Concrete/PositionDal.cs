﻿using Crud_UI.Models;
using Crud_UI.Models.Context;
using CrudApi.DAL.Interface;
using System.Collections.Generic;

namespace CrudApi.DAL.Concrete
{
    public class PositionDal : IPositionDal
    {
        BaseContext _baseContext;
        public PositionDal(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public bool AddPositions(Position position)
        {
           var data = _baseContext.Positions.Add(position);
            if (data.State == Microsoft.EntityFrameworkCore.EntityState.Added)
            {
                _baseContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Position> GetAllPositions()
        {
            throw new System.NotImplementedException();
        }

        public Position GetPositions(int positionId)
        {
            throw new System.NotImplementedException();
        }

        public bool RemovePositions(int positionId)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdatePositions(Position position)
        {
            throw new System.NotImplementedException();
        }
    }
}
