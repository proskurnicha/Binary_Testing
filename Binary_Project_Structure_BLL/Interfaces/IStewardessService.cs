﻿using Binary_Project_Structure_Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_BLL.Interfaces
{
    public interface IStewardessService
    {
        List<StewardessDto> GetAll();
        StewardessDto GetById(int id);
        void Create(StewardessDto entity);
        void Update(StewardessDto entity);
        bool Delete(int id);
    }
}
